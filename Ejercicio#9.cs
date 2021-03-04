using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class MultiTab
    {
        public void CarVal()
        {
            int val;
            string lin;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                lin = Console.ReadLine();
                val = int.Parse(lin);
                if (val != -1)
                {
                    Cal(val);
                }
            } while (val != -1);
        }

        public void Cal(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MultiTab tm = new MultiTab();
            tm.CarVal();
        }
    }
}