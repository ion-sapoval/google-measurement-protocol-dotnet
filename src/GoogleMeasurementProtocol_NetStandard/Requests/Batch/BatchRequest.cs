using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Extensions;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Requests.Batch
{
    public class BatchRequest : IGoogleAnalyticsBatchRequest
    {
        private readonly HttpClient _httpClient;
        private readonly RequestBase[] _requests;

        public BatchRequest(HttpClient httpClient, IEnumerable<RequestBase> requests)
        {
            if (requests.Count() > 20)
            {
                throw new ApplicationException("A maximum of 20 hits can be specified per request.");
            }

            _httpClient = httpClient;
            _requests = requests.ToArray();
        }

        public async Task PostAsync()
        {
            await MakeRequestAsync();
        }

        private async Task MakeRequestAsync()
        {
            ValidateRequestParams();

            var sb = new StringBuilder();

            foreach (var request in _requests)
            {
                sb.AppendLine(request.Parameters.GenerateQueryString());
            }

            var response =
                await _httpClient.PostAsync(GoogleEndpointAddresses.BatchCollect, new StringContent(sb.ToString()));
            response.EnsureSuccessStatusCode();
        }

        private void ValidateRequestParams()
        {
            for (var i=0; i<_requests.Length;i++)
            {
                try
                {
                    RequiredParamsValidator.Validate(_requests[i].Parameters);

                    CompatibilityValidator.Validate(_requests[i].Parameters, _requests[i],_requests[i].HitType);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Parameters validation failed for request with index = {i} with: {ex.Message}");
                }
            }
        }
    }
}
