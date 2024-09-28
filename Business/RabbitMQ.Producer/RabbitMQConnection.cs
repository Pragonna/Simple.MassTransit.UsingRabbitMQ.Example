
using Business.Models;
using MassTransit;
using Message.Shared.Messages;
using Microsoft.Extensions.Options;

namespace Business.RabbitMQ.Producer
{
    public class RabbitMQConnection(IOptions<RabbitMQOptions> options) : IRabbitMQConnection
    {
        readonly RabbitMQOptions rabbitMQOptions = options.Value;
        public async Task Connect(object model)
        {
            IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
            {
                factory.Host(rabbitMQOptions.Host);
            });

            await bus.StartAsync();

            ISendEndpoint endpoint = await bus.GetSendEndpoint(new Uri(rabbitMQOptions.Endpoint));

            await endpoint.Send<SomeMessage>(new() { Data = model });

        }
    }
}
