using System;
using GoogleMeasurementProtocol;
using GoogleMeasurementProtocol.Parameters.ContentInformation;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new GoogleAnalyticsRequestFactory("UA-xxxxxxxx-x");
            
            var request = factory.CreateRequest(HitTypes.PageView);

            request.Parameters.Add(new DocumentHostName("test.com"));
            request.Parameters.Add(new DocumentPath("/test/testPath2"));
            request.Parameters.Add(new DocumentTitle("test title2"));

            request.Get(Guid.NewGuid());
            request.Post(Guid.NewGuid().ToString());

            Console.Write("Done!");
            Console.ReadKey();


        }
    }
}
