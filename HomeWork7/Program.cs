using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    static public class Program
    {

        static void Main()
        {
            int[,] matrix = new int[3, 4];
            PrintArray(matrix);
        }
        static void PrintArray(int[,] matr)
        {

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {

                    matr[i, j] = new Random().Next(1, 100);
                    Console.Write($"{matr[i, j]} \t");
                }
                Console.WriteLine();
            }

        }

    }
}
