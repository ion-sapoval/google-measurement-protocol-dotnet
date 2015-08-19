using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Extensions;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Parameters.Hit;
using GoogleMeasurementProtocol.Parameters.User;

namespace GoogleMeasurementProtocol.Requests
{
    public abstract class RequestBase : IGoogleAnalyticsRequest
    {
        private readonly Uri _uri;
        protected readonly IWebProxy Proxy;
        protected string HitType;

        protected RequestBase(bool useSsl = false, IWebProxy proxy = null)
        {
            Proxy = proxy;
            Parameters = new List<Parameter>();

            _uri = useSsl ? new Uri("https://ssl.google-analytics.com/collect") : new Uri("http://www.google-analytics.com/collect");
        }

        public List<Parameter> Parameters { get; set; }

        public virtual void Post(Guid clientId)
        {
            Post(new ClientId(clientId));
        }

        public virtual void Post(string clientId)
        {
            Post(new ClientId(clientId));
        }
       
        public virtual void Post(ClientId clientId)
        {
            MakeRequest(clientId,"POST");
        }

        public virtual void Get(Guid clientId)
        {
            Get(new ClientId(clientId));
        }

        public virtual void Get(string clientId)
        {
            Get(new ClientId(clientId));
        }

        public virtual void Get(ClientId clientId)
        {
            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            MakeRequest(clientId, "GET");
        }

        private void MakeRequest(ClientId clientId, string method)
        {
            if (clientId == null || clientId.Value == null)
            {
                throw new ArgumentNullException("clientId");
            }

            Parameters.Add(clientId);

            ValidateRequestParams();

            var requestParams = new NameValueCollection();

            using (var webClient = new WebClient())
            {
                webClient.Proxy = Proxy;

                requestParams.Add(Parameters.GenerateNameValueCollection());

                if (method == "POST")
                {
                    webClient.UploadValues(_uri, method, requestParams);
                }
                else
                {
                    webClient.QueryString = requestParams;
                    webClient.DownloadString(_uri);
                }
            }
        }

        public virtual Task PostAsync(Guid clientId)
        {
            return PostAsync(new ClientId(clientId));
        }

        public virtual Task PostAsync(ClientId clientId)
        {
            return MakeRequestAsync(clientId, "POST");
        }


        public virtual Task GetAsync(Guid clientId)
        {
            return GetAsync(new ClientId(clientId));
        }

        public virtual Task GetAsync(ClientId clientId)
        {
            if (!Parameters.Exists(p => p is CacheBuster))
            {
                Parameters.Add(new CacheBuster(Guid.NewGuid().ToString()));
            }

            return MakeRequestAsync(clientId, "GET");
        }

        private Task MakeRequestAsync(ClientId clientId, string method)
        {
            if (clientId == null || clientId.Value == null)
            {
                throw new ArgumentNullException("clientId");
            }

            Parameters.Add(clientId);

            ValidateRequestParams();

            var requestParams = new NameValueCollection();

            using (var webClient = new WebClient())
            {
                webClient.Proxy = Proxy;

                requestParams.Add(Parameters.GenerateNameValueCollection());

                if (method == "POST")
                {
                    return webClient.UploadValuesTaskAsync(_uri, method, requestParams);
                }
                else
                {
                    webClient.QueryString = requestParams;
                    return webClient.DownloadStringTaskAsync(_uri);
                }
            }
        }

      
        protected virtual void ValidateRequestParams()
        {
            if (!Parameters.Exists(p => p is ProtocolVersion))
            {
                throw new ApplicationException("ProtocolVersion parameter is missing.");
            }

            if (!Parameters.Exists(p => p is TrackingId))
            {
                throw new ApplicationException("TrackingId parameter is missing.");
            }

            if (!Parameters.Exists(p => p is ClientId))
            {
                throw new ApplicationException("ClientId parameter is missing.");
            }

            if (!Parameters.Exists(p => p is HitType))
            {
                throw new ApplicationException("HitType parameter is missing.");
            }

            foreach (var param in Parameters)
            {
                if (param.SupportedHitTypes != null && !param.SupportedHitTypes.Exists(h => h.Equals(HitType)))
                {
                    throw new ApplicationException(string.Format("Parameters of type '{0}' are not supported by requests of type {1}", param.GetType().Name, GetType().Name));
                }
            }
        }
    }
}
