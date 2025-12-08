<<<<<<< HEAD
﻿using System;
<<<<<<< HEAD
using System.Buffers;
using System.Numerics;

namespace stdmarkGenerater
=======

namespace DifferenceofMatrix
>>>>>>> 3a859c4 (diffmatA inserted)
{
    class Program
    {
        static void Main()
        {
<<<<<<< HEAD
            Console.WriteLine("Enter number of student mark:");
            int n = int.Parse(Console.ReadLine());

            int[] mark = new int[n];

            Console.WriteLine("\nEnter the marks of students");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"student {i + 1}:");
                mark[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOrdered marks");
            DisplayArray(mark);

            Console.WriteLine("\nmarks in sorted order");
            int[] sortedMarks = new int[n];
            Array.Copy(mark, sortedMarks, n);
            Array.Sort(sortedMarks);

            DisplayArray(sortedMarks);

            int total = 0;
            foreach (int s in mark)
                total += s;

            int highestmark = sortedMarks[n - 1];
            int lowestmark = sortedMarks[0];

            Console.WriteLine("totalmark:{0}", total);
            Console.WriteLine("highestmark:{0}", highestmark);
            Console.WriteLine("lowestmark:{0}", lowestmark);


            Console.Write("\nEnter a mark to search: ");
            int searchmark = int.Parse(Console.ReadLine());

            bool found = Array.Exists(mark, val => val == searchmark);

            if (found)
                Console.WriteLine("The mark exists in the data.");
            else
                Console.WriteLine("The mark does NOT exist in the data.");


            int[] backupmark = new int[n];
            Array.Copy(mark, backupmark, n);

            Console.WriteLine("\nEnter another set of marks to compare:");

            int[] othermarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"student {i + 1}:");
                othermarks[i] = int.Parse(Console.ReadLine());
            }


            bool arraysEqual = CompareArrays(mark, othermarks);
            Console.WriteLine("\nAre the two sales data sets equal? " +
                              (arraysEqual ? "Yes" : "No"));
        }
        static void DisplayArray(int[] arr)
        {
            foreach (int value in arr)
                Console.Write(value + " ");
            Console.WriteLine();
        }


        static bool CompareArrays(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
    }
}

=======
            int[,] matA = new int[3, 3];
            Console.WriteLine("Enter elements of 3x3 matrix:");
            for (int i = 0; i < matA.GetLength(0); i++)
            {
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:", matA);

            Console.WriteLine("Print the sum of Primary diagonal");
            int psum = 0;
            for (int i = 0; i < 3; i++)
            {
                psum += matA[i, i];
            }
            Console.WriteLine("Primary diagonal sum is: " + psum);


            Console.WriteLine("Print the sum of Secondary diagonal");
            int ssum = 0;
            int n = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) == n)
                    {
                        ssum += matA[i, j];
                    }
                }
            }
            Console.WriteLine("Secondary diagonal sum is: " + ssum);

            int difference = Math.Abs(psum - ssum);
            Console.WriteLine("The difference between the sums of Primary and Secondary diagonal is: " + difference);
        }
    }
}
>>>>>>> 3a859c4 (diffmatA inserted)
=======
﻿using System;
<<<<<<< HEAD
using System.Buffers;
using System.Numerics;

namespace stdmarkGenerater
=======

namespace DifferenceofMatrix
>>>>>>> 3a859c4 (diffmatA inserted)
{
    class Program
    {
        static void Main()
        {
<<<<<<< HEAD
            Console.WriteLine("Enter number of student mark:");
            int n = int.Parse(Console.ReadLine());

            int[] mark = new int[n];

            Console.WriteLine("\nEnter the marks of students");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"student {i + 1}:");
                mark[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOrdered marks");
            DisplayArray(mark);

            Console.WriteLine("\nmarks in sorted order");
            int[] sortedMarks = new int[n];
            Array.Copy(mark, sortedMarks, n);
            Array.Sort(sortedMarks);

            DisplayArray(sortedMarks);

            int total = 0;
            foreach (int s in mark)
                total += s;

            int highestmark = sortedMarks[n - 1];
            int lowestmark = sortedMarks[0];

            Console.WriteLine("totalmark:{0}", total);
            Console.WriteLine("highestmark:{0}", highestmark);
            Console.WriteLine("lowestmark:{0}", lowestmark);


            Console.Write("\nEnter a mark to search: ");
            int searchmark = int.Parse(Console.ReadLine());

            bool found = Array.Exists(mark, val => val == searchmark);

            if (found)
                Console.WriteLine("The mark exists in the data.");
            else
                Console.WriteLine("The mark does NOT exist in the data.");


            int[] backupmark = new int[n];
            Array.Copy(mark, backupmark, n);

            Console.WriteLine("\nEnter another set of marks to compare:");

            int[] othermarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"student {i + 1}:");
                othermarks[i] = int.Parse(Console.ReadLine());
            }


            bool arraysEqual = CompareArrays(mark, othermarks);
            Console.WriteLine("\nAre the two sales data sets equal? " +
                              (arraysEqual ? "Yes" : "No"));
        }
        static void DisplayArray(int[] arr)
        {
            foreach (int value in arr)
                Console.Write(value + " ");
            Console.WriteLine();
        }


        static bool CompareArrays(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
    }
}

=======
            int[,] matA = new int[3, 3];
            Console.WriteLine("Enter elements of 3x3 matrix:");
            for (int i = 0; i < matA.GetLength(0); i++)
            {
                for (int j = 0; j < matA.GetLength(1); j++)
                {
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:", matA);

            Console.WriteLine("Print the sum of Primary diagonal");
            int psum = 0;
            for (int i = 0; i < 3; i++)
            {
                psum += matA[i, i];
            }
            Console.WriteLine("Primary diagonal sum is: " + psum);


            Console.WriteLine("Print the sum of Secondary diagonal");
            int ssum = 0;
            int n = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) == n)
                    {
                        ssum += matA[i, j];
                    }
                }
            }
            Console.WriteLine("Secondary diagonal sum is: " + ssum);

            int difference = Math.Abs(psum - ssum);
            Console.WriteLine("The difference between the sums of Primary and Secondary diagonal is: " + difference);
        }
    }
}
>>>>>>> 3a859c4 (diffmatA inserted)
>>>>>>> 21b7e799c331c032b1a46f5de60d0309dfa71463
