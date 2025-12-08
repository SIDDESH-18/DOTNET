using System;

namespace TransposeMatrix
{
    class Program
    {
        static void Main()
        {
            int[,] matA = new int[3, 3];
            Console.WriteLine("Enter elements of 3x3 matrix:");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Original Matrix is:");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matA[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Transpose Matrix is:");
            for(int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(matA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
