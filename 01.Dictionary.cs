using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" | ").ToList();

            var wordsAndDefinitions = new Dictionary<string, List<string>>();

            for (int i = 0; i < input.Count; i++)
            {
                var tokens = input[i].Split(": ").ToList();

                string word = tokens[0];
                string definition = tokens[1];

                if (!wordsAndDefinitions.ContainsKey(word))
                {
                    wordsAndDefinitions.Add(word, new List<string>());

                } //if its not in the list


                wordsAndDefinitions[word].Add(definition);


            }

            var commands = Console.ReadLine().Split(" | ").ToList(); //bit | developer | programmer

            for (int i = 0; i < commands.Count; i++) //bit
            {
                if (wordsAndDefinitions.ContainsKey(commands[i]))
                {
                    Console.WriteLine(commands[i]);

                    foreach (var definition in wordsAndDefinitions[commands[i]].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine(" -" + definition);
                    }

                }
            }

            string finalCommand = Console.ReadLine();

            if (finalCommand == "List")
            {
                List<string> allKeys = new List<string>();

                foreach (var kvp in wordsAndDefinitions.OrderBy(x => x.Key))
                {
                    allKeys.Add(kvp.Key);
                }

                Console.WriteLine(string.Join(" ", allKeys));
            }
        }
    }
}