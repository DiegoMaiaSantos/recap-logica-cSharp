using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas vezes quer repetir? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int cont = 1; cont <= n; cont++)
            {
                Console.Write("Valor #" + cont + ": ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}