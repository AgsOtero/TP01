using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;
            int sum = 0;
            int cant = 0;
            while (a < b)
            {
                if (a % 2 != 0)
                {
                    sum += a;
                    a += 1;
                    cant += 1;

                }
                else
                {
                    cant += 1;
                    a += 1;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(cant);
            Console.WriteLine(sum / cant);


        }
    }
}

