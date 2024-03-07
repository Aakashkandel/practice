//practicle 1
using System;
namespace practicle3
{
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum=0;

            for(int i=1;i<=num;i++)
            
            {
                int fact=1;
            
                for(int j=1;j<=i;j++)
                {
                     fact=fact*j;
                    sum=sum+(num/fact);

                }
                
            }

            Console.WriteLine($"The sum of the series is {sum}");

           
            
           
        }
    }
}