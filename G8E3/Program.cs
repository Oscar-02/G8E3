using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G8E3
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = '\0';
            bool keyValid = false;
            while (keyValid == false)
            {
                Menu();
                Console.WriteLine("Presiona la tecla con la opcion que necesitas...");
                key = Console.ReadKey().KeyChar;
                if (key == '\0')
                {
                    Console.WriteLine("No has seleccionado ninguna opcion. Vuelvelo a intentar...");
                    keyValid = false;
                }
                if (key != '\0')
                {
                    keyValid = true;
                    switch (key)
                    {
                        case '1':
                            case1();
                            key = '\0';
                            keyValid = false;
                            break;
                        case '2':
                            case2();
                            key = '\0';
                            keyValid = false;
                            break;
                        case '3':
                            case3();
                            key = '\0';
                            keyValid = false;
                            break;
                        case '0':
                            Console.WriteLine("\nLamentamos mucho que te vayas...");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Has presionado una tecla invalida...");
                            Console.WriteLine("Vuelvelo a intentar...");
                            Console.WriteLine("Presiona una tecla para continuar...");
                            Console.ReadKey();
                            keyValid = false;
                            key = '\0';
                            break;
                    }
                }
            }
        }

        static void Menu()
        {
            Console.Clear();
            for (int i = 0; i < 120; i++)
            {
                Console.Write('*');
            }
            string text1 = "[1] Dividir  [2]Potencia al cubo  [3]IMC (Indice de Masa Corporal)  [0]SALIR DE LA APLICACION";
            Console.Write("**");
            Console.SetCursorPosition((120 - (text1.Length + 4)) / 2, 1);
            Console.Write(text1);
            Console.SetCursorPosition(118, 1);
            Console.Write("**");
            for (int i = 0; i < 120; i++)
            {
                Console.Write('*');
            }
        }
        static void case1()
        {
            double x = 0, y = 0;
            double res1;
            bool error = true;

            while (error == true)
            {
                Console.Clear();
                Menu();
                try
                {
                    Console.WriteLine("Ingrese un numero para darle valor al dividendo...");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un numero para darle valor al divisor...");
                    y = double.Parse(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                    Console.ReadKey();
                    error = true;
                }
            }
            if (y == 0)
            {
                Console.WriteLine("Lo sentimos, un numero dividido entre cero, o bien, cero entre cero, es un numero indeterminado");
            }
            else
            {
                res1 = x / y;
                Console.WriteLine("La division " + x + "/" + y + " es igual a " + res1);
            }
            Console.WriteLine("Presione una tecla para volver al inicio...");
            Console.ReadKey();
        }
        static void case2()
        {
            double x = 0;
            double res1;
            bool error = true;

            while (error == true)
            {
                Console.Clear();
                Menu();
                try
                {
                    Console.WriteLine("Ingrese un numero para darle valor a 'x' (base)...");
                    x = double.Parse(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                    Console.ReadKey();
                    error = true;
                }
            }
            res1 = Math.Pow(x, 3);
            Console.WriteLine(x + " elevado al cubo es " + Math.Round(res1, 5));
            Console.WriteLine("Presione una tecla para volver al inicio...");
            Console.ReadKey();
        }

        static void case3()
        {
            double wt = 0, ht = 0;
            double imc;
            bool error = true;

            while (error == true)
            {
                Console.Clear();
                Menu();
                try
                {
                    Console.WriteLine("Ingrese su peso en kg...");
                    wt = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su altura en m...");
                    ht = double.Parse(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                    Console.ReadKey();
                    error = true;
                }
            }
            imc = Math.Round(wt / ht, 2);
            Console.WriteLine("Su IMC (indice de masa corporal) es de " + imc + "kg/m");
            Console.WriteLine("Presione una tecla para volver al inicio...");
            Console.ReadKey();
        }
    }
}
