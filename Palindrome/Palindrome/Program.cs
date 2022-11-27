using System;

namespace Palindrome;
public class Palindrome
{
    static void Main(string[] args)
    {
        Console.Title = "Palindrome";

        do
        {
            string word;
            bool isPalindrome = true;

            Console.Write("Check if your word is palindrome: ");

            word = Console.ReadLine().Replace(" ", string.Empty).ToLower();

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYes! Your word is palindrome");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n\nMenu:\n- Click E/P to view sample palindromes in English/Polish\n- Click C to view the curiosity\n- Click Enter to skip");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo! Your word isn't palindrome");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n\nMenu:\n- Click E/P to view sample palindromes in English/Polish\n- Click C to view the curiosity\n- Click Enter to skip");
            }

            ConsoleKey choice = Console.ReadKey().Key;
            Console.Clear();
            switch (choice)
            {
                case ConsoleKey.E:
                    Console.WriteLine("Examples of English palindromes\n\nSingle Word: civic, kayak, madam, mom, racecar, level, stats\n\nMultiple Word: my gym, top spot, no lemon no melon, Madam I'm Adam, evade me Dave\n\nClick Enter to continue");
                    Console.ReadKey();
                    break;

                case ConsoleKey.P:
                    Console.WriteLine("Examples of Polish palindromes\n\nSingle Word: kajak, owocowo, oko, łapał, łamał, zakaz, zaraz\n\nMultiple Word: kobyła ma mały bok, ja tutaj, inni winni, jeż largo gra lżej\n\nClick Enter to continue");
                    Console.ReadKey();
                    break;

                case ConsoleKey.C:
                    Console.WriteLine("'Saippuakivikauppias' means soap seller. It is a Finish word and is the longest known palindrome in any language.\n\nClick Enter to continue");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }

            Console.Clear();

        } while (true || Console.ReadKey().Key == ConsoleKey.Enter);
    }
}