using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Requests;
using GoogleMeasurementProtocol.Requests.Batch;


namespace GoogleMeasurementProtocol
{
    public class GoogleAnalyticsRequestFactory
    {
        private readonly ProtocolVersion _protocolVersion = new ProtocolVersion("1");
        private readonly TrackingId _trackingId;
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        private GoogleAnalyticsRequestFactory(IWebProxy proxy)
        {
            _httpClientHandler = new HttpClientHandler
            {
                Proxy = proxy,
                UseProxy = proxy != null
            };

            _httpClient = new HttpClient(_httpClientHandler);
        }

        /// <summary>
        /// Creates an instance of the factory based on the provided parameters.
        /// All requests created by the same instance of the factory will reuse same instance of the HttpClient.
        /// It is recommended to have a singleton factory. 
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="proxy"></param>
        public GoogleAnalyticsRequestFactory(TrackingId trackingId, IWebProxy proxy = null) : this(proxy)
        {
            if (trackingId?.Value == null)
            {
                throw new ArgumentException("TrackingId can't be null or empty.", nameof(trackingId));
            }

            _trackingId = trackingId;
        }

        /// <summary>
        /// Creates an instance of the factory based on the provided parameters.
        /// All requests created by the same instance of the factory will reuse same instance of the HttpClient.
        /// It is recommended to have a singleton factory. 
        /// </summary>
        /// <param name="trackingId"></param>
        /// <param name="proxy"></param>
        public GoogleAnalyticsRequestFactory(string trackingId, IWebProxy proxy = null) : this(proxy)
        {
            if (string.IsNullOrEmpty(trackingId))
            {
                throw new ArgumentException("TrackingId can't be null or empty.", nameof(trackingId));
            }

            _trackingId = new TrackingId(trackingId);
        }


        public IGoogleAnalyticsRequest CreateRequest(string hitType, IEnumerable<Parameter> requestParameters = null)
        {
            if (hitType == null)
            {
                throw new ArgumentNullException(nameof(hitType));
            }

            IGoogleAnalyticsRequest request;

            switch (hitType.ToLower())
            {
                case HitTypes.PageView:

                    request = new PageViewRequest(_httpClient);
                    break;

                case HitTypes.Event:

                    request = new EventRequest(_httpClient);
                    break;

                case HitTypes.Exception:

                    request = new ExceptionTrackingRequest(_httpClient);
                    break;

                case HitTypes.Item:

                    request = new ItemRequest(_httpClient);
                    break;

                case HitTypes.ScreenView:

                    request = new ScreenTrackingRequest(_httpClient);
                    break;

                case HitTypes.Social:

                    request = new SocialInteractionsRequest(_httpClient);
                    break;

                case HitTypes.Timing:

                    request = new UserTimingTrackingRequest(_httpClient);
                    break;

                case HitTypes.Transaction:

                    request = new TransactionRequest(_httpClient);
                    break;


                default:
                    throw new ApplicationException("Unknown hitType: " + hitType);
            }

            request.Parameters.Add(_protocolVersion);
            request.Parameters.Add(_trackingId);

            if (requestParameters != null)
            {
                request.Parameters.AddRange(requestParameters);
            }

            return request;
        }

        /// <summary>
        /// Creates a IGoogleAnalyticsBatchRequest instance that can be used for grouping multiple
        /// requests and make one single call to Google
        /// </summary>
        /// <param name="requests">
        /// Requests to be grouped and send together.
        /// Important: Each request should  contain ClientId or UserId parameter
        /// </param>
        /// <returns></returns>
        public IGoogleAnalyticsBatchRequest CreateBatchRequest(IEnumerable<IGoogleAnalyticsRequest> requests)
        {
            if (requests == null || requests.Count() == 0)
            {
                return null;
            }

            return new BatchRequest(_httpClient, requests.Select(r=>(RequestBase)r));
        }
    }

   
}
