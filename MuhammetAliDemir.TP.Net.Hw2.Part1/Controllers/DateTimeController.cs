using Microsoft.AspNetCore.Mvc;
using MuhammetAliDemir.TP.Net.Hw2.Part1.DateTimeExtension;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.Controllers
{
    [Route("/datetimes")]
    [ApiController]
    public class DateTimeController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetTimeDifference([FromQuery] DateTime time)
        {
            //An example of using the extension method!
            var result = time.AgoOrAfter();

            Console.WriteLine(result);

            return Ok(result);
        }
    }
}
