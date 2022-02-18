using System;

namespace Course 
{
    class Program 
    {
        static void Main(string[] agrs) 
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');
            string s1 = vet[0];
            string s2 = vet[1];
            string s3 = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);            
            Console.WriteLine(x);            
            Console.WriteLine(y);            
            Console.WriteLine(z); 
            Console.WriteLine(s1); 
            Console.WriteLine(s2); 
            Console.WriteLine(s3); 

            Console.ReadLine();            
        }
    }
}