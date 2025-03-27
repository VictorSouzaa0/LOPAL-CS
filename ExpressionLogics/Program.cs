using System.Globalization;

namespace ExpressionLogics
{
    internal class Logics
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insira uma renda do Joaozinho");
            double balanceJao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Insira uma renda  do Clebinho: ");
            double balanceClebs =  double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
        }
    }
}
