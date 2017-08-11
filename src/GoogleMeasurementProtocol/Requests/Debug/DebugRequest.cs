using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Extensions;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Parameters.User;
using GoogleMeasurementProtocol.Validators;
using Newtonsoft.Json;

namespace GoogleMeasurementProtocol.Requests.Debug
{
    public class DebugRequest : IDebugRequest
    {
        private readonly Uri _uri;
        private readonly IWebProxy _proxy;
        private readonly List<Parameter> _parameters;
        public DebugRequest(List<Parameter> requestParameters, IWebProxy proxy = null)
        {
            _proxy = proxy;

            _parameters = requestParameters;

            _uri = new Uri("https://www.google-analytics.com/debug/collect");
        }

        public RequestValidationResponse Post(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            _parameters.Add(clientId);

            return MakeRequest("POST");
        }

        public RequestValidationResponse Post(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            _parameters.Add(userId);

            return MakeRequest("POST");
        }

        public RequestValidationResponse Get(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            if (!_parameters.Exists(p => p is CacheBuster))
            {
                _parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            _parameters.Add(clientId);

            return MakeRequest("GET");
        }

        public RequestValidationResponse Get(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (!_parameters.Exists(p => p is CacheBuster))
            {
                _parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            _parameters.Add(userId);

            return MakeRequest("GET");
        }

        private RequestValidationResponse MakeRequest(string httpMethod)
        {
            ValidateRequestParams();

            var requestParams = new NameValueCollection();

            using (var webClient = new WebClient())
            {
                webClient.Proxy = _proxy;

                requestParams.Add(_parameters.GenerateNameValueCollection());

                string requestValidationResponseAsJson;

                if (httpMethod == "POST")
                {
                    requestValidationResponseAsJson =
                        Encoding.UTF8.GetString(webClient.UploadValues(_uri, httpMethod, requestParams));
                }
                else
                {
                    webClient.QueryString = requestParams;
                    requestValidationResponseAsJson = webClient.DownloadString(_uri);
                }

                return JsonConvert.DeserializeObject<RequestValidationResponse>(requestValidationResponseAsJson);
            }
        }

        private async Task<RequestValidationResponse> MakeRequestAsync(string httpMethod)
        {
            ValidateRequestParams();

            var requestParams = new NameValueCollection();

            using (var webClient = new WebClient())
            {
                webClient.Proxy = _proxy;

                requestParams.Add(_parameters.GenerateNameValueCollection());

                string requestValidationResponseAsJson;

                if (httpMethod == "POST")
                {
                    requestValidationResponseAsJson =
                        Encoding.UTF8.GetString(await webClient.UploadValuesTaskAsync(_uri, httpMethod, requestParams));
                }
                else
                {
                    webClient.QueryString = requestParams;
                    requestValidationResponseAsJson = await webClient.DownloadStringTaskAsync(_uri);
                }

                return JsonConvert.DeserializeObject<RequestValidationResponse>(requestValidationResponseAsJson);
            }
        }

        public async Task<RequestValidationResponse> PostAsync(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            _parameters.Add(clientId);

            return await MakeRequestAsync("POST");
        }

        public async Task<RequestValidationResponse> PostAsync(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            _parameters.Add(userId);

            return await MakeRequestAsync("POST");
        }

        public async Task<RequestValidationResponse> GetAsync(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            if (!_parameters.Exists(p => p is CacheBuster))
            {
                _parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            _parameters.Add(clientId);

            return await MakeRequestAsync("GET");
        }

        public async Task<RequestValidationResponse> GetAsync(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (!_parameters.Exists(p => p is CacheBuster))
            {
                _parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            _parameters.Add(userId);

            return await MakeRequestAsync("GET");
        }

        private void ValidateRequestParams()
        {
            RequiredParamsValidator.Validate(_parameters);
        }
    }
}
