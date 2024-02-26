using System;
public class test{
    public static void Main(string []args)
    {
        int num=56;
        try{
            num=num/0
            
        }
        catch(exception e)
        {
            Console.WriteLine(e);
        }
    }
}