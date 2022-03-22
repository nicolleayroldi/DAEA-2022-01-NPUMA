using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp001
{
    class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static void primos()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine(i);
                }
                cont = 0;
            }
        }
        static int Formula1(int F)
        {
            return (5 * (F - 32) / 9);
        }
        static int Formula2(int C)
        {
            return ((9*C)/5)+32;
        }
        //holi

        static void Main(string[] args)
            {
                /*Console.WriteLine("Programa LAB 001");
                Raiz();
                Console.ReadKey();*/

                Console.Title = "Procedimientos y funciones";
                string opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("[1] Suma de dos números");
                    Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                    Console.WriteLine("[3] Resta de dos números");
                    Console.WriteLine("[4] Division de dos números");
                    Console.WriteLine("[5] Multiplicacion de dos numeros");
                    Console.WriteLine("[6]Primos");
                    Console.WriteLine("[7]Desarrolo de la Formula 1");
                    Console.WriteLine("[8]Desarrollo de la Formula 2");
                    Console.WriteLine("[0] Salir");
                    Console.WriteLine("Ingrese una opción y presione ENTER");
                    opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division {0} y {1} es {2}", e, f, Division(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion {0} y {1} es {2}", g, h, Multiplicacion(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("En proceso");
                        primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingresa el dato:");
                        int X = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resutlado es {1}°C", X, Formula1(X));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el dato:");
                        int T = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado es  {1}°F", T, Formula2(T));
                        Console.ReadKey();
                        break;


                }
                    


                
                } while (!opcion.Equals("0"));

            }
        }
    }

