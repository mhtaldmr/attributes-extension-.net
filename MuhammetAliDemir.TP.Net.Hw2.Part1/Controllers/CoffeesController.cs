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
        private readonly ICoffeeMaker _coffeeMaker;

        public CoffeesController(ICoffeeMaker coffeeMaker)
        {
            _coffeeMaker = coffeeMaker;
        }


        [HttpGet("white-choco")]
        public IActionResult GetMakeCoffee()
        {
            var builder = new StringBuilder();
            
            var whiteChocoCoffee = _coffeeMaker as IWhiteChocoCoffeeMaker;
            //Optionally we can use this 
            //var result = ((IAmericanoCoffeeMaker)_coffeeMaker).RemoveSugar;
            
            builder.Append(whiteChocoCoffee.AddChoco())
                   .Append(whiteChocoCoffee.AddSugar())
                   .Append(whiteChocoCoffee.MakeCoffee())
                   .ToString();

            return Ok(builder);
        }

        
    }
}
