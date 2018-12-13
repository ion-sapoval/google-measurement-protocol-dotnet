using System.Collections.Generic;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.User;
using GoogleMeasurementProtocol.Requests.Debug;

namespace GoogleMeasurementProtocol.Requests
{
    public interface IGoogleAnalyticsRequest
    {
        IDebugRequest Debug { get; }

        List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Makes an async Post request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        Task PostAsync(ClientId clientId);

        /// <summary>
        /// Makes an async Post request to Google Analytics
        /// </summary>
        /// <param name="userId">This is intended to be a known identifier for a user provided by the site owner/tracking library user</param>
        Task PostAsync(UserId userId);

        /// <summary>
        /// Makes an async Get request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        Task GetAsync(ClientId clientId);

        /// <summary>
        /// Makes an async Get request to Google Analytics
        /// </summary>
        /// <param name="userId">This is intended to be a known identifier for a user provided by the site owner/tracking library user</param>
        Task GetAsync(UserId userId);
    }
}
