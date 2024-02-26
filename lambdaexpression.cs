// using System;
// namespace anamolus_delegate;
// public delegate string delegatePrint(string name);
// class lamdaexpression{
//     public static void Main (string [] args)
//     {
//         delegatePrint obj2=(name)=>{
//             return "mero name "+name +" ho";
//         };

//        string str= obj2.Invoke("rahul");
//        Console.WriteLine(str);
//     }
// }

using System;

namespace lambdexpression_
{
    public delegate int DelegateSquare(int n);

    public class Test
    {
        public int Square(int n) => n * n;

        public static void Main(string[] args)
        {
            Test testInstance = new Test();
            DelegateSquare obj = new DelegateSquare(testInstance.Square);
            int result = obj.Invoke(2);
            Console.WriteLine($"The result is {result}");
        }
    }
}
