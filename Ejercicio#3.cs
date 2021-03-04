using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros de Dias por Mes");
            int[] num = new int[13] {0,31,28,31,30,31,30,31,31,30,31,30,31};
            int[] dias = new int[4];
            dias[1] = 31;
            dias[2] = 30;
            dias[3] = 28;
            int mes = 0;
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El mes número {0} tiene {1} dias", mes, num[mes]);

        }
    }
}
