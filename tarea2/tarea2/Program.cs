using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = string.Empty;
            string cadena2 = string.Empty;
            string resultado = string.Empty;

            cadena1 = "Amin";
            Console.WriteLine("Ingrese una cadena");
            cadena2 = Console.ReadLine();


            resultado = (cadena1 == cadena2) ? "las cadenas coinciden":"Las cadenas no coinciden" ;
            Console.WriteLine(resultado);
            Console.ReadLine();

        //    if (cadena1 == cadena2)
        //    {
        //        Console.WriteLine("las cadenas coninciden");
        //    }
        //    else
        //    {
        //        Console.WriteLine("las cadenas no coinciden");

        //    }
        }
}
}
