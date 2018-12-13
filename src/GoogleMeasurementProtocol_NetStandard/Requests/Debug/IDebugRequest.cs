using System.Threading.Tasks;
using GoogleMeasurementProtocol.Parameters.User;

namespace GoogleMeasurementProtocol.Requests.Debug
{
    public interface IDebugRequest
    {
        /// <summary>
        /// Makes an async Post request to Google Analytics Hit Validation
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        /// <returns>The response root, hitParsingResult, is an array whose length will correspond to the number of hits sent in the original request. 
        /// Each object in the array will contain the keys valid, hit, and parserMessage. 
        /// If a hit is invalid, parserMessage will contain an array of objects describing the validation issues. 
        /// If a hit is valid, parserMessage will be an empty array.</returns>
        Task<RequestValidationResponse> PostAsync(ClientId clientId);

        /// <summary>
        /// Makes an async Post request to Google Analytics
        /// </summary>
        /// <param name="userId">This is intended to be a known identifier for a user provided by the site owner/tracking library user</param>
        /// <returns>The response root, hitParsingResult, is an array whose length will correspond to the number of hits sent in the original request. 
        /// Each object in the array will contain the keys valid, hit, and parserMessage. 
        /// If a hit is invalid, parserMessage will contain an array of objects describing the validation issues. 
        /// If a hit is valid, parserMessage will be an empty array.</returns>
        Task<RequestValidationResponse> PostAsync(UserId userId);

        /// <summary>
        /// Makes an async Get request to Google Analytics Hit Validation
        /// </summary>
        /// <param name="clientId">Anonymously identifies a particular user, device, or browser instance</param>
        /// <returns>The response root, hitParsingResult, is an array whose length will correspond to the number of hits sent in the original request. 
        /// Each object in the array will contain the keys valid, hit, and parserMessage. 
        /// If a hit is invalid, parserMessage will contain an array of objects describing the validation issues. 
        /// If a hit is valid, parserMessage will be an empty array.</returns>
        Task<RequestValidationResponse> GetAsync(ClientId clientId);

        /// <summary>
        /// Makes an async Get request to Google Analytics Hit Validation
        /// </summary>
        /// <param name="userId">This is intended to be a known identifier for a user provided by the site owner/tracking library user</param>
        /// <returns>The response root, hitParsingResult, is an array whose length will correspond to the number of hits sent in the original request. 
        /// Each object in the array will contain the keys valid, hit, and parserMessage. 
        /// If a hit is invalid, parserMessage will contain an array of objects describing the validation issues. 
        /// If a hit is valid, parserMessage will be an empty array.</returns>
        Task<RequestValidationResponse> GetAsync(UserId userId);
    }
}
