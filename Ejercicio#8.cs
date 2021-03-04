using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP24
{
    class ConsoleAPP24
    {
        private float[] alt;
        private float prom;

        public void Car()
        {
            alt = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alt[f] = float.Parse(linea);
            }
        }

        public void CalProm()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + alt[f];
            }
            prom = suma / 5;
            Console.WriteLine("Promedio de alturas:" + prom);
        }

        public void MayMen()
        {
            int may, men;
            may = 0;
            men = 0;
            for (int f = 0; f < 5; f++)
            {
                if (alt[f] > prom)
                {
                    may++;
                }
                else
                {
                    if (alt[f] < prom)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de Personas Mayores Al Promedio:" + may);
            Console.WriteLine("Cantidad de Personas Menores Al Promedio:" + men);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            ConsoleAPP24 pv2 = new ConsoleAPP24();
            pv2.Car();
            pv2.CalProm();
            pv2.MayMen();
        }
    }
}