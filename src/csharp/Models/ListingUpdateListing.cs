// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Aliencube.Forem.DevTo.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ListingUpdateListing
    {
        /// <summary>
        /// Initializes a new instance of the ListingUpdateListing class.
        /// </summary>
        public ListingUpdateListing()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListingUpdateListing class.
        /// </summary>
        /// <param name="bodyMarkdown">The body of the listing in Markdown
        /// format.</param>
        /// <param name="category">Possible values include: 'cfp', 'forhire',
        /// 'collabs', 'education', 'jobs', 'mentors', 'products', 'mentees',
        /// 'forsale', 'events', 'misc'</param>
        /// <param name="tags">Tags related to the listing.
        ///
        /// A maximum of 8 tags are allowed and it takes precedence over
        /// `tag_list`.
        /// </param>
        /// <param name="tagList">Comma separated list of tags.
        ///
        /// A maximum of 8 tags are allowed.
        /// </param>
        /// <param name="expiresAt">Date and time of expiration.</param>
        /// <param name="contactViaConnect">True if users are allowed to
        /// contact the listing's owner
        /// via DEV connect, false otherwise.
        ///
        /// Defaults to false.
        /// </param>
        /// <param name="location">Geographical area or city for the
        /// listing.</param>
        /// <param name="action">This param can be provided by itself to invoke
        /// some actions:
        ///
        /// - `bump` bumps the listing and charge either the
        /// organization or the user
        /// - `publish` publishes a draft listing
        /// - `unpublish` unpublishes a published listing
        ///
        /// It will take priority on any other param in the payload.
        /// . Possible values include: 'bump', 'publish', 'unpublish'</param>
        public ListingUpdateListing(string title = default(string), string bodyMarkdown = default(string), string category = default(string), IList<string> tags = default(IList<string>), string tagList = default(string), System.DateTime? expiresAt = default(System.DateTime?), bool? contactViaConnect = default(bool?), string location = default(string), string action = default(string))
        {
            Title = title;
            BodyMarkdown = bodyMarkdown;
            Category = category;
            Tags = tags;
            TagList = tagList;
            ExpiresAt = expiresAt;
            ContactViaConnect = contactViaConnect;
            Location = location;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the body of the listing in Markdown format.
        /// </summary>
        [JsonProperty(PropertyName = "body_markdown")]
        public string BodyMarkdown { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'cfp', 'forhire', 'collabs',
        /// 'education', 'jobs', 'mentors', 'products', 'mentees', 'forsale',
        /// 'events', 'misc'
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets tags related to the listing.
        ///
        /// A maximum of 8 tags are allowed and it takes precedence over
        /// `tag_list`.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets comma separated list of tags.
        ///
        /// A maximum of 8 tags are allowed.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "tag_list")]
        public string TagList { get; set; }

        /// <summary>
        /// Gets or sets date and time of expiration.
        /// </summary>
        [JsonProperty(PropertyName = "expires_at")]
        public System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets true if users are allowed to contact the listing's
        /// owner
        /// via DEV connect, false otherwise.
        ///
        /// Defaults to false.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "contact_via_connect")]
        public bool? ContactViaConnect { get; set; }

        /// <summary>
        /// Gets or sets geographical area or city for the listing.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets this param can be provided by itself to invoke some
        /// actions:
        ///
        /// - `bump` bumps the listing and charge either the
        /// organization or the user
        /// - `publish` publishes a draft listing
        /// - `unpublish` unpublishes a published listing
        ///
        /// It will take priority on any other param in the payload.
        /// . Possible values include: 'bump', 'publish', 'unpublish'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

    }
}
