using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_dowhile_refuerzo
{
    class Program
    {
        static void Main(string[] args)
        {
            eje3();
        }

        static void eje1()
        {
            int i;
            double cuadrado;

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("El contador es " + i);
                cubo = Math.Pow(i, 2);
                Console.WriteLine("El cubo de ese valor es " + cuadrado);
                Console.WriteLine("-----------------------------");
            }

            Console.ReadKey();
        }

        static void eje2()
        {
            int tabla = 0, resultado = 0;
            Console.WriteLine("Que número de tabla de multiplicar " +
                "desea ver?");
            tabla = Int32.Parse(Console.ReadLine());

            for (int c = 10; c >= 1; c--)
            {
                resultado = tabla * c;
                Console.WriteLine($"{tabla} X {c} = {resultado}");
                //Console.WriteLine(tabla + " X " + c + " = " + resultado);
                //Console.WriteLine("{0} X {1} = {2}", tabla, c, resultado);
            }
            Console.ReadKey();
        }

        static void eje3()
        {
            //Digitar una lista de 7 números enteros desde el teclado. 
            // Informar el mayor, el menor 
            //y la sumatoria de los que se encuentran entre 100 y 500 inclusive.

            int numero = 0, mayor = 0, menor = 0, sumatoria = 0;
            for (int c = 1; c <= 7; c++)
            {
                Console.WriteLine("Digite un número ");
                numero = Int32.Parse(Console.ReadLine());
                if (c == 1)
                {
                    menor = numero;
                    mayor = numero;
                }

                if (numero > mayor) mayor = numero;
                if (numero < menor) menor = numero;
                if (numero >= 100 && numero <= 500) sumatoria += numero;
            }

            Console.WriteLine($"El número mayor es {mayor}");
            Console.WriteLine($"El número menor es {menor}");
            Console.WriteLine($"La suma de los numeros entre 100 y 500 es {sumatoria}");
            Console.ReadKey();

        }

        static void eje4()
        {
            // esto es ejemplo xd 2
        }
   
        static void Ejemplo5()
        {
            /*
                Pedir 10 números y 
                sumar los impares y 
                obtener el promedio de los pares 
                Mostrar los resultados.
             */
            int numero = 0, sumaImpares = 0;
            double promPares = 0;
            int contadorPares = 0, sumaPares = 0;
            int i = 0;
            do
            {
                Console.WriteLine($"Digite el # {i + 1}");
                numero = Int32.Parse(Console.ReadLine());
                if (numero % 2 != 0) sumaImpares += numero;
                if (numero % 2 == 0)
                {
                    contadorPares++;
                    sumaPares += numero;
                }

                i++;

            } while (i < 10);

            promPares = sumaImpares / contadorPares;
            Console.WriteLine($"Suma de Impares : {sumaImpares}");
            Console.WriteLine($"El prom. de los pares : {promPares}");
            Console.ReadKey();

        }

        static void Menu()
        {//EJERCICIO 1 PAG 232
            String opcion = "";
            do
            {
                Console.Clear();
                Console.WriteLine("-- MENU PRINCIPAL --");
                Console.WriteLine("a- Seno de x");
                Console.WriteLine("b- Conseno de x");
                Console.WriteLine("c- Tangente de x");
                Console.WriteLine("d- Raíz cuadara de x");
                Console.WriteLine("e- Potencia de Y elevado a X");
                Console.WriteLine("f- Verificar si un # es para o impar");
                Console.WriteLine("g- Salir del programa");
                Console.WriteLine("Seleccione una opcion ");
                opcion = Console.ReadLine();
                opcion = opcion.ToLower();
                switch (opcion)
                {
                    case "a":
                        Seno();
                        break;
                    case "b":
                        Coseno();
                        break;
                    case "c":
                        Coseno();
                        break;
                    case "d":
                        Seno();
                        break;
                    case "e":
                        Seno();
                        break;
                    case "f":
                        Seno();
                        break;
                }

            } while (opcion != "g");


        }

        static void Seno()
        {
            Console.Clear();
            double x = 0, seno = 0;
            Console.WriteLine("Digite el valor de X");
            x = Double.Parse(Console.ReadLine());
            seno = Math.Sin(x);
            Console.WriteLine($"El seno de {x} es {seno}");
            Console.ReadKey();

        }

        static void Coseno()
        {
            Console.Clear();
            double x = 0, coseno = 0;
            Console.WriteLine("Digite el valor de X");
            x = Double.Parse(Console.ReadLine());
            coseno = Math.Cos(x);
            Console.WriteLine($"El coseno de {x} es {coseno}");
            Console.ReadKey();

        }

        static void RaizCubica()
        {
            Console.Clear();
            double x = 0, raiz = 0;
            Console.WriteLine("Digite el valor de X");
            x = Double.Parse(Console.ReadLine());
            raiz = Math.Pow(x, (double)1 / 3);
            Console.WriteLine($"La raíz cubica de {x} es {raiz}");
            Console.ReadKey();
        }
    }
}
