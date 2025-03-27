// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada individual
            Console.WriteLine("Enre com seu nome completo: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Qunatos quartos tem na sua casa? ");
            int rooms = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Quanto vale sua bicicleta? ");
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            
            //Entrada vetorizada
            Console.WriteLine("Enter com seu último nome, idade e altura (na mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');
            string yname = vet[0];
            int yage = int.Parse(vet[1]);
            double height = double.Parse(vet[2],CultureInfo.InvariantCulture);
            
            //Saída individual:
            Console.WriteLine(name + "\n" + rooms + "\n" + price.ToString("F2",CultureInfo.InvariantCulture));
            
            //Saìda Vetorizada:
            Console.WriteLine("Nome: " + yname + "\n" + "Idade: " + yage + "\n" + "Altura: " + height.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

