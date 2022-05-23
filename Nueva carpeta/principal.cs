using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class principal

    {
         public static void Main()
        {
                    ClaseMenus.MenuPrincipal();
                    String menu = null;
                    menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "1":
                            ClaseMenus.MenuOperadores();

                            String s1 = null;
                            s1 = Console.ReadLine();

                            switch (s1)
                            {

                                case "1":
                                    ClaseOperadores.Areadeuntriangulo();

                                    ClaseMenus.Volver();
                                    break;
                                case "2":
                                    ClaseOperadores.Suma();


                                    ClaseMenus.Volver();
                                    break;
                                case "3":
                                    ClaseOperadores.ElevarAlCuadrado();

                                    ClaseMenus.Volver();
                                    break;
                                case "4":
                                    ClaseOperadores.CambioDivisas();

                                    ClaseMenus.Volver();

                                    break;
                                case "5":
                                    ClaseOperadores.PerimetroAreaCuadrado();


                                    ClaseMenus.Volver();
                                    break;
                                case "6":
                                    ClaseOperadores.AreaVolumenCilindro();

                                    ClaseMenus.Volver();
                                    break;
                                case "7":
                                    ClaseOperadores.LongitudAreaCircunferencia();


                                    ClaseMenus.Volver();
                                    break;
                                case "8":
                                    ClaseOperadores.Promedio();

                                    ClaseMenus.Volver();
                                    break;
                                case "9":
                            Console.Clear();
                                    return;
                                default:
                                    Console.WriteLine("Error");
                                    ClaseMenus.Volver();
                                    break;

                            }
                            break;

                        case "2":
                            ClaseMenus.MenuCondicionales();
                            String s2 = null;
                            s2 = Console.ReadLine();

                            switch (s2)
                            {
                                case "1":
                                    ClaseCondicionales.PositivoNegativo();
                                    ClaseMenus.Volver();
                                    break;

                                case "2":
                                    ClaseCondicionales.MayorMenor();
                                    ClaseMenus.Volver();
                                    break;

                                case "3":
                                    ClaseCondicionales.MayorMenor3();
                                    ClaseMenus.Volver();
                                    break;

                                case "4":
                                    ClaseCondicionales.SumaResta();

                                    ClaseMenus.Volver();
                                    break;

                                case "5":
                                    ClaseCondicionales.Cociente();

                                    ClaseMenus.Volver();
                                    break;

                                case "6":
                                    ClaseCondicionales.SumaMultiplicacion();


                                    ClaseMenus.Volver();
                                    break;

                                case "7":
                                    ClaseCondicionales.AñoBisiesto();


                                    ClaseMenus.Volver();
                                    break;
                                case "8":
                                    Console.Clear();

                                    return;
                                default:
                                    Console.WriteLine("Error");
                                    ClaseMenus.Volver();
                                    break;
                            }

                            break;

                        case "3":
                            ClaseMenus.MenuCiclos();
                            String s3 = null;
                            s3 = Console.ReadLine();
                            switch (s3)
                            {
                                case "1":
                                    ClaseCiclos.Multiplos3();
                                    ClaseMenus.Volver();
                                    break;
                                case "2":
                                    ClaseCiclos.Impares();
                                    ClaseMenus.Volver();
                                    break;
                                case "3":
                                    ClaseCiclos.Pares();
                                    ClaseMenus.Volver();
                                    break;
                                case "4":
                                    ClaseCiclos.Cuadrado();
                                    ClaseMenus.Volver();
                                    break;
                                case "5":
                                    ClaseCiclos.CuadradoSuma();

                                    ClaseMenus.Volver();
                                    break;
                                case "6":
                                    ClaseCiclos.ncomprendidos();


                                    ClaseMenus.Volver();
                                    break;
                                case "7":
                                    ClaseCiclos.Suma();

                                    ClaseMenus.Volver();
                                    break;
                                case "8":
                                    Console.Clear();
                                    return;
                                default:
                                    Console.WriteLine("Error");
                                    ClaseMenus.Volver();
                                    break;

                            }
                            break;
                        case "4":
                            Console.Clear();
                            return;

                            default:
                                Console.WriteLine("Error");
                              break;
                    }
                
                
        }
    }
}



