using System;

namespace open_lab_03._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[2, 3] { { "one", "two", "three" }, { "apple", "orange", "banana" } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(array2D[row, col] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
