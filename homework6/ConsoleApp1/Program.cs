// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] myArray = new char[4,5];

            Fill2DArrayWithChars(myArray);
            Print2DArray(myArray);
            string result = Convert2DCharArrayToString(myArray);
            Console.WriteLine(result);
        }

        static string Convert2DCharArrayToString(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            char[] array1D = new char[rows*cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1D[index] = array[i, j];
                    index++;
                }
            }

            Console.WriteLine();
            string text = new string(array1D);
            return text;

            
        }

        static char[,] Fill2DArrayWithChars(char[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (char)('a' + rnd.Next(0, 26));
                }
            }
            return array;
        }

        static void Print2DArray(char[,] array)
        {
            for(int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++) 
                {
                    Console.Write(array[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
