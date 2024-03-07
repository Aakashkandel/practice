using System;
using System.Collections.Generic;
namespace generic_method{
    public class test1{
        public static t addNum<t>(t a,t b)
        {
            t ssum=(dynamic)a+(dynamic)b;
            return ssum;
        }
    }
    public class test2{
        public static void Main(string [] args)
        {
           
            int result=test1.addNum<int>(2,3);
            Console.WriteLine("The  sum of two number is {0}",result);
        }
    }
}