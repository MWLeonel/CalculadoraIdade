using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNascimento;
            DateTime dataAtual;
            TimeSpan result;

            Console.Write("Digite sua Data de Nascimento: ");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a Data Atual: ");
            dataAtual = DateTime.Parse(Console.ReadLine());
            Console.Write("\n");

            result = dataAtual - dataNascimento;
            Console.WriteLine($"Você tem {result.Days} dias");

            Console.ReadKey();
        }
    }
}
