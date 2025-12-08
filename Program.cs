using System;

namespace SnakePattern
{
    class program
    {
        static void Main()
        {
            int[,] matA = new int[4, 4];
            Console.WriteLine("Enter the elements of the 4x4 matrix row-wise:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   matA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix in snake pattern is:");

            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(matA[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        Console.Write(matA[i, j] + " ");
                    }

                }

            }
        }
    }
}