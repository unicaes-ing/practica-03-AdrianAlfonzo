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
    class Ejercicio2Guia3
    {
        static void Main(string[] args)
        {
            //Proceso
            Random uy = new Random(DateTime.Now.Millisecond);
            int Aleat = uy.Next(100);
            Console.Write("Número aleatorio generado = ");
            Console.Write(Aleat);

            //Mostrar
            if (Aleat % 2 == 0)
            {
                Console.Write(" :   Es par");
                Console.ReadKey();
            }
            else
            {
                Console.Write(" :   Es impar");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
