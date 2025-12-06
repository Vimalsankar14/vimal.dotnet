using System;

class SmallestValueProgram
{
    static void Main()
    {
        Console.Write("Enter how many numbers: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("\nEnter the numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int smallest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
                smallest = numbers[i];
        }

        Console.WriteLine($"\nSmallest number: {smallest}");

        Console.ReadLine();
    }
}
