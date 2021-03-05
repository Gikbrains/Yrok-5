using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            void ConsoleApp14()
            {
                Cosole.WriteLine("HEllol");
            }

            static void PrintHouseNumber(Building house)
            {
                Console.WriteLine(house?.Address?.Split(' ')[1]);
            }

            
        }
    }
}
