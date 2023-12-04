using Microsoft.AspNetCore.Mvc;
using PusherServer;
using System.Net;

namespace PusherSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> HelloWorld()
        {
            var options = new PusherOptions
            {
                Cluster = "eu",
                Encrypted = true
            };

            var pusher = new Pusher(
              "1719290",
              "f2b973891577862a5c42",
              "25d89d448bc7435ae332",
              options);

            var result = await pusher.TriggerAsync(
              "my-channel",
              "my-event",
              new { message = "hello world" });

            return Ok();
        }
    }
}
