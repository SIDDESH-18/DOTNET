using System;

class StoreSalesAnalysis
{
    static void Main()
    {
        Console.Write("Enter number of days in the month: ");
        int n = int.Parse(Console.ReadLine());

        int[] sales = new int[n];

        Console.WriteLine("\nEnter sales for each day:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Day {i + 1}: ");
            sales[i] = int.Parse(Console.ReadLine());
        }

        int[] salesBackup = new int[n];
        Array.Copy(sales, salesBackup, n);

        
        Console.WriteLine("\nOriginal Sales Data:");
        DisplayArray(sales);

        
        int[] sortedSales = new int[n];
        Array.Copy(sales, sortedSales, n);
        Array.Sort(sortedSales);

        Console.WriteLine("\nSorted Sales Data:");
        DisplayArray(sortedSales);

        
        int total = 0;
        foreach (int s in sales)
            total += s;

        
        int highest = sortedSales[n - 1];
        int lowest = sortedSales[0];

        Console.WriteLine("\n--- Summary Statistics ---");
        Console.WriteLine($"Total Sales: {total}");
        Console.WriteLine($"Highest Single-Day Sales: {highest}");
        Console.WriteLine($"Lowest Single-Day Sales: {lowest}");

        
        Console.Write("\nEnter a sales value to search: ");
        int searchValue = int.Parse(Console.ReadLine());

        bool found = Array.Exists(sales, val => val == searchValue);

        if (found)
            Console.WriteLine("The sales value exists in the data.");
        else
            Console.WriteLine("The sales value does NOT exist in the data.");

        
        Console.WriteLine("\nEnter another set of sales data to compare:");

        int[] otherSales = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Day {i + 1}: ");
            otherSales[i] = int.Parse(Console.ReadLine());
        }

        bool arraysEqual = CompareArrays(sales, otherSales);
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
