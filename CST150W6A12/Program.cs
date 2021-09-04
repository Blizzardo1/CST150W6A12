using System;
using System.IO;

namespace CST150W6A12
{
    internal static class Program
    {

        private static string OpenFile(string filename) => File.ReadAllText(filename);

        private static string GetStatement()
        {
            Console.WriteLine("Enter a sentence or two. Press enter to begin checking for words that end with a 't' or an 'e'.\n");
            Console.Write("Statement(s)> ");
            return Console.ReadLine();
        }

        private static void Main(string[] args)
        {
            string contents;
            if (args.Length < 1)
            {
                contents = GetStatement();
            }
            else
            {
                if (!File.Exists(args[0]))
                {
                    Console.WriteLine($"The file \"{args[0]}\" does not exist!");
                    return;
                }
                contents = OpenFile(args[0]);
            }

            int count = 0;
            foreach (string s in contents.Split(' '))
            {
                if (!s.TrimSpecialCharacters().EndsWith('t') && !s.TrimSpecialCharacters().EndsWith('e'))
                    continue;

                count++;
            }

            Console.WriteLine($"There are {count} words that end with a 't' or an 'e'");
        }
    }
}
