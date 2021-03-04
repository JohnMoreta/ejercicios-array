using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] num = new float[5] { 1.5f, 1.2f, 4.6f, 8.7f, 9.3f };
            //Console.WriteLine("El Resultado es: "+num[4]+num[3] + num[2] + num[1] + num[0]);
            Array.Reverse(num);
            foreach (float i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
