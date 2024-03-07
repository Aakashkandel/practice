using System;
using constructor_override;
namespace constructor_override{
    public class animal{
        public int num1{get;set;}
        public int num2{get;set;}

        public animal(int n1,int n2)
        {
            num1=n1;
            num2=n2;

        }

        public virtual void display()
        {
            Console.WriteLine("this is base class");
        }
    }

    class dog:animal{
        public int num3 {get;set;}
        public dog(int num3,int num1,int num2):base(num1,num2)
        {
            this.num3=num3;
            Console.WriteLine("this is constructor"+num1);
            Console.WriteLine("this is constructor"+num2);
            Console.WriteLine("this is constructor"+num3);
        }


         public override void display()
        {
            base.display();
            Console.WriteLine("this is override class");
        }
    }

    public class program{
        public static void Main(string [] args)
        {
            dog d=new dog(5,6,7);
            animal a=new animal(2,3);
           
            d.display();
        }
    }
}