using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace BookReader
{
    class Program
    {
        static void Main() => ShowPages(GetPages());

        private static void ShowPages(LinkedList<Page> pages)
        {
            LinkedListNode<Page>? currentPage = pages.First;
            int number = 1;
            while (currentPage is not null)
            {
                ShowCurrentPage(currentPage, number);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        if (currentPage.Next is not null)
                        {
                            currentPage = currentPage.Next;
                            number += 1;
                        }
                        break;
                    case ConsoleKey.P:
                        if (currentPage.Previous is not null)
                        {
                            currentPage = currentPage.Previous;
                            number -= 1;
                        }
                        break;
                    default:
                        currentPage = null;
                        break;
                }
            }
        }

        private static void ShowCurrentPage(LinkedListNode<Page> currentPage, int number)
        {
            Console.Clear();
            string numberString = $"- {number} -";
            int leadingSpaces = (90 - numberString.Length) / 2;
            Console.WriteLine($"{numberString.PadLeft(leadingSpaces + numberString.Length)}");
            Console.WriteLine();
            string content = currentPage.Value.Content;
            for (int i = 0; i < content.Length; i += 90)
            {
                string line = content[i..];
                line = line.Length > 90 ? line.Substring(0, 90) : line;
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine($"Quote from Windows Application Development Cookbook by Marcin K=Jamro, " +
                $"{Environment.NewLine}publshed by Packt Publishing in 2016.");

            Console.WriteLine();
            Console.Write(currentPage.Previous is not null ? "< PREVIOUS [P]" : GetSpaces(14));
            Console.Write(currentPage.Next is not
                null ? "[N] NEXT>".PadLeft(76) : string.Empty);
            Console.WriteLine();
        }

        private static string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }

            return result;
        }

        private static LinkedList<Page> GetPages()
        {
            Page pageFirst = new() { Content = "Nowadays, there are various (...)" };
            Page pageSecond = new() { Content = "Application development is (...)" };
            Page pageThird = new() { Content = "A lot of applications (...)" };
            Page pageFourth = new() { Content = "Do you know that modern (...)" };
            Page pageFifth = new() { Content = "While developing applications (...)" };
            Page pageSixth = new() { Content = "Could you imagine your (...)" };

            LinkedList<Page> pages = new();
            _ = pages.AddLast(pageSecond);
            LinkedListNode<Page> pageFourthNode = pages.AddLast(pageFourth);
            _ = pages.AddLast(pageSixth);
            _ = pages.AddFirst(pageFirst);
            _ = pages.AddBefore(pageFourthNode, pageThird);
            _ = pages.AddAfter(pageFourthNode, pageFifth);

            return pages;
        }
    }
}
