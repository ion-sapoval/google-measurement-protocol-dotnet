using System;
using System.Collections.Generic;
using GoogleMeasurementProtocol;
using GoogleMeasurementProtocol.Parameters.ContentInformation;
using GoogleMeasurementProtocol.Parameters.User;
using GoogleMeasurementProtocol.Requests;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new GoogleAnalyticsRequestFactory("UA-104485591-1");
            
            var request1 = factory.CreateRequest(HitTypes.PageView);

            request1.Parameters.Add(new DocumentHostName("test55.com"));
            request1.Parameters.Add(new DocumentPath("/test/testPath6"));
            request1.Parameters.Add(new DocumentTitle("test title2"));
            request1.Parameters.Add(new UserId(Guid.NewGuid().ToString()));

            var request2 = factory.CreateRequest(HitTypes.PageView);

            request2.Parameters.Add(new DocumentHostName("test555.com"));
            request2.Parameters.Add(new DocumentPath("/test/testPath555"));
            request2.Parameters.Add(new DocumentTitle("test title5"));
            request2.Parameters.Add(new ClientId(Guid.NewGuid().ToString()));

            request1.GetAsync(new ClientId(Guid.NewGuid())).Wait();
            request1.PostAsync(new UserId(Guid.NewGuid().ToString())).Wait();

            var batchRequest = 
                factory.CreateBatchRequest(new List<IGoogleAnalyticsRequest> { request1, request2 });

            batchRequest.PostAsync().Wait();

            var requestValidationResponse = request1.Debug.PostAsync(new UserId("userId")).Result;

            Console.Write("Done!");
            Console.ReadKey();
        }
    }
}
