using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNHOM
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" ======= DANH SACH LOAI MA HOA =======");
                Console.WriteLine(" 1. Ma hoa & Giai ma Ceasar");
                Console.WriteLine(" 2. Ma hoa & Giai ma Playfair");
                Console.WriteLine(" 3. Ma hoa & Giai ma Virgenere");
                Console.WriteLine(" 4. Ma hoa & Giai ma A5/1");
                Console.WriteLine(" 5. Ma hoa & Giai ma DES");
                Console.WriteLine(" 6. Ma hoa & Giai ma RSA");
                Console.WriteLine(" 7. Giai thuat Extended Euclid");
                Console.WriteLine(" 8. Giai thuat Power");
                Console.WriteLine(" 9. Thoat");
                Console.WriteLine(" =====================================");
                Console.Write(" Nhap so chon chuc nang: ");
                String c = Console.ReadLine();
                Console.WriteLine();
                switch (c)
                {
                    case "1":
                        {
                            new MaHoaCeasar().tienHanhMaHoa();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "2":
                        {
                            new MaHoaPlayFair().tienHanhMaHoa();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "3":
                        {
                            new MaHoaVirgenere().tienHanhMaHoa();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "4":
                        {
                            new MaHoaA51().tienHanhMaHoa();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "5":
                        {
                            new MaHoaDES().tienHanhMaHoa();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "6":
                        {
                            new MaHoaRSA().tienHanhMaHoa();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "7":
                        {
                            new Extended_Euclid().tienHanh();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "8":
                        {
                            new Power().tienHanh();
                            Console.Write("\n Nhan nut bat ky de chon lai....");
                            break;
                        }
                    case "9":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.ReadKey();
            }
        }
    }
}
