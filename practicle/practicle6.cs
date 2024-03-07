using System;

namespace practicle6
{
    public class test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter seconds to convert into hours, minutes, and seconds");
            int sec = Convert.ToInt32(Console.ReadLine());

            int hour = sec / 3600;
            int minute = (sec % 3600) / 60;
            int second = sec % 60;

            Console.WriteLine($"Hour = {hour} hours");
            Console.WriteLine($"Minute = {minute} minutes");
            Console.WriteLine($"Second = {second} seconds");
        }
    }
}
