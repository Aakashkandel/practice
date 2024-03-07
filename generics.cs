using System;
public class test<t>
{
    private t data;
    public t value{
        get{
            return this.data;
        }
        set{
            this.data=value;
        }
    }
}
public class program{
    public static void Main (string [] args)
    {
        test <string> obj=new test<string>();
        obj.value="aakash";
        Console.WriteLine(obj.value);

        test<float>f=new test<float>();
        f.value=20.4f;
        Console.WriteLine(f.value);
    }
}