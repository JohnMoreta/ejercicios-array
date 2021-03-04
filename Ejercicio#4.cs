using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <10 ;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num.Max());
        }
    }
}