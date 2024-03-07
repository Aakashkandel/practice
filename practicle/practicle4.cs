//practicle 1
using System;
namespace practicle4
{
    public class test
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Enter the number which you want to check");
          int num=Convert.ToInt32(Console.ReadLine());

            int temp=num;
            int rev=0,rem;           
             do{
                 rem=num%10;
                 rev=rev*10+rem;
                num=num/10;
            }
            while(num!=0);
            Console.WriteLine($"The value of rev is {rev}");
            if(rev==temp)
            {
                Console.WriteLine("The number is Palindrome");
            }
            else
            {
                Console.WriteLine("The number is not Palindrome");

            }

           
            
           
        }
    }
}