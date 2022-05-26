using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples;
using MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples.Interfaces;
using System.Text;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.Controllers
{
    [Route("/coffees")]
    [ApiController]
    public class CoffeesController : ControllerBase
    {
        private readonly IWhiteChocoCoffeeMaker _whiteChocoCoffeeMaker;

        public CoffeesController(IWhiteChocoCoffeeMaker whiteChocoCoffeeMaker)
        {
            _whiteChocoCoffeeMaker = whiteChocoCoffeeMaker;
        }


        [HttpGet("coffee-maker")]
        public IActionResult GetMakeCoffee()
        {
            var builder = new StringBuilder();

            var result = builder.Append(_whiteChocoCoffeeMaker.AddChoco()).AppendLine()
                                .Append(_whiteChocoCoffeeMaker.AddSugar()).AppendLine()
                                .Append(_whiteChocoCoffeeMaker.MakeCoffee())
                                .ToString();

            Console.WriteLine(result);

            return Ok(result);
        }

        
    }
}
