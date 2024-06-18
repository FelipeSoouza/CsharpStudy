using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace study_exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu nome:");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa:");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto:" );
            Double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(nome1);
            Console.WriteLine(quarto);
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));

            //Leitura mesma linha //

            Console.WriteLine("Digite seu ultimo nome, idade e altura:");

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

         
        }
    }
}
