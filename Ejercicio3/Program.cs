using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 100;
            int sumatoria = 0;
            int cantidad = 0;
            for (int a=5;a<b;a++)
            {
                sumatoria += a;
                cantidad += 1;
            }
            Console.WriteLine(sumatoria);
            Console.WriteLine(cantidad);
            Console.WriteLine(sumatoria / cantidad);
           /* Ingresando los limites como variables
            *Console.WriteLine("Ingrese el Límite Inferior");
            int i = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingrese el Límite Superior");
            int k = int.Parse(Console.ReadLine());                
            Console.Clear();
            int sum = 0;
            int cant = -1;
            for (int s=i; s <= k; s++)
            {
                sum += s;
                cant += 1;
                
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum/cant);*/
        }
    }
}
