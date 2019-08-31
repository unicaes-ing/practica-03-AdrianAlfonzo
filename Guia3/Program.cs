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
    class Ejercicio1Guia3
    {
        static void Main(string[] args)
        {
            //Base
            int hours;
            float minutes;
            float sec;

            //Consulta
            Console.WriteLine("Conversión HORAS, MINUTOS, SEGUNDOS");
            Console.WriteLine();
            Console.Write("¿Cuál es la cantidad de horas que desea convertir? ");
            hours = Convert.ToInt32(Console.ReadLine());

            //Muestra con estructura SI
            if (hours < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: No existe la posibilidad de convertir horas negativas");
            }
            else
            {
                minutes = hours * 60;
                Console.WriteLine("Equivale a {0} minutos", minutes);
                sec = minutes * 60;
                Console.WriteLine("Equivañe a {0} segundos", sec);
                Console.ReadKey();
            }
        }
    }
}