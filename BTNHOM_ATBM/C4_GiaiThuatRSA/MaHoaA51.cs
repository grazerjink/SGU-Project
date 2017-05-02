using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNHOM
{
    public class MaHoaA51
    {
        string banRo, x, y, z;

        public void docfile(out string banRo, out string x, out string y, out string z)
        {
            StreamReader file = new StreamReader("../../../A51.txt");
            banRo = file.ReadLine();
            x = file.ReadLine();
            y = file.ReadLine();
            z = file.ReadLine();
            file.Close();
        }

        public void tienHanhMaHoa()
        {
            docfile(out banRo, out x, out y, out z);
            Console.WriteLine(" ====================== MA HOA VA GIAI MA A5/1 TU FILE ======================\n");
            Console.WriteLine(" Ban ro : {0}\n", banRo);
            Console.WriteLine(" Khoa X, Y, Z : {0}, {1}, {2}\n", x, y, z);
            Console.WriteLine(" ----------------------------------------------------------------------------\n");
            Console.WriteLine(" Chuoi ma hoa: {0}\n", MaHoa(banRo, x, y, z));
            Console.WriteLine(" Chuoi giai ma: {0}\n", GiaiMa(MaHoa(banRo, x, y, z), x,y,z));
        }

        private string MaHoa(string chuoi, string x, string y, string z)
        {
            string[] mangTu = chuoi.Split(' ');
            string chuoimahoa = "";
            foreach (string tu in mangTu)
            {
                for (int i = 0; i < tu.Length; i++)
                {
                    string chuoiBits = Convert.ToString(chuyenKiTuThanhSo(tu[i]), 2).PadLeft(5,'0');
                    int vongLap = chuoiBits.Length;
                    int m, s;
                    string c = null;
                    for (int v = 0; v < vongLap; v++)
                    {
                        m = maj(int.Parse(x[8].ToString()), int.Parse(y[10].ToString()), int.Parse(z[10].ToString()));
                        if (m == int.Parse(x[8].ToString()))
                            x = quayX(x);
                        if (m == int.Parse(y[10].ToString()))
                            y = quayY(y);
                        if (m == int.Parse(z[10].ToString()))
                            z = quayZ(z);
                        s = int.Parse(x[18].ToString()) ^ int.Parse(y[21].ToString()) ^ int.Parse(z[22].ToString());
                        c = c + (s ^ int.Parse(chuoiBits[v].ToString()));
                    }
                    int dec = Convert.ToInt32(c, 2); // chuyển thành hệ số 10
                    chuoimahoa += chuyenSoThanhKiTu(dec);
                }
                chuoimahoa += " ";
            }
            return chuoimahoa;
        }

        private string GiaiMa(string chuoi, string x, string y, string z)
        {
            string[] mangTu = chuoi.Split(new[] { " " }, StringSplitOptions.None);
            string chuoigiaima = "";
            foreach (string tu in mangTu)
            {
                for (int i = 0; i < tu.Length; i++)
                { 
                    string chuoiBits = Convert.ToString(chuyenKiTuThanhSo(tu[i]), 2).PadLeft(5, '0'); ;
                    int vongLap = chuoiBits.Length;
                    int m, s;
                    string p = null;
                    for (int v = 0; v < vongLap; v++)
                    {
                        m = maj(int.Parse(x[8].ToString()), int.Parse(y[10].ToString()), int.Parse(z[10].ToString()));
                        if (m == int.Parse(x[8].ToString()))
                            x = quayX(x);
                        if (m == int.Parse(y[10].ToString()))
                            y = quayY(y);
                        if (m == int.Parse(z[10].ToString()))
                            z = quayZ(z);
                        s = int.Parse(x[18].ToString()) ^ int.Parse(y[21].ToString()) ^ int.Parse(z[22].ToString());
                        p = p + (s ^ int.Parse(chuoiBits[v].ToString()));
                    }
                    int dec = Convert.ToInt32(p, 2); // chuyển thành hệ số 10
                    chuoigiaima += chuyenSoThanhKiTu(dec);
                }
                chuoigiaima += " ";
            }
            return chuoigiaima;
        }


        private int maj(int x8, int y10, int z10)
        {
            int m = x8 + y10 + z10;
            if (m <= 1)
                return 0;
            else
                return 1;
        }

        private string quayX(string x)
        {
            int x13 = int.Parse(x[13].ToString());
            int x16 = int.Parse(x[16].ToString());
            int x17 = int.Parse(x[17].ToString());
            int x18 = int.Parse(x[18].ToString());
            int t = x13 ^ x16 ^ x17 ^ x18 ;
            x = t + x ; 
            return x.Remove(19); //chi dai 18 bit, khi dich phai du ra 1 bit cuoi nen phai xoa di.
        }

        private string quayY(string y)
        {
            int y20 = int.Parse(y[20].ToString());
            int y21 = int.Parse(y[21].ToString());
            int t = y20 ^ y21 ;
            y = t + y;
            return y.Remove(22);
        }

        private string quayZ(string z)
        {
            int z7 = int.Parse(z[7].ToString());
            int z20 = int.Parse(z[20].ToString());
            int z21 = int.Parse(z[21].ToString());
            int z22 = int.Parse(z[22].ToString());
            int t = z7 ^ z20 ^ z21 ^ z22 ;
            z = t + z;
            return z.Remove(23);
        }

        private char chuyenSoThanhKiTu(int kt)
        {
            // Trong Z26 ta gan so cho ky tu nhu sau:
            // A B C D E F G H I ... Z
            // 0 1 2 3 4 5 6 7 8 ... 25
            char[] digit = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int i;
            i = kt % 26;
            kt = kt / 26;
            if (i >= 26)
                return digit[i % 10];
            else
                return digit[i];
        }

        private int chuyenKiTuThanhSo(char kytu)
        {
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int so = 0;
            for (int i = 0; i < Alphabet.Length; i++)
                if (kytu == Alphabet[i])
                {
                    so = i;
                    break;
                }
            return so;
        }
    }
}
