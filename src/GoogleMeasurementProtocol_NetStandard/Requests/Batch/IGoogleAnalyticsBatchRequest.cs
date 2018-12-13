using System.Threading.Tasks;

namespace GoogleMeasurementProtocol.Requests.Batch
{
    public interface IGoogleAnalyticsBatchRequest
    {
        /// <summary>
        /// Makes an async Post batch request to Google Analytics.
        /// </summary>
        Task PostAsync();
    }
}
