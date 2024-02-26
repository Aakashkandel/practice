using System;

namespace learndelegate {
    public delegate void addDelegate(int a, int b);
    public delegate void stringDelegate(string a);
    
    public class delegate_learn
    {
        public void addNum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"The sum of two number is {sum}");
        }

        public void subnumber(int a,int b)
        {
            int sub=a-b;
            Console.WriteLine($"Th sub of two number is {sub}");
        }

        public void multiple(int a, int b){
            int mul=a*b;
            Console.WriteLine($"the mul of two number is {mul}");
        }

        // public static void read_string(string a)
        // {
        //     Console.WriteLine($"this is static string text i.e {a}");
        // }

        
    }

    public class test1{
        public static void Main(string[] args)
        {
            delegate_learn obj1 = new delegate_learn();

            addDelegate ad = new addDelegate(obj1.addNum);

            ad+=obj1.multiple;
            ad+=obj1.subnumber;
            ad.Invoke(4, 5);

            // stringDelegate str = new stringDelegate(delegate_learn.read_string);
            // str("aakash"); 
        }
    }
}