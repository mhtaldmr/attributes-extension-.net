using MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples.Interfaces;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.SolidPrinciples
{
    public class SweetWhiteChocoMaker : IWhiteChocoCoffeeMaker
    {
        public string AddChoco()
        {
            return "Adding chocolate to WhiteChocolateMocha!";
        }

        //Add Extra Sugar
        public string AddSugar()
        {
            return "5-SPOON of Sugar Adding to WhiteChocolateMocha!";
        }

        public string  MakeCoffee()
        {
            return "Make an perfect SWEET smooth WhiteChocolateMocha!";
        }
    }
}
