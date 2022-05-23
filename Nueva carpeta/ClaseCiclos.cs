using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class ClaseCiclos
    {
        static double num1, num2, num3;
        static double num4;
        public static void Multiplos3()
        {
            try
            {
                Console.WriteLine("Numeros Multiplos de 3 (del 1 al 100): ");

                for (num1 = 1; num1 < 100; num1++)
                {
                    if (num1 % 3 == 0)
                    {
                        Console.WriteLine(num1 + " Es multiplo de 3 ");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        public static void Impares()
        {
            try
            {
                Console.WriteLine("Numeros Impares (1-100): ");
                for (num1 = 1; num1 <= 100; num1++)
                {
                    if (num1 % 2 != 0)
                    {
                        Console.WriteLine(num1 + " Es Impar");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error de Digitación");
            }
        }
        public static void Pares()
        {
            try
            {
                Console.WriteLine("Numeros Pares (1-100): ");
                for (num1 = 1; num1 <= 100; num1++)
                {
                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine(num1 + " Es Par");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void Cuadrado()
        {
            try
            {
                Console.WriteLine("Numeros al cuadrado (1-30): ");
                for (num1 = 1; num1 <= 30; num1++)//i++ es para aumentar de uno en uno.
                {
                    Console.WriteLine("El cuadrado del numero: " + num1 + " Es: " + Math.Pow(num1, 2));
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void CuadradoSuma()
        {
            try
            {
                for (num1 = 1; num1 <= 100; num1++)
                {
                    Console.WriteLine("Numero " + num1);
                    num4 = num4 + num1 * num1;
                    Console.WriteLine("El cuadrado es: " + Math.Pow(num1, 2));
                }
                Console.WriteLine("\nEl valor de suma total de los cuadrados es: " + num4);
            }
            catch
            {
                Console.WriteLine("Error de Digitación");
            }
        }
        public static void ncomprendidos()
        {
            try
            {
                Console.WriteLine("Numeros comprendidos entre A y B");
                Console.WriteLine("Digite el primer numero (A): ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero (B): ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Los numeros comprendidos entre " + num1 + " y " + num2 + " son: ");
                for (num3 = num1 + 1; num3 < num2; num3++)
                {
                    Console.WriteLine(num3);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void Suma()
        {
            try
            {
                Console.WriteLine("Sumar todos los números que se digitan por teclado (para terminar digite 0)");
                do
                {
                    Console.WriteLine("Ingrese un numero a sumar: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num4 = num4 + num1;
                    Console.WriteLine("Resultado: " + num4);
                } while (num1 != 0);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
