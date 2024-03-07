//practicle 1
using System;
namespace practicle1
{
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to check?");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 5 == 0) && num % 7 == 0)
            {
                Console.WriteLine($"The given number {num} is divisible by 5 and 7 ");

            }
            else
            {
                Console.WriteLine("unable to divisible by 5 and 7");
            }
        }
    }
}