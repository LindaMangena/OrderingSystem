namespace Yousource.Services.Order
{

    using System;
    using Yousource.Infrastructure.Logging;
    using Yousource.Services.Order.Data;
    using Yousource.Infrastructure.Services;
    using Yousource.Infrastructure.Messages.Orders.Requests;
    using Yousource.Infrastructure.Messages.Orders.Responses;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Yousource.Services.Order.Extensions;
    using Yousource.Services.Order.Exceptions;
    using Yousource.Services.Order.Constants;
    using Yousource.Services.Order.Specifications;
    using Yousource.Infrastructure.Data;

    public class OrderService : IOrderService
    {
        private readonly IOrderDataGateway dataGateway;
        private readonly ILogger logger;

        public OrderService(
            IOrderDataGateway dataGateway,
            ILogger logger)
        {
            this.dataGateway = dataGateway;
            this.logger = logger;
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            var result = new CreateOrderResponse();
            var errors = new List<string>() as ICollection<string>;

            try
            {
                var spec = new ValidateCreateOrderRequestSpecification();
                if (spec.IsSatisfiedBy(request, ref errors))
                {
                    await this.dataGateway.InsertOrderAsync(request.AsEntity());
                }
                else
                {
                    result.SetError(Errors.CreateValidationError, errors);
                }
            }
            catch (Exception ex)
            {
                this.logger.WriteException(ex);
                throw new OrderServiceException(ex);
            }

            return result;
        }


        public async Task<GetOrdersByEmailResponse> GetOrdersByEmailAsync(string senderemail)
        {
            var result = new GetOrdersByEmailResponse();



            try
            {
                result.Data = (await this.dataGateway.GetOrdersByEmailAsync(senderemail)).AsModel();
            }
            catch (Exception ex)
            {
                this.logger.WriteException(ex);
                throw new OrderServiceException(ex);
            }

            return result;



        }
    }
}
