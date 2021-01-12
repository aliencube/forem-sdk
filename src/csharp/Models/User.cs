// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Aliencube.Forem.DevTo.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class User
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="joinedAt">Date of joining (formatted with strftime
        /// `"%b %e, %Y"`)</param>
        /// <param name="profileImage">Profile image (320x320)</param>
        public User(string typeOfProperty, int id, string username, string name, string summary, string twitterUsername, string githubUsername, string websiteUrl, string location, string joinedAt, string profileImage)
        {
            TypeOfProperty = typeOfProperty;
            Id = id;
            Username = username;
            Name = name;
            Summary = summary;
            TwitterUsername = twitterUsername;
            GithubUsername = githubUsername;
            WebsiteUrl = websiteUrl;
            Location = location;
            JoinedAt = joinedAt;
            ProfileImage = profileImage;
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
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "twitter_username")]
        public string TwitterUsername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "github_username")]
        public string GithubUsername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "website_url")]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets date of joining (formatted with strftime `"%b %e,
        /// %Y"`)
        /// </summary>
        [JsonProperty(PropertyName = "joined_at")]
        public string JoinedAt { get; set; }

        /// <summary>
        /// Gets or sets profile image (320x320)
        /// </summary>
        [JsonProperty(PropertyName = "profile_image")]
        public string ProfileImage { get; set; }

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
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Summary == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Summary");
            }
            if (TwitterUsername == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TwitterUsername");
            }
            if (GithubUsername == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GithubUsername");
            }
            if (WebsiteUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebsiteUrl");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (JoinedAt == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JoinedAt");
            }
            if (ProfileImage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProfileImage");
            }
        }
    }
}
