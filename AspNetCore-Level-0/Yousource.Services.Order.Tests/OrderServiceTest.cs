namespace Yousource.Services.Order.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Yousource.Infrastructure.Logging;
    
    using System;
    using System.Linq;
    using Yousource.Infrastructure.Data;

    [TestClass]
    public class OrderServiceTest
    {
        private OrderService target;

        private Mock<IOrderDataGateway> gateway;
        private Mock<ILogger> logger;

        [TestInitialize]
        public void Setup()
        {
            this.logger = new Mock<ILogger>();
            this.gateway = new Mock<IOrderDataGateway>();

            this.target = new OrderService(this.gateway.Object, this.logger.Object);
        }

        [TestCleanup]
        public void Teardown()
        {
            this.logger = null;
            this.gateway = null;

            this.target = null;
        }


        [TestMethod]
        public async Task GetOrdersByEmailAsync_GatewayReturnedData_ActualDataIsEqualToExpected()
        {
            // Arrange
            var expected = new List<Infrastructure.Entities.Orders.Order> { new Infrastructure.Entities.Orders.Order() { SenderEmail = "Test@test.com" } };
            this.gateway.Setup(g => g.GetOrdersByEmailAsync(It.IsAny<string>())).ReturnsAsync(expected);
            var senderemail = "Test@test.com";

            // Act
            var actual = await this.target.GetOrdersByEmailAsync(senderemail);

            // Assert
            Assert.AreEqual(expected.Count, actual.Data.Count());
        }

        [TestMethod]
        public async Task GetOrdersByEmailAsync_ExceptionWasThrown_LoggerWriteExceptionWasCalled()
        {
            this.logger.Setup(l => l.WriteException(It.IsAny<Exception>())).Verifiable();
            this.gateway.Setup(g => g.GetOrdersByEmailAsync(It.IsAny<string>())).ThrowsAsync(new Exception());
            var senderemail = "Test@test.com";

            try
            {
                var actual = await this.target.GetOrdersByEmailAsync(senderemail);
            }

            catch
            {

            }

            this.logger.Verify(l => l.WriteException(It.IsAny<Exception>()));
        }

    }
}




