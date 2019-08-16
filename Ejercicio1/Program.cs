using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(numero);
            Console.Clear();
            if (numero == 1)
            {
                Console.WriteLine("UNO");
            }
            else if (numero == 1)
            {
                Console.WriteLine("DOS");
            }
            else if (numero ==  3)
            {
                Console.WriteLine("TRES");
            }
            else if (numero == 4)
            {
                Console.WriteLine("CUATRO");
            }
            else if (numero == 5)
            {
                Console.WriteLine("CINCO");
            }
            else if (numero == 6)
            {
                Console.WriteLine("SEIS");
            }
            else if (numero == 7)
            {
                Console.WriteLine("SIETE");
            }
            else if (numero == 8)
            {
                Console.WriteLine("OCHO");
            }
            else if (numero == 9)
            {
                Console.WriteLine("NUEVE");
            }
            else
            {
                Console.WriteLine("OTROS");
            }
            Console.WriteLine("Prueba");
        } 
    }
}
