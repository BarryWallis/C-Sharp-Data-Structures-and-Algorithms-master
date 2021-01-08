using System;
using System.Net.Http.Headers;
using System.Threading;

namespace SpinTheWheel
{
    class Program
    {
        static void Main()
        {
            CircularLinkedList<string> categories = CreateCategories();
            Random random = new();
            int totalTime = 0;
            int remainingTime = 0;
            foreach (string category in categories)
            {
                if (remainingTime <= 0)
                {
                    Console.WriteLine($"Press [ENTER] to start or any other key to exit.");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            totalTime = random.Next(1_000, 5_000);
                            remainingTime = totalTime;
                            break;
                        default:
                            return;
                    }
                }

                int categoryTime = (-450 * remainingTime / (totalTime - 50)) + 500 + (22_500 / (totalTime - 50));
                remainingTime -= categoryTime;
                Thread.Sleep(categoryTime);

                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : consoleColor;
                Console.WriteLine(category);
                Console.ForegroundColor = consoleColor;
            }
        }

        private static CircularLinkedList<string> CreateCategories()
        {
            CircularLinkedList<string> categories = new();
            _ = categories.AddLast("Sport");
            _ = categories.AddLast("Culture");
            _ = categories.AddLast("History");
            _ = categories.AddLast("Geography");
            _ = categories.AddLast("People");
            _ = categories.AddLast("Technology");
            _ = categories.AddLast("Nature");
            _ = categories.AddLast("Science");
            return categories;
        }
    }
}
