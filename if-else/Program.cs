using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora?");
            int hora = int.Parse(Console.ReadLine());
            if(hora<12) Console.WriteLine("Bom dia!");
            
            else if(hora<18) Console.WriteLine("Baa tarde!");
        
            else  Console.WriteLine("Boa noite!");

        }
    }
}

