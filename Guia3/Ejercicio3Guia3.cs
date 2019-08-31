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
    class Ejercicio3Guia3
    {
        static void Main(string[] args)
        {
            //Base
            int n1;
            int n2;
            int n3;
            //Consulta
            Console.Write("¿Cuál es el primer número? ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cuál es el segundo número? ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cuál es el tercer número? ");
            n3 = Convert.ToInt32(Console.ReadLine());
            //Mostrar
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
            }
            else
            {
                if (n2 < n1 && n2 < n3)
                {
                    Console.WriteLine(n2);
                }
                else
                {
                    if (n3 < n1 && n3 < n2)
                    {
                        Console.WriteLine(n3);
                    }
                }
            }
            ///
            if (n1 > n2 && n1 < n3)
            {
                Console.WriteLine(n1);
            }
            else
            {
                if (n2 > n1 && n2 < n3)
                {
                    Console.WriteLine(n2);
                }
                else
                {
                    if (n3 > n1 && n3 < n2)
                    {
                        Console.WriteLine(n3);
                    }
                }
            }
            ///
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1);
            }
            else
            {
                if (n2 > n1 && n2 > n3)
                {
                    Console.WriteLine(n2);
                }
                else
                {
                    if (n3 > n1 && n3 > n2)
                    {
                        Console.WriteLine(n3);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
