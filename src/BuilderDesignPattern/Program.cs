using BuilderDesignPattern._1;
using BuilderDesignPattern._2;
using BuilderDesignPattern._3;

// Simple Method
// Cons
// What if we need to have a url for protocol/hostname/queryParams
// ...
// UrlGenerator simpelUrl = new("https", "domain.com", "1200");
// Console.WriteLine(simpelUrl.GetUrl());

// Telescope constructor
// Pros: Less Code
// Cons
// What if we need to have a url for protocol/hostname/queryParams
// ...
// UrlTelescope telescopeUrl = new("https", "domain.com", "1200");
// Console.WriteLine(telescopeUrl.GetUrl());


// Telescope constructor
// Pros: Less Code
var urlBuilder = new UrlBuilder.Builder().WithProtocol("https")
                                         .WithHostname("domain.com")
                                         .WithPort("1200")
                                         .WithPathParams("books")
                                         .WithQueryParams("pashto")
                                         .Build();

Console.WriteLine(urlBuilder.GetUrl());