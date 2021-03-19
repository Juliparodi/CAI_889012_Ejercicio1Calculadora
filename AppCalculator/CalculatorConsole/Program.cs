using CalculatorLibrary;
using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            double number1;
            double number2;
            string operador;
            double resultado = 0;
            bool isOk = false;

            Console.WriteLine("Hi! Welcome to Juli's app calculator. Please press enter to continue");
            Console.ReadKey();

            Console.WriteLine("now, you will be asked to enter two numbers and then the operand u wanna use");
            Console.WriteLine("Please enter a number: ");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number: ");
            number2 = double.Parse(Console.ReadLine());

            while (!isOk){
                Console.WriteLine("Please enter operation u wanna use, only +, -, *, / are allowed: ");
                operador = Console.ReadLine();
                if (Validations.operatorIsOk(operador)) {
                    resultado = Math.Round(CalculatorImplementation.realizarCalculo(number1, number2, operador), 2);
                    isOk = true;
                }
                else{
                    Console.WriteLine("Please enter a valid operator");
                    isOk = false;
                }
            }
            

            Console.WriteLine("Operation's result rounded to 2 decimales is: {0}", resultado);
            Console.Write("Thanks for using Juli's calculator, hope u have a nice experience. See u");
            Console.ReadKey();
        }
    }
}
