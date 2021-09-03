using System;

namespace Lab_1_Part_3
{
    static class Utils
    {
        public static void PrintArray<T>(T[,] items)
        {
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    Console.Write("{0}\t", items[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

}