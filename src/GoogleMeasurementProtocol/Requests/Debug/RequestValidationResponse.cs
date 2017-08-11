using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMeasurementProtocol.Requests.Debug
{
    public class RequestValidationResponse
    {
        [JsonProperty("hitParsingResult")]
        public List<HitParsingResult> HitParsingResults { get; set; }
    }
}
