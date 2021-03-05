using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            static vid AppendTime()
            {
                using var sw = File.AppendText("startup.txt");
                var time = DataTime.Now.ToString("HH:mm:ss tt");
                sw.writeLine(time);
                Console.WriteLine($"I add to startup.txt new time, it's {time}, go check");
            }
        }
    }
}
