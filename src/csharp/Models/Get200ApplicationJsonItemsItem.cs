// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Aliencube.Forem.DevTo.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Get200ApplicationJsonItemsItem
    {
        /// <summary>
        /// Initializes a new instance of the Get200ApplicationJsonItemsItem
        /// class.
        /// </summary>
        public Get200ApplicationJsonItemsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Get200ApplicationJsonItemsItem
        /// class.
        /// </summary>
        /// <param name="category">Possible values include: 'cfp', 'forhire',
        /// 'collabs', 'education', 'jobs', 'mentors', 'products', 'mentees',
        /// 'forsale', 'events', 'misc'</param>
        public Get200ApplicationJsonItemsItem(string typeOfProperty, long id, string title, string slug, string bodyMarkdown, string tagList, IList<string> tags, string category, string processedHtml, bool published, SharedUser user, SharedOrganization organization)
        {
            TypeOfProperty = typeOfProperty;
            Id = id;
            Title = title;
            Slug = slug;
            BodyMarkdown = bodyMarkdown;
            TagList = tagList;
            Tags = tags;
            Category = category;
            ProcessedHtml = processedHtml;
            Published = published;
            User = user;
            Organization = organization;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type_of")]
        public string TypeOfProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body_markdown")]
        public string BodyMarkdown { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_list")]
        public string TagList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'cfp', 'forhire', 'collabs',
        /// 'education', 'jobs', 'mentors', 'products', 'mentees', 'forsale',
        /// 'events', 'misc'
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processed_html")]
        public string ProcessedHtml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "published")]
        public bool Published { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public SharedUser User { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public SharedOrganization Organization { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TypeOfProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeOfProperty");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Slug == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Slug");
            }
            if (BodyMarkdown == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BodyMarkdown");
            }
            if (TagList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TagList");
            }
            if (Tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tags");
            }
            if (Category == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Category");
            }
            if (ProcessedHtml == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProcessedHtml");
            }
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
            if (Organization == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Organization");
            }
        }
    }
}
