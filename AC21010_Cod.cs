using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC21010
{
    class Program
    {
        static void Main(string[] args)
        {
            GUIA4_10(); 
            GUIA4_9();     
        }

        static void ejemplo_m2()
        {// ejercicio m de la guia 3
            double a,b,resultado;
            a = (7 * (10 - 5) / 3.0);
            b = Math.Pow((4 + 9), 2);
            resultado = a * b;
            Console.WriteLine($"el resultado de la operacion d= (7*(10 - 5)/3)*Pow((4+9),2) es igual a: {resultado}");
            Console.ReadKey();
        }

        static void ejemplo_n2()
        {// ejercicio n de la guia 3
            double a, b, resultado;
            a = (7*10-5);
            b = Math.Pow((3*4 + 9), 2);
            resultado = a / b;
            Console.WriteLine($"el resultado de la operacion e= (7*10-5)/Pow((3*4+9),2) es igual a: {resultado}");
            Console.ReadKey();
        }

        static void ejemplo_o2()
        {// ejercicio o de la guia 3
            double resultado;
            resultado = Math.Sqrt(Math.Pow(4, 2));
            Console.WriteLine($"el resultado de la operacion z= squrt(Pow(4,2)) es igual a: {resultado}");
            Console.ReadKey();
        }
        
        static void ejemplo_m1()
        {
            //convertir grados a radianes
            double grados,pi,y;
            Console.WriteLine("Digite el numero de grados que desea convertir a radianes: ");
            grados = double.Parse(Console.ReadLine());
            pi = Math.PI;
            y = ((grados * pi) / 180);
            Console.WriteLine($"La conversion de {grados} grados a radianes es igual a: {y}");
            Console.ReadKey();
        }

        static void ejemplo_n1()
        {//formula matematica ejercicio n
            double x, y,z, grados,a,b;
            Console.WriteLine("Digite el numero de grados: ");
            grados = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de y: ");
            y = double.Parse(Console.ReadLine());
            b = (x + 2) * (y - 3);
            a = Math.Pow(b, 0.33333);
            z = Math.Sin(grados) * b;
            Console.WriteLine($"El resultado de la operacion es igual a: {a}");
            Console.ReadKey();

        }

        static void ejemplo_o1()
        {//formula matematica ejercicio o
            double a, b, c, x1,x2,d1,d2;
            Console.WriteLine("Digite el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de c: ");
            c = double.Parse(Console.ReadLine());
            d1 = (-b + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) ;
            d2 = (-b - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) ;
            x1 = d1 / (2 * a);
            x1 = Math.Round(x1, 2);
            x2 = d2 / (2 * a);
            x2 = Math.Round(x2, 2);
            Console.WriteLine($"las dos raices resultantes son {x1} y {x2} ");
            Console.ReadLine();
        }

        static void ejemplo4()
        {//area de un cubo
            int lado, area;
            Console.Write("Digite el lado del cubo: ");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            area = 6 * lado * lado;
            Console.WriteLine($"El area del cubo con lado ({lado}) es igual a: {area}");
            Console.ReadKey();
            
        }
        static void ejemplo8()
        {//Calcular y mostrar la distancia entre dos puntos de una recta
            double x1, x2, d;
            Console.WriteLine("Digite el valor del primer punto: ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digite el valor del primer punto: ");
            x2 = double.Parse(Console.ReadLine());
            d = Math.Abs(x2 - x1);
            Console.WriteLine("\n");
            Console.WriteLine($"La distancia entre los dos puntos es igual a: {d} ");
            Console.ReadKey();
        }

        static void ejemplo12()
        {//Diseñar una solución que realice la división aritmética
            string name1, name2;
            float dato1, dato2, resultado;
            Console.Write("Digite el producto: ");
            name1 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Digite al grupo o cosa que al que se va a repartir dicho producto: ");
            name2 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Digite la cantidad del producto: ");
            dato1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Digite la cantidad del grupo o cosa al que se va a repartir dicho producto: ");
            dato2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            resultado = dato1 / dato2;
            Console.WriteLine($"{resultado} {name1} por {name2}");
            Console.ReadKey();
        }

        static void GUIA4_8()
        {
            double a, h;
            Console.Write("Digite el lado del triangulo equilatero: ");
            a = double.Parse(Console.ReadLine());
            h = (Math.Sqrt(3) * a) / 2;
            h = Math.Round(h, 3);
            Console.Write($"La altura del triangulo equilatero con lado ({a}) es igual a: {h} ");
            Console.ReadKey();
        }

        static void GUIA4_9()
        {
            string producto;
            double PrecioC, PrecioV,PrecioI, ImpuestoA,ganancia;
            Console.Write("Digite el nombre del producto: ");
            producto = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Digite el costo de compra del producto: ");
            PrecioC = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            ImpuestoA = PrecioC * 0.10;
            PrecioI = PrecioC + ImpuestoA;
            ganancia = PrecioI * 0.25;
            PrecioV = PrecioI + ganancia;
            Console.WriteLine($"Nombre del producto: {producto}");
            Console.WriteLine($"Costo total del producto: ${PrecioI}");
            Console.WriteLine($"Ganancia que se percibe: ${ganancia}");
            Console.WriteLine($"Precio de venta: ${PrecioV}");
            Console.ReadKey();
        }

        static void GUIA4_10()
        {
            double grados,seno,coseno,tangente;
            Console.Write("Digite el dato del angulo: ");
            grados= double.Parse(Console.ReadLine());
            seno = Math.Sin(grados);
            coseno = Math.Cos(grados);
            tangente = Math.Tan(grados);
            seno = Math.Round(seno, 3);
            coseno = Math.Round(coseno, 3);
            tangente = Math.Round(tangente,3);
            Console.WriteLine("\n");
            Console.WriteLine($"El valor del seno para el angulo ({grados}) es igual a: {seno}");
            Console.WriteLine("\n");
            Console.WriteLine($"El valor del coseno para el angulo ({grados}) es igual a: {coseno}");
            Console.WriteLine("\n");
            Console.WriteLine($"El valor del coseno para el angulo ({grados}) es igual a: {tangente}");
            Console.ReadKey();
        }
    }
}
