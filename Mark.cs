
using System;

class StudentMarksAnalysis
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];
        int[] backupMarks = new int[n];

       
        Console.WriteLine("\nEnter the marks:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Mark {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
            backupMarks[i] = marks[i];     
        }

        
      
        Console.WriteLine("\nMarks in the order entered:");
        DisplayArray(marks);

        
       
        int[] sortedMarks = (int[])marks.Clone();
        Array.Sort(sortedMarks);

        Console.WriteLine("\nMarks in sorted order:");
        DisplayArray(sortedMarks);

       
        int total = 0, highest = marks[0], lowest = marks[0];
        foreach (int mark in marks)
        {
            total += mark;
            if (mark > highest) highest = mark;
            if (mark < lowest) lowest = mark;
        }

        Console.WriteLine($"\nTotal marks: {total}");
        Console.WriteLine($"Highest mark: {highest}");
        Console.WriteLine($"Lowest mark:  {lowest}");

        
        Console.Write("\nEnter a mark to search: ");
        int searchMark = int.Parse(Console.ReadLine());
        bool found = Array.Exists(marks, m => m == searchMark);

        if (found)
            Console.WriteLine($"Mark {searchMark} is FOUND in the list.");
        else
            Console.WriteLine($"Mark {searchMark} is NOT found.");

        
        Console.Write("\nEnter the number of students for second set: ");
        int m = int.Parse(Console.ReadLine());

        int[] secondMarks = new int[m];
        Console.WriteLine("\nEnter marks for second set:");
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Mark {i + 1}: ");
            secondMarks[i] = int.Parse(Console.ReadLine());
        }

        bool identical = CompareArrays(marks, secondMarks);
        Console.WriteLine("\nComparison Result:");
        Console.WriteLine(identical
            ? "Both sets of marks are IDENTICAL."
            : "The sets of marks are NOT identical.");

        
        Console.WriteLine("\nBackup copy of marks:");
        DisplayArray(backupMarks);

        Console.WriteLine("\n--- END OF REPORT ---");
    }

    static void DisplayArray(int[] arr)
    {
        foreach (int val in arr)
            Console.Write(val + " ");
        Console.WriteLine();
    }

  
    static bool CompareArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }
}
