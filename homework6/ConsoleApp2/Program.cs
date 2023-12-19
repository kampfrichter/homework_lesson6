//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            string inputString = "DSFJSDKLFJsdlfkjdslsd;fksd;DSFDS"; 

            string lowercaseString = ConvertToLowerCase(inputString);

            Console.WriteLine("Строка в нижнем регистре: " + lowercaseString);
        }

        static string ConvertToLowerCase(string inputString)
        {
            string lowercaseString = "";

            foreach (char c in inputString)
            {
                if (Char.IsUpper(c))
                {
                    lowercaseString += Char.ToLower(c);
                }
                else
                {
                    lowercaseString += c;
                }
            }

            return lowercaseString;
        }
    }
}
