using Newtonsoft.Json;

namespace GoogleMeasurementProtocol.Requests.Debug
{
    public class ParserMessage
    {
        [JsonProperty(PropertyName = "messageType")]
        public string MessageType { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "parameter")]
        public string Parameter { get; set; }
    }
}
