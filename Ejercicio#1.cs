using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int tol;
            int res;
            int[] num = new int[4] {10,10,10,10};
            res = num[0] + num[1] + num[2] + num[3];
            tol = res / 4;  
            Console.Write("Su Media Aritmetica es {0} ",tol);

        }
    }
}
