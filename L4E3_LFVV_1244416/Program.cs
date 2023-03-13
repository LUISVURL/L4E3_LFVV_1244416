using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4E3_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            double a, b, c,op1,op2,op3,op4;

            double x1,x2, f2;
            Console.Write("Ingrese Valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            op1 = (a * b) + c;
            op2 = a * (b + c);
            op3 = a / (b * c);
            op4 = ((3 * a) + (2 * b)) / (c * c);

            Console.WriteLine("");
            Console.WriteLine("El Resultado de i: "+op1);
            Console.WriteLine("El Resultado de ii: " + op2);
            Console.WriteLine("El Resultado de iii: " + op3);
            Console.WriteLine("El Resultado de iv: " + op4);

            f2 = ((b * b) - (4 * a * c));

            Console.WriteLine("");
            Console.WriteLine("El resultado de la formula cuadratica es");
            if (a==0)
            {
                Console.WriteLine("El valor de a debe ser distinto a 0");
                    }
            if (f2<0)
            {
                Console.WriteLine("Hubo un error en la operación de b²-4ac debido a que el resultado es menor a 0");
            }
            if(a != 0 && f2>=0)
            {
                double raiz = Math.Sqrt(f2);
                x1 = ((-1 * b)+raiz)/(2*a);
                x2 = ((-1 * b) - raiz) / (2 * a);
                Console.WriteLine("X1: " + x1);
                Console.WriteLine("X2: " + x2);
            }
            Console.ReadKey();
        }
    }
}
