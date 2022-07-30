namespace Yousource.Api.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Yousource.Api.Extensions;
    using Yousource.Api.Extensions.Orders;
    using Yousource.Api.Filters;
    using Yousource.Api.Messages.Orders.Requests;
    using Yousource.Infrastructure.Services;

    [Route("api/create_order")]
    [TypeFilter(typeof(ValidateModelStateAttribute))]
    [TypeFilter(typeof(LogExceptionAttribute))]
    public class CreateOrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public CreateOrderController(IOrderService orderService)
        {
            Debug.Assert(orderService != null, "Null dependencies");
            this.orderService = orderService;
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> CreateOrderAsync([FromBody] CreateOrderWebRequest request)
        {
            var result = await this.orderService.CreateOrderAsync(request.AsRequest());
            return this.CreateResponse(result.AsWebResponse());
        }

    }
}
