using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {

            int szam = 0;

            Console.WriteLine("Kérem adjon meg két azonos hosszúságú szöveget: ");

            Console.Write("Első szöveg: ");

            string elsoSzoveg = Console.ReadLine();

            Console.Write("Második szöveg: ");

            string masodikSzoveg = Console.ReadLine();

            for (int i = 0; i < elsoSzoveg.Length; i++)
            {
                if (elsoSzoveg[i] != masodikSzoveg[i])
                {
                    szam++;
                }
            }

            Console.WriteLine($"A {elsoSzoveg} és {masodikSzoveg} távolsága: {szam}");

            Console.ReadKey();

        }
    }
}
