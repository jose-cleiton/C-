

using System;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Quantos números");

         int x = int.Parse(Console.ReadLine());

      for (int i =1; i<=x; i++){
        Console.WriteLine("Digite um número");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0){
          Console.WriteLine("Par");
        }
        else{
          Console.WriteLine("Impar");
        



    }
}
  
  }
}
}