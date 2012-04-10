
using Newtonsoft.Json;
namespace ExchangeLINQ.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Error
    {
        /// <summary>
        /// Gets or sets the id that refers to an error, for example 400.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        [JsonProperty("error_id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the error.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("error_name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the error.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set;}
    }
}
