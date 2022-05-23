using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    public class ClaseOperadores
    {

        static double num1, num2, num3;
        public static void Areadeuntriangulo()
        {
            Console.WriteLine("\nArea de un Triangulo");
            Console.WriteLine("Escriba la Base del triangulo: ");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Escriba la Altura del triangulo: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Error");

                Console.WriteLine("El area del triangulo es: " + ((num1 * num2) / 2));
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }


        public static void Suma()
        {
            try
            {
                Console.WriteLine("\nSuma");
                Console.WriteLine("Escriba el primer numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escriba el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

        }
        public static void ElevarAlCuadrado()
        {
            try
            {
                Console.WriteLine("\nNumero Elevado al Cuadrado");
                Console.WriteLine("Escriba el numero a elevar: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado es: " + Math.Pow(num1, 2));
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

        }

        public static void CambioDivisas()
        {
            try
            {
                Console.WriteLine("\nCambio de Euros a Dolares");
                Console.WriteLine("Escriba la cantidad de Euros a cambiar: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado de la conversión es: " + (num1 * 1.06) + "USD");
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

        }

        public static void PerimetroAreaCuadrado()
        {
            try
            {
                Console.WriteLine("\nHallar el perimetro y area de un cuadrado");
                Console.WriteLine("Escriba la altura de un lado del cuadrado");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El perimetro es: " + (num1 * 4));
                Console.WriteLine("Y su area es: " + (num1 * num1));
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
            
        }

        public static void AreaVolumenCilindro()
        {
            try
            {
                Console.WriteLine("\nHallar el Area y volumen de un cilindro");
                Console.WriteLine("Escriba la altura del cilindro");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escriba el radio del cilindro");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El volumen del cilindro es: " + (3.141592 * Math.Pow(num2, 2) * num1));
                Console.WriteLine("Y su area es: " + ((2 * 3.141592 * num2 * num1) + (2 * 3.141592 * Math.Pow(num2, 2))));
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

        }

        public static void LongitudAreaCircunferencia()
        {
            try
            {
                Console.WriteLine("\nHallar longitud y area de una circunferencia");
                Console.WriteLine("Escriba el area de la circunferencia");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("La longitud es: " + (2 * 3.141592) * num1);
                Console.WriteLine("Y su radio es: " + (3.141592 * Math.Pow(num1, 2)));
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

        }

        public static void Promedio()
        {
            try
            {
                Console.WriteLine("\nPromedio de 3 números ingresados por teclado.");
                Console.WriteLine("Ingresar el primer valor: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el segundo valor: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el tercer valor: ");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("El promedio de los 3 numeros es: " + (num1 + num2 + num3) / 3);
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }

        }
    }
}
