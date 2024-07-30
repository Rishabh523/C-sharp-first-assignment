using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a string:");
        string input = Console.ReadLine();

        // Split the string into words using spaces as the delimiter
        string[] words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Count the number of words
        int word_Count = words.Length;

        Console.WriteLine($"Total number of words: {word_Count}");
        Console.ReadLine();
    }
    
}
