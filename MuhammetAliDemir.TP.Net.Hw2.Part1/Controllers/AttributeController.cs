using Microsoft.AspNetCore.Mvc;
using MuhammetAliDemir.TP.Net.Hw2.Part1.Attributes;
using MuhammetAliDemir.TP.Net.Hw2.Part1.Entity;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.Controllers
{
    [Route("/attributes")]
    [ApiController]
    public class AttributeController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAttributes()
        {
            //Creating a new script which is coming from attributes
            var result = ScriptGenerator.Generate(new Student());

            Console.WriteLine(result);

            return Ok(result);
        }
    }
}
