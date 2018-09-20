using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestabilityRaw.UnitTest
{
    [TestClass]
    public class OrderProcessorTester
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_allreadyShipped_shouldThrowException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order
            {
                Shipment = new Shipment
                {
                    Cost = 12f,
                    ShippingDate = DateTime.Now
                },
                Id = 1200
            };

            orderProcessor.Process(order);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
