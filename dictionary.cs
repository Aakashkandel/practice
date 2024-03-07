using System;
using System.Collections.Generic;
namespace dictionary_practice{
    public class test{
        public static void Main(string [] args)
        {
            Dictionary<int,string>objdic=new Dictionary<int,string>();
            objdic.Add(1,"aakash");
            objdic.Add(3,"sohan");
            objdic.Add(14,"rahul");
            objdic.Add(16,"pratham");
            Console.WriteLine(objdic.Count);
           foreach(var data in objdic)
           {
            Console.WriteLine($"key: {data.Key} and the value is {data.Value}");
           }

        }
    }
}