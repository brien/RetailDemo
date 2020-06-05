using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping.EventHandlers
{
    public class OrderBilledHandler : IHandleMessages<OrderBilled>
    {
        static ILog log = LogManager.GetLogger<OrderBilledHandler>();

        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderBilled, OrderId = {message.OrderId} - Should we ship now?");

            var orderBilled = new OrderBilled
            {
                OrderId = message.OrderId
            };
            return context.Publish(orderBilled);
        }
    }
}
