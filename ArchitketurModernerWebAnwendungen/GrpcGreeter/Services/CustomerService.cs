using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcGreeter.Protos;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GrpcGreeter.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new();
            
            if (request.UserId == 1)
            {
                output.FirstName = "Scott";
                output.LastName = "Hanselmann";
            }
            else if(request.UserId == 2)
            {
                output.FirstName = "Tim";
                output.LastName = "Corey";
            }
            else if(request.UserId ==3)
            {
                output.FirstName = "Hannes";
                output.LastName = "Preishuber";
            }

            return Task.FromResult(output);
        }

        public override async Task GetNewCustomers(
            Empty request, 
            IServerStreamWriter<CustomerModel> responseStream, 
            ServerCallContext context)
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            customers.Add(new CustomerModel() { FirstName = "Tim", LastName = "Corey", Age = 33, EmailAdress = "Tidadfg", IsAlive = true });
            customers.Add(new CustomerModel() { FirstName = "Bilbo", LastName = "Aueneland", Age = 133, EmailAdress = "bilbo@auenland.de", IsAlive = true });
            customers.Add(new CustomerModel() { FirstName = "Andre", LastName = "R", Age = 33, EmailAdress = "abc@def.gh", IsAlive = true });


            foreach(var cust in customers)
            {
                await responseStream.WriteAsync(cust);
            }
        }

    }
}
