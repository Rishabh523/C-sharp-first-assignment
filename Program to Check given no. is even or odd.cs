using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n%2 == 0)
        {
            Console.WriteLine($"{n} is even.");
        }
        else
        {
            Console.WriteLine($"{n} is odd.");
        }
        Console.ReadLine();
    }
}
