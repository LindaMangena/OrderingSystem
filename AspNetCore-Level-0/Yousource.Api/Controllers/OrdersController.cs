namespace Yousource.Api.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Yousource.Api.Extensions;
    using Yousource.Api.Extensions.Orders;
    using Yousource.Api.Filters;
    using Yousource.Infrastructure.Services;

    [Route("api/orders")]
    [TypeFilter(typeof(ValidateModelStateAttribute))]
    [TypeFilter(typeof(LogExceptionAttribute))]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            Debug.Assert(orderService != null, "Null dependencies");
            this.orderService = orderService;
        }

        [HttpGet]
        [AllowAnonymous]

        public async Task<IActionResult> GetOrdersByEmailAsync([FromQuery] string senderemail)
        {
            var result = await this.orderService.GetOrdersByEmailAsync(senderemail);
            return this.CreateResponse(result.AsWebResponse());
        }
    }
}
