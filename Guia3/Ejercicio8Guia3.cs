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
    class Ejercicio8Guia3
    {
        static void Main(string[] args)
        {
            //Base
            decimal priceProducto;
            string nameProducto;
            decimal offerColor;
            Random numRand = new Random();
            //Consulta
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----->¡Bienvenido a la Tiendita del Señor Yisus!<-----");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¿Qué producto llevará? ");
            nameProducto = Console.ReadLine();
            Console.Write("¿Cuál es el precio del {0}? $", nameProducto);
            priceProducto = Convert.ToDecimal(Console.ReadLine());
            //Juego de color
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Pase a caja por favor :D---");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nNombre del producto: {0}", nameProducto);
            Console.WriteLine("Precio del producto: ${0}", priceProducto);
            Console.WriteLine();
            Console.WriteLine("\nHola, oiga,  hoy que ando de buenas ¿quiere jugar en una rifa? Por su compra está participando");
            Console.WriteLine("Va a funcionar así, dependiendo del color de la bolita que obtenga se le aplicará un descuento en su compra");
            Console.WriteLine("Presione [SPACE] cuando este listo");
            Console.ReadKey();
            //Tiempo de espera
            Console.Write("\n¡Tome la bola!");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            System.Threading.Thread.Sleep(100);
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.White;
            //Juego Finalizado
            Console.Write("\nColor Resultante: ");
            int colores = numRand.Next(1, 5);
            //Proceso final en SWITCH
            switch (colores)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Blanco");
                    Console.WriteLine("\nUy que mal, no recibe descuento por su compra, suerte para la proxima :(");
                    Console.WriteLine();
                    Console.WriteLine("Precio Final: ${0}", priceProducto);
                    break;
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Verde");
                    Console.WriteLine("\nRecibe un 15% de descuento en su compra");
                    offerColor = priceProducto * 0.15m;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Precio Final: ${0}", (priceProducto - offerColor));
                    break;
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Amarillo");
                    Console.WriteLine("\nRecibe un 18% de descuento en su compra");
                    offerColor = priceProducto * 0.18m;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Precio Final: ${0}", (priceProducto - offerColor));
                    break;
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Azul");
                    Console.WriteLine("\nRecibe un 20% de descuento en su compra");
                    offerColor = priceProducto * 0.20m;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Precio Final: ${0}", (priceProducto - offerColor));
                    break;
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Threading.Thread.Sleep(100);
                    Console.Write("Roja");
                    Console.WriteLine("\nRecibe un 25% de descuento en su compra de {0}", nameProducto);
                    offerColor = priceProducto * 0.25m;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Precio Final: ${0}", (priceProducto - offerColor));
                    break;
            }
            Console.ReadLine();
        }
    }
}
