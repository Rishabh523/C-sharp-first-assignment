using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numeric integer: ");

        try
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 0 || num > 1000)
            {
                throw new Exception("Please enter the number between 0 and 1000.");
            }

            Console.WriteLine($"You entered: {num}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.ReadLine();
    }
}
