using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name :: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Name :: " + name);
            Console.WriteLine(" How old are you : ");
            int? age = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " is " + age + " Years old ");
            Console.WriteLine($"{name} is {age} years old ");
        }
    }
}

