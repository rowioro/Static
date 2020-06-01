using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            CzlowiekStatic czlowiek1 = new CzlowiekStatic();
            Console.WriteLine(czlowiek1.imie);
            czlowiek1.imie = "Alicja";
            Console.WriteLine(czlowiek1.imie);
            Console.WriteLine(CzlowiekStatic.nazwisko);
            CzlowiekStatic.nazwisko = "Strugala";
            Console.WriteLine(CzlowiekStatic.nazwisko);
            CzlowiekStatic czlowiek2 = new CzlowiekStatic();
            Console.WriteLine(czlowiek2.imie);
            Console.ReadKey();
        }
    }
}
