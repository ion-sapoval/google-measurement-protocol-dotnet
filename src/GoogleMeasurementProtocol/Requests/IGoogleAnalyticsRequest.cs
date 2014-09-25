using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.User;

namespace GoogleMeasurementProtocol.Requests
{
    public interface IGoogleAnalyticsRequest
    {
        List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Makes a Post request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        void Post(ClientId clientId);

        /// <summary>
        /// Makes a Post request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        void Post(Guid clientId);

        /// <summary>
        /// Makes a Get request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        void Get(ClientId clientId);

        /// <summary>
        /// Makes a Get request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        void Get(Guid clientId);

        /// <summary>
        /// Makes an async Post request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        Task PostAsync(ClientId clientId);

        /// <summary>
        /// Makes an async Post request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        Task PostAsync(Guid clientId);

        /// <summary>
        /// Makes an async Get request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        Task GetAsync(ClientId clientId);

        /// <summary>
        /// Makes an async Get request to Google Analytics
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        Task GetAsync(Guid clientId);
    }
}
