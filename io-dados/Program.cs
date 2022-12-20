using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //=========== eXcript.com ===========
            //======== NetCoders.com.br  ========

            //CONECTIVOS LÓGICOS

            int num = 0;
            Console.WriteLine("Informe um número no intervalo de 20 à 30.");
            num = Convert.ToInt32( Console.ReadLine() );

            if(num > 20 && num < 30)
            {
                Console.WriteLine("O número está no intervalo.");
            }
            else
            {
                Console.WriteLine("Número incorreto!");
            }
        }
    }
}