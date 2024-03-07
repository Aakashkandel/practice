using System;
using System.Collections;

namespace array_list{
    public class test1{
        public static void Main(string[] args)
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add("aakash");
            arrayList.Add("sohan");
            arrayList.Add("basanta");
            arrayList.Add(0.5);
            arrayList.Add(39);
            arrayList.Add(true);

            foreach(var e in arrayList)
            {
                Console.WriteLine(e);
            }
        }
    }
}