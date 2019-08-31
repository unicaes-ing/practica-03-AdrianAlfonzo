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
    class Ejercicio6Guia3
    {
        static void Main(string[] args)
        {
            //Base
            string nameProducto;
            decimal priceProducto;
            int how;
            decimal pricePERcantidad;
            decimal offer;
            //Consulta
            Console.WriteLine("La Tiendita del Señor Yisus y sus GRANDES descuentos");
            Console.WriteLine();
            Console.WriteLine("¿Qué producto compró?");
            nameProducto = Console.ReadLine();
            Console.Write("El precio es de: $");
            priceProducto = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("¿Cuántos {0} compró?", nameProducto);
            how = Convert.ToInt32(Console.ReadLine());
            //Proceso
            pricePERcantidad = priceProducto * how;
            //Proceso en SI
            if (pricePERcantidad > 0 && pricePERcantidad <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo existe un descuento :(");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nombre del producto: {0}", nameProducto);
                Console.WriteLine("Total a pagar: ${0}", pricePERcantidad);
            }
            ///
            if (pricePERcantidad > 100.01m && pricePERcantidad <= 200)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n¡12% de descuento!");
                Console.ForegroundColor = ConsoleColor.White;
                offer = pricePERcantidad * 0.12m;
                Console.WriteLine("Nombre del producto: {0}", nameProducto);
                Console.WriteLine("Total a pagar: ${0}", pricePERcantidad - offer);
            }
            ///
            if (pricePERcantidad > 200.01m && pricePERcantidad <= 500)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n¡15% de descuento!");
                Console.ForegroundColor = ConsoleColor.White;
                offer = pricePERcantidad * 0.15m;
                Console.WriteLine("Nombre del producto: {0}", nameProducto);
                Console.WriteLine("Total a pagar: ${0}", pricePERcantidad - offer);
            }
            ///
            if (pricePERcantidad > 500.01m)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n¡20% de descuento!");
                Console.ForegroundColor = ConsoleColor.White;
                offer = pricePERcantidad * 0.20m;
                Console.WriteLine("Nombre del producto: {0}", nameProducto);
                Console.WriteLine("Total a pagar: ${0}", pricePERcantidad - offer);
            }
            Console.ReadKey();
        }
    }
}
