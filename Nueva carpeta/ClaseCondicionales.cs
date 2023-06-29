using System;

namespace Consola1
{
    internal class ClaseCondicionales
    {
        static double num1, num2, num3;

        public static void PositivoNegativo()
        {
            try
            {
                Console.WriteLine("\n¿Número Positivo o Negativo?");
                Console.WriteLine("Ingrese un número: ");

                num1 = Convert.ToDouble(Console.ReadLine());
                if (num1 > 0)
                {
                    Console.WriteLine("El número " + num1 + " es Positivo.");
                }
                else if (num1 == 0)
                {
                    Console.WriteLine("El número " + num1 + " es Neutro.");
                }
                else
                {
                    Console.WriteLine("El número " + num1 + " es Negativo.");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void MayorMenor()
        {
            try
            {
                Console.WriteLine("\nNúmero Mayor y Menor");
                Console.WriteLine("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 > num2)
                {
                    ImprimirMayorMenor(num1, num2);
                }
                else if (num2 > num1)
                {
                    ImprimirMayorMenor(num2, num1);
                }
                else
                {
                    Console.WriteLine("Ambos números son iguales");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void MayorMenor3()
        {
            try
            {
                Console.WriteLine("\nNúmero mayor y menor de tres números");
                Console.WriteLine("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer número: ");
                num3 = Convert.ToDouble(Console.ReadLine());
                if ((num1 == num2) && (num2 == num3))
                {
                    Console.WriteLine("Los números son iguales.");
                }
                else if ((num1 > num2) && (num1 > num3))
                {
                    ImprimirMayor
