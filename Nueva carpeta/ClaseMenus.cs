using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class ClaseMenus
    {

        public static void MenuPrincipal()
        {
            Console.WriteLine("BIENVENIDO, Elija una opcion: \n" +
            "\n1) Operadores" +
            "\n2) Condicionales" +
            "\n3) Ciclos" +
            "\n4) Salir"
            );
        }

        public static void MenuOperadores()
        {
            Console.WriteLine(
            "\n Operadores: " +
            "\nElija una opción: \n " +
            "\n1) Hallar el area del triangulo" +
            "\n2) Sumar 2 enteros" +
            "\n3) Elevación al Cuadrado" +
            "\n4) Cambio Euro a Dolar" +
            "\n5) Perimetro y area de un cuadrado" +
            "\n6) Area y Volumen de un Cilindro" +
            "\n7) Radio, longitud y area de una circunferencia" +
            "\n8) Calcular el promedio de 3 numeros" +
            "\n9) Salir");
        }

        public static void MenuCondicionales()
        {
            Console.WriteLine(
            "\nCondicionales: " +
            "\nElija una opción: \n " +
            "\n1) Verificar si un numero es positivo o negativo" +
            "\n2) Ingresar dos numeros y verificar cual es el mayor y el menor" +
            "\n3) Ingresar tres numeros y calcular cual es el mayor y menor" +
            "\n4) Dados dos números A y B, sumarlos si A es menor que B o sino restarlos." +
            "\n5) Dados dos números A y B encontrar el cociente entre A y B." +
            "\n6) Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos" +
            "\n7) Calcular si un año es bisiesto" +
            "\n8) Salir");
        }

        public static void MenuCiclos()
        {
            Console.WriteLine(
            "\nCiclos: " +
            "\nElija una Opción: \n" +
            "\n1) Multiplos de 3" +
            "\n2) Numeros Impares" +
            "\n3) Numeros Pares" +
            "\n4) Numeros cuadrados del 1 al 30" +
            "\n5) Sumar los cuadrados de los cien primeros números naturales" +
            "\n6) Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente" +
            "\n7) Sumar todos los números que se digitan por teclado mientras no sea cero"+
            "\n8) Salir");
        }
        public static void Volver()
        {
            String RespuestaContinuar = null;
            do
            {
                Console.WriteLine("\n¿Quiere regresar al menu principal? si/no)");
                RespuestaContinuar = Console.ReadLine();
                if ((RespuestaContinuar == "SI") || (RespuestaContinuar == "si"))
                {
                    Console.Clear();
                    principal.Main();
                }

                else if ((RespuestaContinuar == "NO") || (RespuestaContinuar == "no"))
                {
                    Console.Clear();
                    Environment.Exit(1);
                }
            } while ((RespuestaContinuar != "SI") && (RespuestaContinuar != "NO"));
        }
    }
}
