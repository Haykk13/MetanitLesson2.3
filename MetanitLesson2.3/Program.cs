using System;

namespace MetanitLesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {j * i}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
