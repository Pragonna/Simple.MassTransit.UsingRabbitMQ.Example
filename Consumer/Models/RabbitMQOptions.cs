
using System.Configuration;

namespace Consumer.Models
{
    public class RabbitMQOptions
    {
        public string Host { get; set; }
        public string Endpoint { get; set; }
        public string QueueName { get; set; }
        public static RabbitMQOptions Options
        {
            get
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection appSettings = config.AppSettings.Settings;

                return new()
                {
                    Host = appSettings[nameof(Host)].Value,
                    Endpoint = appSettings[nameof(Endpoint)]?.Value,
                    QueueName = appSettings[nameof(QueueName)]?.Value
                };
            }
        }
    }
}
