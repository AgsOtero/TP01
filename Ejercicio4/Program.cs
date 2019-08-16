using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 100;
            int sum = 0;
            int cant = 0;
            while (a < b)
            {
                sum += a;
                cant += 1;
                a += 1;

            }
            Console.WriteLine(sum);
            Console.WriteLine(cant);
            Console.WriteLine(sum / cant);
        }
    }
}
