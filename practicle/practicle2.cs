//practicle 1
using System;
namespace practicle2
{
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius(R) of the outer circle");
            int R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the radius(r) of the inner circle");
            int r = Convert.ToInt32(Console.ReadLine());

            Double pie=Convert.ToDouble(3.14);
            
            Double area=Convert.ToDouble(pie*(R*R-r*r));

            Console.WriteLine($"The area of two concentric circle is {area}");

            
           
        }
    }
}