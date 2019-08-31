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
    class Ejercicio4Guia3
    {
        static void Main(string[] args)
        {
            //Base
            int min;
            int sec;
            decimal timeLlamada;
            decimal secAgregados;
            decimal moneyLlamada;
            int zoneElegir;
            //Consulta
            Console.WriteLine("--->Aplicación para cobros por llamada CLARO<---");
            Console.WriteLine("");
            Console.Write("¿Cuántos minutos llevó la llamada? ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Cuántos segundos llevó la llamada? ");
            sec = Convert.ToInt32(Console.ReadLine());
            //Convertir
            secAgregados = sec * .1m;
            timeLlamada = min + secAgregados;
            //Menu
            Console.WriteLine("\n¿En dónde se realizó la llamada?");
            Console.WriteLine("[1] Zona Occidental");
            Console.WriteLine("[2] Zona central");
            Console.WriteLine("[3] Zona Oriental");
            zoneElegir = Convert.ToInt32(Console.ReadLine());
            //Precio por llamada
            if (zoneElegir == 1)
            {
                moneyLlamada = timeLlamada * 0.32m;
                Console.WriteLine("\nSe le ha descontado: ${0} de su saldo original", Math.Truncate(moneyLlamada*100)/100);
                Console.ReadLine();
            }

            if (zoneElegir == 2)
            {
                moneyLlamada = timeLlamada * 0.25m;
                Console.WriteLine("\nSe le ha descontado: ${0} de su saldo original", Math.Truncate(moneyLlamada*100)/100);
                Console.ReadLine();
            }

            if (zoneElegir == 3)
            {
                moneyLlamada = timeLlamada * 0.36m;
                Console.WriteLine("\nSe le he descontado: ${0} de su saldo original", Math.Truncate(moneyLlamada*100)/100);
                Console.ReadLine();
            }
        }
    }
}
