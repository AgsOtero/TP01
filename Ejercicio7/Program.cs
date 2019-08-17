using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultadolebniz = 0;
            double porcentaje = 0;
            Console.WriteLine("Ingrese la cantidad de terminos: ");
            int j = Convert.ToInt32(Console.ReadLine());
            
            for (int n=j; n>=0; n--)
            {
                resultadolebniz = resultadolebniz + ((Math.Pow(-1, n)) / (2 * n + 1));
            }
            resultadolebniz = resultadolebniz * 4;
            porcentaje = 100 -((resultadolebniz * 100) / Math.PI) ;
            Console.WriteLine("El resultado de la formula de Lebniz es: " +resultadolebniz);
            Console.WriteLine("El resultado respecto a la constante en terminos porcentuales es: "+Math.Round(porcentaje,8)+"%");

        }
        
    }
}
