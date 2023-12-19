using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            string inputString = "1233211"; // произвольная строка

            bool isPalindrome = CheckPalindrome(inputString);

            Console.WriteLine("Строка является палиндромом: " + isPalindrome);
        }

        static bool CheckPalindrome(string inputString)
        {
            int length = inputString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (inputString[i] != inputString[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
