using System;
using System.Linq;

class SalesDataAnalyzer
{
    static void Main(string[] args)
    {
   
        int[] salesData = new int[30]; 
        Console.WriteLine("Enter the sales data for 30 days:");
        for (int i = 0; i < 30; i++)
        {
            Console.Write($"Day {i + 1}: ");
            salesData[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("\nOriginal Sales Data:");
        DisplaySalesData(salesData);

        
        int[] sortedSalesData = (int[])salesData.Clone();
        Array.Sort(sortedSalesData);
        Console.WriteLine("\nSorted Sales Data:");
        DisplaySalesData(sortedSalesData);

       
        int totalSales = salesData.Sum();
        int highestSales = salesData.Max();
        int lowestSales = salesData.Min();

        Console.WriteLine($"\nTotal Sales for the month: {totalSales}");
        Console.WriteLine($"Highest Single-Day Sales: {highestSales}");
        Console.WriteLine($"Lowest Single-Day Sales: {lowestSales}");

       
        Console.Write("\nEnter a sales value to search for: ");
        int searchValue = int.Parse(Console.ReadLine());

        bool exists = salesData.Contains(searchValue);
        if (exists)
        {
            Console.WriteLine($"The sales value {searchValue} exists in the data.");
        }
        else
        {
            Console.WriteLine($"The sales value {searchValue} does not exist in the data.");
        }

       
        int[] backupSalesData = (int[])salesData.Clone();
        Console.WriteLine("\nBackup of Sales Data created successfully!");

        
        int[] userEnteredData = new int[30];
        Console.WriteLine("\nEnter a new set of sales data for comparison (30 days):");
        for (int i = 0; i < 30; i++)
        {
            Console.Write($"Day {i + 1}: ");
            userEnteredData[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = salesData.SequenceEqual(userEnteredData);
        if (areEqual)
        {
            Console.WriteLine("\nThe original sales data and the new entered data are equal.");
        }
        else
        {
            Console.WriteLine("\nThe original sales data and the new entered data are not equal.");
        }
    }

    
    static void DisplaySalesData(int[] salesData)
    {
        for (int i = 0; i < salesData.Length; i++)
        {
            Console.Write(salesData[i] + "\t");
        }
        Console.WriteLine();
    }
}
