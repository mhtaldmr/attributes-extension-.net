using MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples.Interfaces;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples
{
    public class BitterWhiteChocoMaker : IWhiteChocoCoffeeMaker
    {
        //Add Extra Bitter Choco
        public string AddChoco()
        {
            return "Adding BITTER chocolate to WhiteChocolateMocha";
        }

        public string AddSugar()
        {
            return "MINIMUM amount of sugar adding to WhiteChocolateMocha";
        }

        //Make it
        public string MakeCoffee()
        {
            return "Make an amazing Bitter Tough WhiteChocolateMocha";
        }
    }
}
