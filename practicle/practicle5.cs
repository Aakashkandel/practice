//practicle 1
using System;
namespace practicle5
{
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose which operation you want to perform?");
            Console.WriteLine("a. Reverse of the number.");
            Console.WriteLine("b. Factorial of the number.");
            Console.WriteLine("c. Volume of the number.");

            Console.WriteLine("Enter your Choice among a,b and c");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case "a":
                    int temp = num;
                    int rev = 0, rem;
                    do
                    {
                        rem = num % 10;
                        rev = rev * 10 + rem;
                        num = num / 10;
                    }
                    while (num != 0);
                    Console.WriteLine($"The reverse of the number is {rev}");
                    break;

                case "b":
                    int fact = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine($"\nThe Factorial of the given number is {fact}");

                    break;

                case "c":
                    int volume = num * num * num;
                    Console.WriteLine($"The Volume of the given number is {volume}");
                    break;

                default:
                    Console.WriteLine("Sorry!Your choice is invalid !");
                    break;


            }





        }
    }
}