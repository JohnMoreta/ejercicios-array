using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Per
    {
        private string nom;
        private int num;

        public void Inicia()
        {
            Console.Write("Ingrese el nombre:");
            nom = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
        }

        public void Imp()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nom);
            Console.Write("Edad:");
            Console.WriteLine(num);
        }

        public void Maynum()
        {
            if (num >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("Es menor de edad");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Per per1 = new Per();
            per1.Inicia();
            per1.Imp();
            per1.Maynum();
        }
    }
}