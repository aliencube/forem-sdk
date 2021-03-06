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

    public partial class WebhookCreateWebhookEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the WebhookCreateWebhookEndpoint
        /// class.
        /// </summary>
        public WebhookCreateWebhookEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookCreateWebhookEndpoint
        /// class.
        /// </summary>
        /// <param name="source">The name of the requester, eg. "DEV"</param>
        /// <param name="events">An array of events identifiers</param>
        public WebhookCreateWebhookEndpoint(string source, string targetUrl, IList<string> events)
        {
            Source = source;
            TargetUrl = targetUrl;
            Events = events;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the requester, eg. "DEV"
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Gets or sets an array of events identifiers
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<string> Events { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (TargetUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetUrl");
            }
            if (Events == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Events");
            }
        }
    }
}
