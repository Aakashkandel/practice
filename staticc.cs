using System;
public static class Static_class{

   public static void display1(){
        Console.WriteLine("This is display1");
    }
  public static    void  display2(){
        Console.WriteLine("This is display2");
    }

}
class Test{
    public static void Main(string [] args){
        Static_class.display1();
        
        Static_class.display2();
    }
}