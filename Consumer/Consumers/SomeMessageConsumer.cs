using MassTransit;
using Message.Shared.Messages;
using System.Text.Json;

namespace Consumer.Consumers
{
    public class SomeMessageConsumer : IConsumer<SomeMessage>
    {
        public Task Consume(ConsumeContext<SomeMessage> context)
        {
            object resultData = context.Message.Data;
            // await someRepository.AddAsync(resultData);
            string jsonResult = JsonSerializer.Serialize(resultData);
            Console.WriteLine($"Json result: \n\n {jsonResult}");

            return Task.CompletedTask;
        }
    }
}
