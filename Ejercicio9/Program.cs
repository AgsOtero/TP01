using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; // a es la cantidad de divisores
            int d = 0; //que usamos de divisor
            int total = 0; //total sumatoria

            for (int n = 35; n <= 1977; n++) //recorre de 35 hasta 1977
            {
                do
                {
                    d++;
                    if (n % d == 0)//Si el resto de la division es 0, aumento en 1 la cantidad de divisores
                    {
                        a++;
                    }
                }
                while ((d <= n) && (a <= 2)); // mientras el divisor no supere a 35 y la cta de divisores sea menor a 2.
                    if (a != 2)//No es primo, reseteo contadores y paso al proximo numero
                    {
                        d = 0;
                        a = 0;
                    }
                    else//es primo
                    {
                        total = total + n;
                        d = 0;
                        a = 0;
                    }
                }
            Console.WriteLine("El total de la sumatoria es: "+total);
        }    
        }
    }


                


