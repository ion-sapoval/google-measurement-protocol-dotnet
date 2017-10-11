google-measurement-protocol-dotnet
==================================

.Net library for sending Google Analytics Measurement Protocol requests. This library provides support for creating any type of Measurement Protocol request by using any of the existing Measurement Protocol request parameters. It implements basic validation of the requests and parameters, but before using this library please read [Measurement Protocol Developer Guide] and [Measurement Protocol Parameter Reference] for being able to create correct requests.

## NuGet
You can add this library to your project by using NuGet, you just have to type in your Package Manager Console:

```
Install-Package GoogleMeasurementProtocol

```

## Usage examples (C#)

* Create a Page View request

```csharp
           //Create a factory based on your tracking id
            var factory = new GoogleAnalyticsRequestFactory("UA-xxxxxxx-x");

            //Create a PageView request by specifying request type
            var request = factory.CreateRequest(HitTypes.PageView);

            //Add parameters to your request, each parameter has a corresponding class which has name = parameter name from google reference docs
            request.Parameters.Add(new DocumentHostName("test.com"));
            request.Parameters.Add(new DocumentPath("/test/testPath2"));
            request.Parameters.Add(new DocumentTitle("test title2"));

            var clientId = new ClientId(Guid.NewGuid());

            //Make a get request which will contain all information from above
            request.Get(clientId);

            //Make a Post request which will contain all information from above
            request.Post(clientId);
```

* Validating Hits

```csharp
           
            var requestValidationResponseForGet = request.Debug.Get(new UserId("userId"));
            var requestValidationResponseForPost = request.Debug.Post(new UserId("userId"));
            
```

* Connection configuration

```csharp
           var webProxy = new WebProxy("http://localhost:8888");

            //Create a factory which will create requests that will use https connection through the given proxy
            var factory = new GoogleAnalyticsRequestFactory("UA-xxxxxxx-x", webProxy);
```

* Set Agent and Ip info

```csharp
           
            request.Parameters.Add(new UserAgentOverride("Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14"));
            request.Parameters.Add(new IpOverride("1.2.3.4"));
```

License
----

MIT

[Measurement Protocol Developer Guide]:https://developers.google.com/analytics/devguides/collection/protocol/v1/devguide
[Measurement Protocol Parameter Reference]:https://developers.google.com/analytics/devguides/collection/protocol/v1/parameters
