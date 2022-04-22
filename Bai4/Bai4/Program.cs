using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void main(string[] args)
        {  
            int n;
            Console.WriteLine("Nhap so");
            n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b = (n / 10) % 10;
            int c = n / 100;

            if (n < 100 || n > 999)
                Console.WriteLine("So khong nam trong gioi han!");
            else
                switch (c)
                {
                    case 0: Console.WriteLine("Mot tram"); break;
                    case 1: Console.WriteLine("Hai tram"); break;
                    case 2: Console.WriteLine("Ba tram"); break;
                    case 3: Console.WriteLine("Bon tram"); break;
                    case 4: Console.WriteLine("Nam tram"); break;
                    case 5: Console.WriteLine("Sau tram"); break;
                    case 6: Console.WriteLine("Bay tram"); break;
                    case 7: Console.WriteLine("Tam tram"); break;
                    case 8: Console.WriteLine("Chin tram"); break;
                }
            if (b % 10 == 0 && a != 0)
            {
                Console.WriteLine("Le");
            }
            switch (b)
            {
                case 0: Console.WriteLine("muoi"); break;
                case 1: Console.WriteLine("hai muoi"); break;
                case 2: Console.WriteLine("ba muoi"); break;
                case 3: Console.WriteLine("bon muoi"); break;
                case 4: Console.WriteLine("nam muoi"); break;
                case 5: Console.WriteLine("sau muoi"); break;
                case 6: Console.WriteLine("bay muoi"); break;
                case 7: Console.WriteLine("tam muoi"); break;
                case 8: Console.WriteLine("chin muoi"); break;
            }
            switch (a)
            {
                case 0: Console.WriteLine("Mot"); break;
                case 1: Console.WriteLine("Hai"); break;
                case 2: Console.WriteLine("Ba"); break;
                case 3: Console.WriteLine("Bon"); break;
                case 4: Console.WriteLine("Nam"); break;
                case 5: Console.WriteLine("Sau"); break;
                case 6: Console.WriteLine("Bay"); break;
                case 7: Console.WriteLine("Tam"); break;
                case 8: Console.WriteLine("Chin"); break;
            }
            Console.ReadLine();
        }
    }
}