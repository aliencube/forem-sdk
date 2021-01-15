# Getting Started in C# #

Here's the typical usage making use of the Forem/DevTo API.


## User Story ##

AS an author who has saved a draft version of blog post onto [dev.to](https://dev.to/),
I WANT to publish the draft post.


## Find Article ID ##

```csharp
var http = new HttpClient();
var previewUri = "https://dev.to/<username>/xxxx-xxxx-temp-slug-xxxx?preview=xxxx";
var html = await http.GetStringAsync(pageUri);

var pattern = "<div.+data-article-id=\"(\\d+)\"\\s*id=\"article-body\">";
var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
var match = regex.Match(html);
var articleId = Convert.ToInt32(match.Groups[1].Value);
```

## Download Preview Post ##

First of all, **generate the API key from [https://dev.to/settings/account](https://dev.to/settings/account)**.

```csharp
var devapi = new DEVAPIbeta(http, false);
devapi.HttpClient.DefaultRequestHeaders.Add("api-key", "<devto_api_key>");

var article = ((await devapi.GetUserUnpublishedArticlesAsync()) as IEnumerable<ArticleMe>)
                .SingleOrDefault(p => p.Id == articleId);
var markdown = article.BodyMarkdown;
```


## Update Frontmatter ##

```csharp
var segments = markdown.Split(new[] { "---" }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(p => p.Trim());
var frontmatter = segments.First();
var body = segments.Skip(1);

var deserialised = new DeserializerBuilder()
                       .WithNamingConvention(UnderscoredNamingConvention.Instance)
                       .Build()
                       .Deserialize<FrontMatter>(frontmatter);
deserialised.Published = true;

var serialised = new SerializerBuilder()
                     .WithNamingConvention(UnderscoredNamingConvention.Instance)
                     .Build()
                     .Serialize(deserialised);
```


## Update Markdown ##

```csharp
var sb = new StringBuilder()
             .AppendLine("---")
             .AppendLine(serialised)
             .AppendLine("---")
             .AppendLine(body);

var updated = new ArticleUpdateArticle()
              {
                  BodyMarkdown = sb.ToString(),
              };

await devapi.UpdateArticleAsync(articleId, new ArticleUpdate(updated));
```
