using System;
namespace StringFormatting
{
    class Program
    {
        static void Main(String[] args)
        {
            string apples = "Apples";
            int appleQuantity = 8;
            int applePrice = 100;
            string oranges = "Oranges";
            int orangeQuantity = 12;
            int orangePrice = 80;

            string column1Heading = "Fruit";
            string column2Heading = "Quantity";
            string column3Heading = "Price";

            Console.WriteLine($"{column1Heading, -12} {column2Heading, -8} {column3Heading, -6}");
            Console.WriteLine($"{apples, -12} {appleQuantity, -8} {applePrice,-6} cents");
            Console.WriteLine($"{oranges,-12} {orangeQuantity,-8} {orangePrice,-6} cents");
        }
    }
}

