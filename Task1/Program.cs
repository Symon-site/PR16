using System;

namespace ConsoleApp37
{
        internal class Program
        {
            static void Main(string[] args)
            {
                var p1 = new Point(1, 2);
                var p2 = new Point(3, 4);
                Console.WriteLine($"Сумма: {p1 + p2}");
                Console.WriteLine($"Вычитание: {p2 - p1}");
            }
        }
    }
}
