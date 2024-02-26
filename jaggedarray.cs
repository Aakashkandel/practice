using System;
public class test{
    public static void Main(string [] args)
    {
        int [] [] jagged=new int [4][];
        jagged[0]=new int [3]{3,5,6};
        jagged[1]=new int [1]{8};
        jagged[2]=new int [6]{3,5,4,6,9,6};
        jagged[3]=new int [2]{2,2};

        int i,j;
        for(i=0;i<jagged.Length;i++)
        {
            for (j=0;j<jagged[i].Length;j++)
            {
                Console.Write(jagged[i][j]);
            }
            Console.WriteLine();
        }
    }
}