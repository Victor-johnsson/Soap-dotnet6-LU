// See https://aka.ms/new-console-template for more information
using ServiceReference1;

Console.WriteLine("Hello, World!");
MySoapWebServiceClient client= new MySoapWebServiceClient();
Console.WriteLine(await client.MyOperationAsync("Victor"));