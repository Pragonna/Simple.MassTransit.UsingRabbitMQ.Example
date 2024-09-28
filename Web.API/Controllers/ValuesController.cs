using Business.RabbitMQ.Producer;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController(IRabbitMQConnection rabbitMQConnection) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Request()
        {
            await rabbitMQConnection.Connect(FakeDataCreator.Library.SomeDataCreator.CreateTickets());
            return Ok();
        }
    }
}
