using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNHOM
{
    public class Power
    {
        int n, x, b;
        public void tienHanh()
        {
            Console.WriteLine("Phep tinh luy thua nhu sau : x^b mod n");
            Console.Write("Nhap vao x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            int result = power(x, b, n);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n" + x + "^" + b + " mod " + n + " = " + result);
        }

        public int power(int x, int b, int n)
        {
            int a = x, y = 1;
            do
            {
                if (b % 2 != 0) y = (y * a) % n;
                b = b >> 1;
                a = (a * a) % n;
            }
            while (b > 0);
            return y;
        }
    }
}
