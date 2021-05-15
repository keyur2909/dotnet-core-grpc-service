using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace grpc_client
{
	class Program
	{
		static async Task Main(string[] args)
		{
			using var channel = GrpcChannel.ForAddress("https://localhost:5001");
			var client = new Greeter.GreeterClient(channel);
			var replay = await client.SayHelloAsync(new HelloRequest { Name= "Jane"});
			Console.WriteLine($"Message : {replay.Message}");
			Console.ReadLine();
        }
	}
}
