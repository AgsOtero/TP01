using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 100;
            int sum = 0;
            int cant = 0;
            do
            {
                sum += a;
                cant += 1;
                a += 1;
            } while (a < b);
            Console.WriteLine(sum);
            Console.WriteLine(cant);
            Console.WriteLine(sum / cant);
        }
    }
}
