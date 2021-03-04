using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese su nombre: ");

            string nom = Console.ReadLine();

            foreach (var letter in nom)

            {

                Console.Write(letter + " ");

            }

        }
    }
}
