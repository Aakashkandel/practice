using System;
namespace anamolus_delegate{
    public delegate String delegatePrint(string name);

   public class test{
    public static void Main (string [] args)

    {
        Console.WriteLine("Enter the number which you want to display?");
        string name=Console.ReadLine();
        delegatePrint obj= delegate(string n)
        {
            return "My name is "+n;
        };

        string result=obj.Invoke(name);
        Console.WriteLine(result);
    }
   }
}