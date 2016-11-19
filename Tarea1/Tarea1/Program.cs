using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoDeOperacion = 0;
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            Console.WriteLine("¿Que operacion vas a realizar?");
            Console.WriteLine("Suma              1");
            Console.WriteLine("Resta             2");
            Console.WriteLine("Multiplicacion    3");
            Console.WriteLine("Division          4");

            tipoDeOperacion = Convert.ToInt16(Console.ReadLine());
            if (tipoDeOperacion == 1)
            {
                Console.WriteLine("Escribe dos numeros para sumar");
                Console.WriteLine("Escribe tu primer numero:");
                num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo numero:");
                num2 = Convert.ToInt16(Console.ReadLine());

                resultado = num1 + num2;

                Console.WriteLine("El resultado de la Suma es: "+resultado); 
               
                Console.ReadLine();
            }
            else if (tipoDeOperacion == 2)
            {
                Console.WriteLine("Escribe dos numeros para Restar");
                Console.WriteLine("Escribe tu primer numero:");
                num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo numero:");
                num2 = Convert.ToInt16(Console.ReadLine());

                resultado = num1 - num2;

                Console.WriteLine("El resultado de la Resta es: " + resultado);
                Console.ReadLine();
            }
            else if (tipoDeOperacion == 3)
            {
                Console.WriteLine("Escribe dos numeros para Multiplicar");
                Console.WriteLine("Escribe tu primer numero:");
                num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo numero:");
                num2 = Convert.ToInt16(Console.ReadLine());

                resultado = num1* num2;
                Console.WriteLine("El resultado de la Multiplicacion es: " + resultado);
                Console.ReadLine();
            }
            else if (tipoDeOperacion == 4)
            {
                Console.WriteLine("Escribe dos numeros para Dividir");

                Console.WriteLine("Escribe tu primer numero:");
                num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escribe tu segundo numero:");
                num2 = Convert.ToInt16(Console.ReadLine());

                resultado = num1 / num2;
                Console.WriteLine("El resultado de la Division es: " + resultado);

                Console.ReadLine();
            }
        }
    }
}
    

