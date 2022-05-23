using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class ClaseCondicionales
    {
        static double num1, num2, num3;

        public static void PositivoNegativo()
        {
            try { 
            Console.WriteLine("\n¿Numero Positivo o Negativo?");
            Console.WriteLine("Ingrese un numero: ");
           
                num1 = Convert.ToDouble(Console.ReadLine());
                if (num1 > 0)
                {
                    Console.WriteLine("El numero: " + num1 + " es Positivo.");
                }
                else if (num1 == 0)
                {
                    Console.WriteLine("El numero: " + num1 + " es Neutro.");
                }
                else
                    Console.WriteLine("El numero: " + num1 + " es Negativo.");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }


        public static void MayorMenor()
        {
            try { 
            Console.WriteLine("\nNumero Mayor y Menor");
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El numero " + num1 + " es el numero mayor y el numero " + num2 + " es el menor.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El numero " + num2 + " es el numero mayor y el numero " + num1 + " es el menor.");
            }
            else
            {
                Console.WriteLine("Ambos numeros son iguales");
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
                Console.WriteLine("\nNumero mayor y menor de tres numeros");
                Console.WriteLine("Ingrese el primer numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero: ");
                num3 = Convert.ToDouble(Console.ReadLine());
                if ((num1 == num2) && (num2 == num3))
                {
                    Console.WriteLine("Los numeros son iguales.");
                }
                else if ((num1 > num2) && (num1 > num3))
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("El numero " + num1 + " es el numero mayor.");
                        Console.WriteLine("El numero " + num3 + " es el numero menor.");
                    }

                    else if (num3 > num2)
                    {
                        Console.WriteLine("El numero " + num1 + " es el numero mayor.");
                        Console.WriteLine("El numero " + num2 + " es el numero menor.");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + num1 + " es el numero mayor.");
                        Console.WriteLine("Los otros numeros son iguales.");
                    }
                }
                else if ((num2 > num1) && (num2 > num3))
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("El numero " + num2 + " es el numero mayor.");
                        Console.WriteLine("El numero " + num3 + " es el numero menor.");
                    }

                    else if (num3 > num1)
                    {
                        Console.WriteLine("El numero " + num2 + " es el numero mayor.");
                        Console.WriteLine("El numero " + num1 + " es el numero menor.");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + num2 + " es el numero mayor.");
                        Console.WriteLine("Los otros numeros son iguales.");
                    }
                }
                else if ((num3 > num1) && (num3 > num2))
                {
                    if (num1 > num2)
                    {
                        Console.WriteLine("El numero " + num3 + " es el numero mayor.");
                        Console.WriteLine("El numero " + num2 + " es el numero menor.");
                    }

                    else if (num2 > num1)
                    {
                        Console.WriteLine("El numero " + num3 + " es el numero mayor.");
                        Console.WriteLine("El numero " + num1 + " es el numero menor.");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + num3 + " es el numero mayor.");
                        Console.WriteLine("Los otros numeros son iguales.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }


        public static void SumaResta()
        {
            try
            {
                Console.WriteLine("\nDados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
                Console.WriteLine("Ingrese el primer numero (A): ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero (B): ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 < num2)
                {
                    Console.WriteLine("A es menor que B. El resultado de la suma es: " + (num1 + num2));
                }
                else if (num1 > num2)
                {
                    Console.WriteLine("A es mayor que B. El resultado de la resta es: " + (num1 - num2));
                }
                else
                {
                    Console.WriteLine("Error. Los numeros son iguales.");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void Cociente()
        {
            try
            {
                Console.WriteLine("\nEncontrar el cociente entre A y B");
                Console.WriteLine("Ingrese el numero A: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el numero B: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("La división no es posible");
                }
                else
                {
                    Console.WriteLine("El cociente de la division entre A y B es: " + (num1 / num2));
                }
            }catch
            {
                Console.WriteLine("Error");
            }
        }


        public static void SumaMultiplicacion()
        {
            try
            {
                Console.WriteLine("Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
                Console.WriteLine("Ingrese el primer numero (A): ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero (B): ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if ((num1 < 0) || (num2 < 0))
                {
                    Console.WriteLine("El resultado de la suma de A y B es: " + (num1 + num2));
                }
                else
                {
                    Console.WriteLine("El resultado de la multiplicación de A y B es: " + (num1 * num2));
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }


        public static void AñoBisiesto()
        {
            try
            {
                {
                    static bool A()
                    {
                        if (num2 % 4 == 0 && (num2 % 100 != 0 || num2 % 400 == 0))
                            return true;
                        return false;
                    }
                    Console.WriteLine("\nDeterminar si un año es bisiesto o no");
                    Console.WriteLine("Digite el año ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (A() == true)
                    {
                        Console.WriteLine("El año " + num2 + " es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año " + num2 + " no es bisiesto");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        }
}
