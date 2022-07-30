namespace Yousource.Api.Extensions.Injection
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Yousource.Infrastructure.Data;
    using Yousource.Infrastructure.Services;
    using Yousource.Services.Order;
    using Yousource.Services.Order.Data;

    public static class OrderServices
    {
        public static void InjectOrderService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDataGateway, OrderSqlDataGateway>();
        }
    }
}
