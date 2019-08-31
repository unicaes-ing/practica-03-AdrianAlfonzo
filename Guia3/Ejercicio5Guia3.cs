using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//------------------UNICAES------------------
//---Facultad de Ingenería y Arquitectura---
//--INGENIERÍA EN DESARROLLO DE SOFTWARE--
//-Última fecha de modificación: 28.08.19
//-------Luis Adrián Alfonzo Morán-------

namespace Guia3
{
    class Ejercicio5Guia3
    {
        static void Main(string[] args)
        {
            //Base
            int number;
            //Consulta
            Console.WriteLine("¿Cuál es el número?");
            number = Convert.ToInt32(Console.ReadLine());
            //Proceso en SI
            if (number == 1)
            {
                Console.WriteLine("Uno");
            }
            if (number == 2)
            {
                Console.WriteLine("Dos");
            }
            if (number == 3)
            {
                Console.WriteLine("Tres");
            }
            if (number == 4)
            {
                Console.WriteLine("Cuatro");
            }
            if (number == 5)
            {
                Console.WriteLine("Cinco");
            }
            if (number == 6)
            {
                Console.WriteLine("Seis");
            }
            if (number == 7)
            {
                Console.WriteLine("Siete");
            }
            if (number == 8)
            {
                Console.WriteLine("Ocho");
            }
            if (number == 9)
            {
                Console.WriteLine("Nueve");
            }
            if (number == 10)
            {
                Console.WriteLine("Diez");
            }
            if (number >= 11 || number < 1)
            {
                Console.WriteLine("Error: Debe ser un valor entre 1 a 8");
            }
            Console.ReadLine();
        }
    }
}
