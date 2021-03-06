// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Aliencube.Forem.DevTo.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PodcastEpisodePodcast
    {
        /// <summary>
        /// Initializes a new instance of the PodcastEpisodePodcast class.
        /// </summary>
        public PodcastEpisodePodcast()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PodcastEpisodePodcast class.
        /// </summary>
        public PodcastEpisodePodcast(string title = default(string), string slug = default(string), string imageUrl = default(string))
        {
            Title = title;
            Slug = slug;
            ImageUrl = imageUrl;
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
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

    }
}
