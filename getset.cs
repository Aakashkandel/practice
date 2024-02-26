using System;
private int data;
class test1{
public int x{
    get{
        return data;
    }
    set{
        data=value;
        
    }
}
}
class test2{
    public static void Main(string []args){
        test1 obj =new test1();
        obj.data="Aakash";
        string n=obj.data;
        Console.WriteLine(n);
    }
}