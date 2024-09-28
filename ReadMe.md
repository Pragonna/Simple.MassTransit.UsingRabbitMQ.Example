<h1>Simple Mass Transit.RabbitMQ</h1>
<h5>Connected with RabbitMQ by MassTransit Bus Service (Enterprice Bus Services)</h5>
<h5>SomeMessage has been sent to queue in cloud (or any pl)</h5>




    
       
            IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
            {
                factory.Host(rabbitMQOptions.Host);
            });

            await bus.StartAsync();

            ISendEndpoint endpoint = await bus.GetSendEndpoint(new Uri(rabbitMQOptions.Endpoint));

            await endpoint.Send<SomeMessage>(new() { Data = model });

        

<h5>SomeMessage</h5>


          public class SomeMessage : ISomeMessage
          {
             public object Data{ get; set; }
          }   


<h5>Consumer</h5>

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



<h5>SomeMessageConsumer</h5>


        public class SomeMessageConsumer : IConsumer<SomeMessage>

        public Task Consume(ConsumeContext<SomeMessage> context)
        {
            object resultData = context.Message.Data;

            return Task.CompletedTask;
        }
        



