using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program


    {

      static int Maior(int a, int b, int c){
        int maior = 0;
        if (a > b && a > c){
          maior = a;
        }else if (b > a && b > c){
          maior = b;
        }else{
          maior = c;
        }
        return maior;
      }



        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double maior = Maior(a, b, c);

            Console.WriteLine("Maior = " + maior);

        }
    }
}

