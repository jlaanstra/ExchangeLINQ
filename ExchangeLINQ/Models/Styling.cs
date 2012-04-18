using System.Windows.Media;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Styling
    {
        [JsonProperty("link_color")]
        [JsonConverter(typeof(ExchangeLINQ.Common.ColorConverter))]
        public Color LinkColor { get; set; }

        [JsonProperty("tag_foreground_color")]
        [JsonConverter(typeof(ExchangeLINQ.Common.ColorConverter))]
        public Color TagForegroundColor { get; set; }

        [JsonProperty("tag_background_color")]
        [JsonConverter(typeof(ExchangeLINQ.Common.ColorConverter))]
        public Color TagBackgroundColor { get; set; }
    }
}
