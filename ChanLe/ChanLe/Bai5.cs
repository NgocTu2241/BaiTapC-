using System;

namespace Chanle
{
    class Bai5
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("nhap chuoi");
            //string x = Console.ReadLine();
            //Console.WriteLine("chuoi sau khi chuan hoa la: {0}", chanHoa(x));
            int n;
            Console.WriteLine("nhap so phan tu cua mang");
            n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            nhap(A);
            chanLe(A);
        }
        static void nhap(double[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("nhap phan tu A[{0}]:", i + 1);
                A[i] = double.Parse(Console.ReadLine());
            }
        }
        static void chanLe(double[] A)
        {
            double[] A1 = new double[A.Length];
            double[] A2 = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Console.WriteLine("{0} la so chan", A[i]);
                }
                else
                {
                    Console.WriteLine("{0} la so le", A[i]);
                }
            }
        }
        static string chanHoa(string st)
        {
            st = st.Trim().ToLower();
            while (st.Contains(" ")) // chuyen nhieu khoang chan thanh 1 khoang chan
                st = st.Replace(" ", " ");
            string st1 = "";
            string[] arr = st.Split(' ');
            foreach (string item in arr)
                st1 += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
            return st1.TrimEnd();
        }
    }
}
