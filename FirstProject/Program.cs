// See https://aka.ms/new-console-template for more information

using System.Globalization; 

namespace FirstProject //Nome onde está sendo agrupado o programa
{
    internal class Program //Criando classe que só pode ser utilizada nesse escopo:
    {
        static void Main(String[] args)//Main é o ponto de entrada do programa
        {
            
            //Saída de dados:
            double x = 3.1456;
            Console.WriteLine(x.ToString("F2",CultureInfo.InvariantCulture)); //CultureInfo.InvariantCulture  realiza a troca da "," de um número flutuante por um "."
            double price = 5.00;
            double money = 1000;
            Console.WriteLine("O preço do refrigerante está no total de : " + 
            price.ToString("F2", CultureInfo.InvariantCulture)
            );
            Console.WriteLine("Troco : " + (money - price).ToString("F2", CultureInfo.InvariantCulture));
            
            //Entrada de dados:
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Olá " + name + " Seja bem vindo!!");
            
            //Usando o Split:
            // Console.WriteLine("Insira suas marcas de carros favoritas: ");
            // string[]Cars = Console.ReadLine().Split(' ');
            // Console.WriteLine(Cars[0]);
            // Console.WriteLine(Cars[1]);
            // Console.WriteLine(Cars[2]);
            
            //Entrada de dados PT2:
            Console.WriteLine("Digite suas informações como: nome, sexo e idade na mesma linha \n" +
                              "Lembre-se de dar espaço depois de inserir cada dado!");
            string[] vetor = Console.ReadLine().Split(' ');
            
            string namee = vetor[0];
            char sex = char.Parse(vetor[1]);
            int age = int.Parse(vetor[2]);
            double height = double.Parse(vetor[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Nome: " +namee + "\n" + "Sexo: " + sex + "\n" + "Idade: "+ age  + "\n" + height.ToString(CultureInfo.InvariantCulture));
        }
    }
}

