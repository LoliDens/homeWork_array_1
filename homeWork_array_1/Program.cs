using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {
                { 1, 2, 3, 3 ,3 },
                { 4, 5, 6, 3, 3 }, 
                { 7, 8, 9, 3, 3 } };
            int lineAmount = 0;
            int colunmMuiltiplication = 1;
            int column = 1;
            int row = 0;

            for (int i = 0; i < numbers.GetLength(1); i++) 
            {
                lineAmount += numbers[column, i];
            }

            for (int i = 0; i < numbers.GetLength(0); i++) 
            {
                colunmMuiltiplication *= numbers[i, row];
            }

            for (int i = 0; i < numbers.GetLength(0); i++) 
            {
                for (int j = 0; j < numbers.GetLength(1); j++) 
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
