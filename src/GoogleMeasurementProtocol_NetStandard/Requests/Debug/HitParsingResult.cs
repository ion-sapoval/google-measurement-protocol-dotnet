using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMeasurementProtocol.Requests.Debug
{
    public class HitParsingResult
    {
        [JsonProperty(PropertyName = "valid")]
        public bool Valid { get; set; }

        [JsonProperty(PropertyName = "hit")]
        public string Hit { get; set; }

        [JsonProperty(PropertyName = "parserMessage")]
        public List<ParserMessage> ParserMessages { get; set; }
    }
}
