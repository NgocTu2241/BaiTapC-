using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Age
    {
        int age;
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            Ktra(a);
            b = int.Parse(Console.ReadLine());
            Ktra(b);
            c = int.Parse(Console.ReadLine());
            Ktra(c);
            Console.ReadKey();
        }
        static void Ktra(int age)
        {
            if (age >= 60)
                Console.WriteLine("Gia");
            else if (age < 18)
                Console.WriteLine("Tre em");
            else
                Console.WriteLine("Nguoi lon");
        }
    }
}
