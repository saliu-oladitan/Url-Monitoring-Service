using UrlMonitoringSystem;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //We will add the httpClientFactory into the DI here.
        services.AddHttpClient();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
