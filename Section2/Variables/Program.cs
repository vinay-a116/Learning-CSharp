using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 2;
            int secondNumber = 5;

            var subtraction = 7;

            int answer;
            string prompt = " . Press ENTER when ready.";
            Console.WriteLine("Think of a number between 1 and 10. "+prompt);
            Console.ReadKey();
            Console.WriteLine("Multiply your number by " + firstNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now multiply the resut by :: " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you originally thought of " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now subtract "+subtraction+prompt);
            Console.ReadKey();
            answer = firstNumber * secondNumber - subtraction;
            Console.WriteLine("The answwer is :: "+answer);

        }
    }
}
