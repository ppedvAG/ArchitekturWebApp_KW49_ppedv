using System;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcGreeter.Protos;
using GrpcGreeterClient;
using static GrpcGreeter.Protos.Customer;

namespace GrpcGreeterClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Greeter Hello World Sample
            //unary call
            //5001
            //using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

            //Console.WriteLine("Greeting...:" + reply.Message);
            //Console.WriteLine("Press any Key");
            //Console.ReadKey();
            #endregion

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Customer.CustomerClient(channel); //nach einfügen der PRoto-File bitte ein Rebuild -> Protobuf-Compilier wird aktiv. -> liest Proto-Datei ein und gibt C# Klassen zurück


            CustomerLookupModel clientRequest = new CustomerLookupModel();
            clientRequest.UserId = 1;

            CustomerModel customer = await client.GetCustomerInfoAsync(clientRequest);

            Console.WriteLine($"{customer.FirstName} {customer.LastName}");

            //Beispiel 2

            using (var call = client.GetNewCustomers(new Google.Protobuf.WellKnownTypes.Empty()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    CustomerModel currentCustomer = call.ResponseStream.Current;

                    Console.WriteLine($"{currentCustomer.FirstName} {currentCustomer.LastName}");
                }
            }



            Console.ReadLine();
        }
    }
}
