using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayForSorting = {
    { 5, 5, 7, 22 },
    { 5, 25, -1, 18 },
    { 2, -12, 20, 5 }
};

            int height = arrayForSorting.GetLength(0);
            int weight = arrayForSorting.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; )
                {
                    
                    if ((i > 0 && j == 0) && arrayForSorting[i, j] < arrayForSorting[i - 1, weight - 1])
                    {
                        int temp = arrayForSorting[i, j];
                        arrayForSorting[i, j] = arrayForSorting[i - 1, weight - 1];
                        arrayForSorting[i - 1, weight - 1] = temp;

                        i--;
                        j = weight - 1;
                    }
                    
                    else if (j > 0 && arrayForSorting[i, j] < arrayForSorting[i, j - 1])
                    {
                        int temp = arrayForSorting[i, j];
                        arrayForSorting[i, j] = arrayForSorting[i, j - 1];
                        arrayForSorting[i, j - 1] = temp;

                        j--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            // Вывод отсортированных значений массива
            for (int i = 0; i < height; i++)
            {
                for (int j = 0;j < weight; j++)
                {
                    Console.Write(String.Format("{0,4}", arrayForSorting[i,j] + " "));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void sortingMethod(int firstNumber, int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
    }
}