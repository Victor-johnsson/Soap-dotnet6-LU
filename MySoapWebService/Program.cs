using MySoapWebService.Services;
using SoapCore;
using System.ServiceModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<IMySoapWebService, MySoapWebService.Services.MySoapWebService>();

builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IMySoapWebService>("/service.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Hello, world!");
    });
});

app.Run();
