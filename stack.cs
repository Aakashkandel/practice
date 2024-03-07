using System;
using System.Collections.Generic;
using System.Collections;


namespace stack{
    public class test{
        public static void Main (string [] args)
        {
            Stack<string> q=new Stack<string>();
            q.Push("aakash");
            q.Push("suman");
            q.Push("pratik");
            Console.WriteLine("Data before deletion in Stack");
            foreach(var data in q)
            {
                Console.WriteLine(data);
            }
            q.Pop();

            Console.WriteLine("Data after deletion in Stack");
              foreach(var data in q)
            {
                Console.WriteLine(data);
            }
        }
    }
}