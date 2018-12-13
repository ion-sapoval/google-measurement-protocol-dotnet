using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Extensions;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Parameters.User;
using GoogleMeasurementProtocol.Requests.Debug;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Requests
{
    public abstract class RequestBase : IGoogleAnalyticsRequest
    {
        internal readonly HttpClient InternalHttpClient;

        public string HitType;

        protected RequestBase(HttpClient httpClient)
        {
            InternalHttpClient = httpClient;

            Parameters = new List<Parameter>();
        }

        public IDebugRequest Debug => new DebugRequest(this);

        public List<Parameter> Parameters { get; set; }

        internal async Task<string> MakeRequestAsync(string httpMethod, HttpClient httpClient, string url)
        {
            ValidateRequestParams();

            if (httpMethod == HttpMethod.GET)
                return await httpClient.GetStringAsync($"{url}?{Parameters.GenerateQueryString()}");

            var response = await httpClient.PostAsync(url, Parameters.GenerateStringContent());
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        internal async Task<string> PostAsync(ClientId clientId, string url)
        {
            CheckAndAddClientId(clientId);

            return await MakeRequestAsync(HttpMethod.POST, InternalHttpClient, url);
        }

        public virtual async Task PostAsync(ClientId clientId)
        {
            await PostAsync(clientId, GoogleEndpointAddresses.Collect);
        }

        internal async Task<string> PostAsync(UserId userId, string url)
        {
            CheckAndAddUserId(userId);

           return await MakeRequestAsync(HttpMethod.POST, InternalHttpClient, url);
        }

        public virtual async Task PostAsync(UserId userId)
        {
            await PostAsync(userId, GoogleEndpointAddresses.Collect);
        }

        internal async Task<string> GetAsync(ClientId clientId, string url)
        {
            CheckAndAddClientId(clientId);

            IfNotExistsAddCacheBusterParam();

            return await MakeRequestAsync(HttpMethod.GET, InternalHttpClient, url);
        }

        public virtual async Task GetAsync(ClientId clientId)
        {
            await GetAsync(clientId, GoogleEndpointAddresses.Collect);
        }

        internal async Task<string> GetAsync(UserId userId, string url)
        {
            CheckAndAddUserId(userId);

            IfNotExistsAddCacheBusterParam();

            return await MakeRequestAsync(HttpMethod.GET, InternalHttpClient, url);
        }

        public virtual async Task GetAsync(UserId userId)
        {
            await GetAsync(userId, GoogleEndpointAddresses.Collect);
        }

        protected virtual void ValidateRequestParams()
        {
            RequiredParamsValidator.Validate(Parameters);

            CompatibilityValidator.Validate(Parameters, this, HitType);
        }

        internal void CheckAndAddUserId(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (Parameters.Any(p => p.Name == userId.Name))
                return;

            Parameters.Add(userId);
        }

        internal void CheckAndAddClientId(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            if (Parameters.Any(p => p.Name == clientId.Name))
                return;

            Parameters.Add(clientId);
        }

        internal void IfNotExistsAddCacheBusterParam()
        {
            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }
        }
    }
}
