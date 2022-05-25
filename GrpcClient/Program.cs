using Grpc.Net.Client;
using GrpcServer;
using GrpcServer.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // call server
            var input = new UserRequest();
            input.UserName = "Hai Nam";
            input.Password = "WT436";
            var connect = GrpcChannel.ForAddress("https://localhost:5001");
            var sendData = new User.UserClient(connect);
            var data = await sendData.LoginAsync(input);

            Console.WriteLine("Hello World!" + data);
        }
    }
}
