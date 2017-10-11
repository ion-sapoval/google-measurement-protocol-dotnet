using System;
using System.Linq;
using System.Runtime.Serialization;
using GoogleMeasurementProtocol;
using GoogleMeasurementProtocol.Parameters.ContentInformation;
using GoogleMeasurementProtocol.Parameters.ECommerce;
using GoogleMeasurementProtocol.Parameters.User;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new GoogleAnalyticsRequestFactory("UA-104485591-1");
            
            var request = factory.CreateRequest(HitTypes.PageView);

            request.Parameters.Add(new DocumentHostName("test.com"));
            request.Parameters.Add(new DocumentPath("/test/testPath4"));
            request.Parameters.Add(new DocumentTitle("test title2"));

            //request.GetAsync(new ClientId(Guid.NewGuid())).Wait();
            request.PostAsync(new UserId(Guid.NewGuid().ToString())).Wait();

            var requestValidationResponse = request.Debug.Get(new UserId("userId"));

            Console.Write("Done!");
            Console.ReadKey();
        }
    }
}
