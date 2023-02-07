using System;

namespace SimpleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the Options:: ");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Machiato");
            Console.WriteLine("6 - Expresso");
            Console.WriteLine("Q - Quit the program");
            ConsoleKeyInfo userChoice = Console.ReadKey(true);
            Console.WriteLine(" You chose " + userChoice);

            var x = userChoice.Key;
            char y = userChoice.KeyChar;
            var z = userChoice.Modifiers;

            Console.WriteLine(" Key :: "+x+" Key Char :: "+y+" Modifiers  :: "+z);
        }
    }
}
