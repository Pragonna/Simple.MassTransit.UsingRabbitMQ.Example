
namespace Business.RabbitMQ.Producer
{
    public interface IRabbitMQConnection
    {
        Task Connect(object model);
    }
}