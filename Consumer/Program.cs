
using Consumer.Consumers;
using Consumer.Models;
using MassTransit;

IBusControl bus=Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(RabbitMQOptions.Options.Host);
    factory.ReceiveEndpoint(RabbitMQOptions.Options.QueueName,configure =>
    {
        configure.Consumer<SomeMessageConsumer>();
    });
});

await bus.StartAsync();

Console.Read();
