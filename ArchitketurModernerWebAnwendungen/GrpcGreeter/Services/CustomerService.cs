using Grpc.Core;
using GrpcGreeter.Protos;
using Microsoft.Extensions.Logging;
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

    }
}
