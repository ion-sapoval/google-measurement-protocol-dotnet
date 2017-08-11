using System;
using System.Collections.Generic;
using System.Net;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Requests;


namespace GoogleMeasurementProtocol
{
    public class GoogleAnalyticsRequestFactory
    {
        private readonly IWebProxy _proxy;
        private readonly ProtocolVersion _protocolVersion = new ProtocolVersion("1");
        private readonly TrackingId _trackingId;
        private readonly bool _useSsl;

        public GoogleAnalyticsRequestFactory(string trackingId, bool useSslConnection = false, IWebProxy proxy = null)
        {
            if (string.IsNullOrEmpty(trackingId))
            {
                throw new ArgumentException("TrackingId can't be null or empty.", nameof(trackingId));
            }

            _trackingId = new TrackingId(trackingId);
            _proxy = proxy;
            _useSsl = useSslConnection;
        }

        public GoogleAnalyticsRequestFactory(TrackingId trackingId, bool useSslConnection = false, IWebProxy proxy = null)
        {
            if (trackingId?.Value == null)
            {
                throw new ArgumentException("TrackingId can't be null or empty.", nameof(trackingId));
            }

            _trackingId = trackingId;
            _proxy = proxy;
            _useSsl = useSslConnection;
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

                    request = new PageViewRequest(_useSsl, _proxy);
                    break;

                case HitTypes.Event:

                    request = new EventRequest(_useSsl, _proxy);
                    break;

                case HitTypes.Exception:

                    request = new ExceptionTrackingRequest(_useSsl, _proxy);
                    break;

                case HitTypes.Item:

                    request = new ItemRequest(_useSsl, _proxy);
                    break;

                case HitTypes.ScreenView:

                    request = new ScreenTrackingRequest(_useSsl, _proxy);
                    break;

                case HitTypes.Social:

                    request = new SocialInteractionsRequest(_useSsl, _proxy);
                    break;

                case HitTypes.Timing:

                    request = new UserTimingTrackingRequest(_useSsl, _proxy);
                    break;

                case HitTypes.Transaction:

                    request = new TransactionRequest(_useSsl, _proxy);
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
    }
}
