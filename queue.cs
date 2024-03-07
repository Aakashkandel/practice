using System;
using System.Collections.Generic;
using System.Collections;
namespace queue{
    public class test{
        public static void Main (string [] args)
        {
            Queue<string> q=new Queue<string>();
            q.Enqueue("aakash");
            q.Enqueue("suman");
            q.Enqueue("pratik");
            Console.WriteLine("Data before deletion");
            foreach(var data in q)
            {
                Console.WriteLine(data);
            }
            q.Dequeue();

            Console.WriteLine("Data after deletion");
              foreach(var data in q)
            {
                Console.WriteLine(data);
            }
        }
    }
}