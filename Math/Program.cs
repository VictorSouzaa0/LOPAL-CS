// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace Math
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Math Sqrt = (Retorna o valor ao quadrado)
            Console.WriteLine(" --------------- MATH SQRT ---------------");
            Console.WriteLine("Qual número você deseja saber a Raiz quadrada ?: ");
            double number = double.Parse(Console.ReadLine());
            double y = System.Math.Sqrt(number);
            
            Console.WriteLine("Raiz quadrada de " + number  + " = " + y);
            
            //Math Pow = É usado como potênciação (x,y)
            //X = Você seleciona um número raiz da potência 
            Console.WriteLine(" --------------- MATH POW ---------------");
            // y = Você escolhe o número da potência que deseja elevar
            Console.WriteLine("Digite um número que você deseja elevar: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Você deseja elevar até qual potência?: ");
            double number3 = double.Parse(Console.ReadLine());
            double result = System.Math.Pow(number2, number3);
            Console.WriteLine("Número : " + number2 + " elevado á: " + number3 + " = " + result );
            
            //Math Abs = É usado para retornar o valor absoluto inserido:
            Console.WriteLine(" --------------- MATH ABS ---------------");
            Console.WriteLine("Insira um número para descobrir o número  absoluto: ");
            double number4 = double.Parse(Console.ReadLine());
            double resultt = System.Math.Abs(number4);
            Console.WriteLine("O valor absoluto de " + number4 + " = " + resultt);
        }
    }
}

