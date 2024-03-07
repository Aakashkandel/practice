using System;

namespace practicle6
{
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of num1");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of num2");
            int num2=Convert.ToInt32(Console.ReadLine());

            num1= num1+num2;
            num2=num1-num2;
            num1=num1-num2;

            Console.WriteLine($"The value of num1 is {num1}");
            Console.WriteLine($"The value of num2 is {num2}");

            
        }
    }
}
