# HttpClientFactory QuickStart
Shows how to use dependency injection for `HttpClient` in .Net Core 2.2.
See the official docs [HttpClientFactory](https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests)
and [here](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-2.2).

You need to run the Api and then the Web app. The latter makes an http GET request to the Api controller. Both applications require SSL.