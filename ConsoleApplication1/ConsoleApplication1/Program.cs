using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // El valor predeterminado es "no es un número" que usamos si una operación, como una división, puede resultar en un error.

            // Use una declaración de cambio para hacer los cálculos.
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Pídale al usuario que ingrese un divisor distinto de cero.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Devolver texto para una entrada de opción incorrecta..
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Mostrar título como la aplicación de calculadora de la consola de C #.

            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t================================");
            Console.WriteLine("\t\t\t\t\t||     CALCULADORA SANDIYU    ||");
            Console.WriteLine("\t\t\t\t\t================================");

            while (!endApp)
            {
                // Declaracion de las variables y  en vacío.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Pídale al usuario que escriba el primer número.
                Console.WriteLine("");
                Console.WriteLine("===============================================");
                Console.Write("1. Escriba un número y luego presione Enter:  =\n");
                Console.WriteLine("===============================================");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta no es una entrada válida. Ingrese un valor entero: ");
                    numInput1 = Console.ReadLine();
                }

                // Pídale a la usuario que escriba el segundo número.
                Console.WriteLine("\n");
                Console.WriteLine("==============================================="); ;
                Console.Write("2. Escriba otro número y luego presione Enter:  =  \n");
                Console.WriteLine("==============================================="); ;
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Esta no es una entrada válida. Ingrese un valor entero: ");
                    numInput2 = Console.ReadLine();
                }

                // OPERADORES:
                Console.WriteLine("\n");
                Console.WriteLine("===========================");
                Console.WriteLine("|   ELIJA UNA OPERACION:  |");
                Console.WriteLine("===========================");

                // Console.WriteLine("\t--------------------");
                Console.WriteLine("\t (+)   -SUMA       ");
                // Console.WriteLine("\t--------------------");
                // Console.WriteLine("\t--------------------");
                Console.WriteLine("\t (-)   -RESTA        ");
                // Console.WriteLine("\t--------------------");
                // Console.WriteLine("\t--------------------");
                Console.WriteLine("\t (*)   -MULTIPLICACION  ");
                // Console.WriteLine("\t--------------------");
                //Console.WriteLine("\t--------------------");
                Console.WriteLine("\t (/)   -DIVICION       ");
                //Console.WriteLine("\t--------------------");


                Console.Write("TU OPERACION: ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operación resultará en un error matemático.\n");
                    }

                    else Console.WriteLine("Tu resultado es: {0:0.##}\n", result);

                }
                catch (Exception e)
                {
                    Console.WriteLine("¡Oh, no! Se produjo una excepción al intentar hacer los cálculos.\n - Detalles: " + e.Message);
                }

                Console.WriteLine("");

                // Espere a que el usuario responda antes de cerrar.

                Console.Write("\t\t PRESIONE ['n'] Y ENTER PARA ['salir'], O PRESIONE CUALQUIER OTRA TECLA Y ENTER PARA CONTINUAR:");
                if (Console.ReadLine() == "n") endApp = true;
                Console.Clear();
                Console.WriteLine("\n"); // Espacio entre líneas amigable.


            }
            return;
        }
    }
}

