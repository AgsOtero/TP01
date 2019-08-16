using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            for (int x = 0; x<50;x++)
            {
                int aux = a;
                a = b;
                b = aux+a;
                Console.WriteLine(a);
                                             
            }
        }
    }
}
