using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga19Vaje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Vsota(5, 15));

        }

        static int Vsota(int num1, int num2)
        {

            int sestevek = 0;

            for (; num1 < num2; num1++)
            {
                sestevek += num1;
            }



            return sestevek;
        }
    }
}
   
