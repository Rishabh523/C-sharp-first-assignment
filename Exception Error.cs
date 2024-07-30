using System;
namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1, number_2, result;
            try
            {
                Console.WriteLine("Enter First Number:");
                number_1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                number_2 = int.Parse(Console.ReadLine());
                result = Number1 / Number2;
                Console.WriteLine($"Result = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}
