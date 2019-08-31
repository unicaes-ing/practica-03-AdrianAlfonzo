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
    class Ejercicio7Guia3
    {
        static void Main(string[] args)
        {
            //Base
            decimal uniInicio;
            decimal uniFinal;
            int menu1;
            int menu2;
            decimal uniConvertida;
            //Menu
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a CONVERSORES DE UNIDADES: Masa");
                Console.WriteLine("\n--Seleccione la Unidad con la que trabajaremos--");
                Console.WriteLine("[1] Onz");
                Console.WriteLine("[2] Lb");
                Console.WriteLine("[3] Gr");
                Console.WriteLine("[4] Ton");
                Console.Write("\nElección: ");
                menu1 = Convert.ToInt32(Console.ReadLine());
                //Conversion
                if (menu1 == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha seleccionado la Unidad de inicio: [1] Onza");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Onzas--");
                    do
                    {
                        //Menu2
                        Console.WriteLine("[1] Lb");
                        Console.WriteLine("[2] Gr");
                        Console.WriteLine("[3] Ton");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());

                        //onz
                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Onzas a libras---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Onzas: ");
                            uniInicio = Convert.ToDecimal(Console.ReadLine());
                            uniFinal = uniInicio / 16;
                            uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                            Console.WriteLine("Sus {0} Onzas equivalen a {1} Libras", uniInicio, uniConvertida);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Onzas a Gramos---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Onzas: ");
                                uniInicio = Convert.ToDecimal(Console.ReadLine());
                                uniFinal = uniInicio * 28.35m;
                                uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Onzas equivalen a {1} Gramos", uniInicio, uniConvertida);
                                Console.ReadKey();
                            }

                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Onzas a Toneladas---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Onzas: ");
                                    uniInicio = Convert.ToDecimal(Console.ReadLine());
                                    uniFinal = uniInicio / 35273.962m;
                                    uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Onzas equivalen a {1} Toneladas", uniInicio, uniConvertida);
                                    Console.ReadKey();
                                }

                            }
                        }
                    } while (menu2 >= 4);
                }
                //Conversion
                if (menu1 == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [2] Libras");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Libras--");
                    do
                    {
                        //Menu2
                        Console.WriteLine("[1] Onzas");
                        Console.WriteLine("[2] Gramo");
                        Console.WriteLine("[3] Tonelada");
                        Console.WriteLine("[4] Volver al menu principal");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());
                        //lb
                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Libras a Onzas---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Libras: ");
                            uniInicio = Convert.ToDecimal(Console.ReadLine());
                            uniFinal = uniInicio * 16;
                            uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                            Console.WriteLine("Sus {0} Libras equivalen a {1} Onzas", uniInicio, uniConvertida);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Libras a Gramos---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Libras: ");
                                uniInicio = Convert.ToDecimal(Console.ReadLine());
                                uniFinal = uniInicio * 453.592m;
                                uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Libras equivalen a {1} Gramos", uniInicio, uniConvertida);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Libras a Toneladas---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Libras: ");
                                    uniInicio = Convert.ToDecimal(Console.ReadLine());
                                    uniFinal = uniInicio / 2204.62m;
                                    uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Libras equivalen a {1} Toneladas", uniInicio, uniConvertida);
                                    Console.ReadKey();
                                }

                            }
                        }
                    } while (menu2 >= 4);
                }
                //Conversion
                if (menu1 == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [3] Gramos");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Gramos--");
                    do
                    {
                        //Menu2
                        Console.WriteLine("[1] Onzas");
                        Console.WriteLine("[2] Libras");
                        Console.WriteLine("[3] Tonelada");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());
                        //gr
                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Gramos a Onzas---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Gramos: ");
                            uniInicio = Convert.ToDecimal(Console.ReadLine());
                            uniFinal = uniInicio / 28.35m;
                            uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                            Console.WriteLine("Sus {0} gramos equivalen a {1} Onzas", uniInicio, uniConvertida);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Gramos a Libras---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Gramos: ");
                                uniInicio = Convert.ToDecimal(Console.ReadLine());
                                uniFinal = uniInicio / 453.592m;
                                uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Gramos equivalen a {1} Libras", uniInicio, uniConvertida);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Gramos a Toneladas---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Gramoss: ");
                                    uniInicio = Convert.ToDecimal(Console.ReadLine());
                                    uniFinal = uniInicio / 1000000m;
                                    uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Gramos equivalen a {1} Toneladas", uniInicio, uniConvertida);
                                    Console.ReadKey();
                                }
                            }
                        }
                    } while (menu2 >= 4);
                }
                //Conversion
                if (menu1 == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ha escogido la Unidad de inicio: [4] Toneladas");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n--Elija a que unidad quiere convertir Toneladas--");
                    do
                    {
                        //Menu2
                        Console.WriteLine("[1] Onzas");
                        Console.WriteLine("[2] Libras");
                        Console.WriteLine("[3] Gramos");
                        Console.Write("\nSelección: ");
                        menu2 = Convert.ToInt32(Console.ReadLine());
                        //ton
                        if (menu2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---Toneladas a Onzas---");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Escriba el numero de Toneldas: ");
                            uniInicio = Convert.ToDecimal(Console.ReadLine());
                            uniFinal = uniInicio * 35273.962m;
                            uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                            Console.WriteLine("Sus {0} Toneladas equivalen a {1} Onzas", uniInicio, uniConvertida);
                            Console.ReadKey();
                        }
                        else
                        {
                            if (menu2 == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("---Toneladas a Libras---");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Escriba el numero de Toneladas: ");
                                uniInicio = Convert.ToDecimal(Console.ReadLine());
                                uniFinal = uniInicio * 2204.623m;
                                uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                Console.WriteLine("Sus {0} Toneladas equivalen a {1} Libras", uniInicio, uniConvertida);
                                Console.ReadKey();
                            }
                            else
                            {
                                if (menu2 == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("---Toneladas a Gramos---");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Escriba el numero de Toneladas: ");
                                    uniInicio = Convert.ToDecimal(Console.ReadLine());
                                    uniFinal = uniInicio * 1000000m;
                                    uniConvertida = Math.Truncate(uniFinal * 100) / 100;
                                    Console.WriteLine("Sus {0} Toneladas equivalen a {1} Gramos", uniInicio, uniConvertida);
                                    Console.ReadKey();
                                }
                            }
                        }
                    } while (menu2 >= 4);
                }
            } while (menu1 >= 5);
        }
    }
}
