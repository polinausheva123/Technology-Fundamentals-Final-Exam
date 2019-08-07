using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var encrypted = Console.ReadLine();
        var substrings = Console.ReadLine().Split(' ').ToArray();


        Regex rx = new Regex("(^[d-z#{}|]+)");

        string decrypted = null;

        if (rx.IsMatch(encrypted))
        {
            for (int i = 0; i < encrypted.Count(); i++)
            {
                var curLetter = encrypted[i];
                var reduced = curLetter - 3;
                decrypted += (char)reduced;

            }


            var decryptedExtra = decrypted.Replace(substrings[0], substrings[1]);
            Console.WriteLine(decryptedExtra);
        }
        else
        {
            Console.WriteLine("This is not the book you are looking for.");
        }

    }

}