using System;

namespace StranglerFigPatternExample
{
    // Old order management system
    public class LegacyOrderService
    {
        public void PlaceOrder(string order)
        {
            Console.WriteLine($"[Legacy System] Order placed: {order}");
        }
    }

    // New order management system
    public class NewOrderService
    {
        public void PlaceOrder(string order)
        {
            Console.WriteLine($"[New System] Order placed: {order}");
        }
    }

    // Facade class: Determines which system to use
    public class OrderServiceFacade
    {
        private readonly LegacyOrderService _legacyOrderService;
        private readonly NewOrderService _newOrderService;

        public OrderServiceFacade()
        {
            _legacyOrderService = new LegacyOrderService();
            _newOrderService = new NewOrderService();
        }

        public void PlaceOrder(string order)
        {
            if (ShouldUseNewService(order))
            {
                _newOrderService.PlaceOrder(order); // New system is used
            }
            else
            {
                _legacyOrderService.PlaceOrder(order); // Old system is used
            }
        }

        // Simple rule: The new system only processes orders that start with "NEW"
        private bool ShouldUseNewService(string order)
        {
            return order.StartsWith("NEW");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var orderServiceFacade = new OrderServiceFacade();

            // Orders
            orderServiceFacade.PlaceOrder("OLD Order-001");
            orderServiceFacade.PlaceOrder("NEW Order-002"); // New system will be used
            orderServiceFacade.PlaceOrder("OLD Order-003");
            orderServiceFacade.PlaceOrder("NEW Order-004"); // New system will be used

            Console.WriteLine("Orders processed successfully.");
            Console.ReadLine();
        }
    }
}
