using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNHOM
{
    public class Extended_Euclid
    {
        int a, b;

        public void tienHanh()
        {
            Console.WriteLine("Giai thuat tim nghich dao b^-1 mod a");
            Console.Write("Nhap vao a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("------------------------------------------------");
            Console.WriteLine("\nSo nghich dao W = " + ExtendedEuclid(a, b));
        }

        public int ExtendedEuclid(int a, int b)
        {
            int a1 = 1, a2 = 0, a3 = a;
            int b1 = 0, b2 = 1, b3 = b;
            int q, r1, r2, r3;
            while (b3 != 0 && b3 != 1)
            {
                q = a3 / b3;
                r1 = a1 - q * b1;
                r2 = a2 - q * b2;
                r3 = a3 - q * b3;
                a1 = b1; a2 = b2; a3 = b3;
                b1 = r1; b2 = r2; b3 = r3;
            }
            if (b3 == 0) return a3;
            if (b3 == 1) return b2;
            return 0;
        }
    }
}
