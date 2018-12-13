using System.Threading.Tasks;
using GoogleMeasurementProtocol.Parameters.User;
using Newtonsoft.Json;

namespace GoogleMeasurementProtocol.Requests.Debug
{
    public class DebugRequest : IDebugRequest
    {
        private readonly RequestBase _requestToDebug;

        public DebugRequest(RequestBase requestToDebug)
        {
            _requestToDebug = requestToDebug;
        }

        public async Task<RequestValidationResponse> PostAsync(ClientId clientId)
        {
            var response = 
                await _requestToDebug.PostAsync(clientId, GoogleEndpointAddresses.DebugCollect);

            return JsonConvert.DeserializeObject<RequestValidationResponse>(response);
        }

        public async Task<RequestValidationResponse> PostAsync(UserId userId)
        {
            var response =
                await _requestToDebug.PostAsync(userId, GoogleEndpointAddresses.DebugCollect);

            return JsonConvert.DeserializeObject<RequestValidationResponse>(response);
        }

        public async Task<RequestValidationResponse> GetAsync(ClientId clientId)
        {
            var response =
                await _requestToDebug.GetAsync(clientId, GoogleEndpointAddresses.DebugCollect);

            return JsonConvert.DeserializeObject<RequestValidationResponse>(response);
        }

        public async Task<RequestValidationResponse> GetAsync(UserId userId)
        {
            var response =
                await _requestToDebug.GetAsync(userId, GoogleEndpointAddresses.DebugCollect);

            return JsonConvert.DeserializeObject<RequestValidationResponse>(response);
        }
    }
}
