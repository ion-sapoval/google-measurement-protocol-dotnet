using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
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
        private readonly Uri _uri;
        protected readonly IWebProxy Proxy;
        protected string HitType;

        protected RequestBase(IWebProxy proxy = null)
        {
            Proxy = proxy;
            Parameters = new List<Parameter>();

            _uri = new Uri("https://www.google-analytics.com/collect");

            Debug = new DebugRequest(Parameters, Proxy);
        }

        public IDebugRequest Debug { get; private set; }

        public List<Parameter> Parameters { get; set; }

        public virtual void Post(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            Parameters.Add(clientId);

            MakeRequest("POST");
        }

        public virtual void Post(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Parameters.Add(userId);

            MakeRequest("POST");
        }

        public virtual void Get(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            Parameters.Add(clientId);

            MakeRequest("GET");
        }

        public virtual void Get(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            Parameters.Add(userId);

            MakeRequest("GET");
        }

        private void MakeRequest(string httpMethod)
        {
            ValidateRequestParams();

            var requestParams = new NameValueCollection();

            using (var webClient = new WebClient())
            {
                webClient.Proxy = Proxy;

                requestParams.Add(Parameters.GenerateNameValueCollection());

                if (httpMethod == "POST")
                {
                    webClient.UploadValues(_uri, httpMethod, requestParams);
                }
                else
                {
                    webClient.QueryString = requestParams;
                    webClient.DownloadString(_uri);
                }
            }
        }

        private async Task MakeRequestAsync(string httpMethod)
        {
            ValidateRequestParams();

            var requestParams = new NameValueCollection();

            using (var webClient = new WebClient())
            {
                webClient.Proxy = Proxy;

                requestParams.Add(Parameters.GenerateNameValueCollection());

                if (httpMethod == "POST")
                {
                    await webClient.UploadValuesTaskAsync(_uri, httpMethod, requestParams);
                }
                else
                {
                    webClient.QueryString = requestParams;
                    await webClient.DownloadStringTaskAsync(_uri);
                }
            }
        }

        public virtual async Task PostAsync(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            Parameters.Add(clientId);

            await MakeRequestAsync("POST");
        }

        public virtual async Task PostAsync(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            Parameters.Add(userId);

            await MakeRequestAsync("POST");
        }

        public virtual async Task GetAsync(ClientId clientId)
        {
            if (clientId?.Value == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            Parameters.Add(clientId);

            await MakeRequestAsync("GET");
        }

        public virtual async Task GetAsync(UserId userId)
        {
            if (userId?.Value == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            Parameters.Add(userId);

            await MakeRequestAsync("GET");
        }
      
        protected virtual void ValidateRequestParams()
        {
            RequiredParamsValidator.Validate(Parameters);

            CompatibilityValidator.Validate(Parameters, this, HitType);
        }
    }
}
