using System;
using System.IO;

namespace BTNHOM
{
    public class MaHoaRSA
    {
        string chuoikytu;
        int p, q, e;

        private void docfile(out int p, out int q, out int e, out string chuoikytu)
        {
            StreamReader file = new StreamReader("../../../banro.txt");
            p = int.Parse(file.ReadLine());
            q = int.Parse(file.ReadLine());
            e = int.Parse(file.ReadLine());
            chuoikytu = file.ReadLine();
            file.Close();
        }

        public void tienHanhMaHoa()
        {
            docfile(out p, out q, out e, out chuoikytu);

            int N = p * q;
            int n = (p - 1) * (q - 1);
            int d = timNghichDaoCuaE(e, n);
            Console.WriteLine(" ======== MA HOA VA GIAI MA RSA TU FILE ========\n");
            Console.WriteLine(" p = {0}",p);
            Console.WriteLine(" q = {0}",q);
            Console.WriteLine(" e = {0}",e);
            Console.WriteLine(" d = {0}\n",d);
            Console.WriteLine(" Khoa rieng Kr = (d,N) = ({0},{1})\n", d, N);
            Console.WriteLine(" Khoa cong khai Ku = (e,N) = ({0},{1})\n", e, N);
            Console.WriteLine(" Ban ro: {0}\n", chuoikytu);
            Console.WriteLine(" ---------------------------------------------------\n");
            // Ma hoa va giai ma theo PA 1 : Bao mat
            Console.WriteLine(" Chuoi ma hoa (ma hoa bao mat):\n {0}\n",maHoaBaoMat(chuoikytu, e, N));
            Console.WriteLine(" Chuoi giai ma (giai ma bao mat):\n {0}\n",giaiMaBaoMat(maHoaBaoMat(chuoikytu, e, N), d, N));
            // Ma hoa va giai ma theo PA 2 : Chung thuc
            Console.WriteLine(" Chuoi ma hoa (ma hoa chung thuc):\n {0}\n" ,maHoaBaoMat(chuoikytu, d, N));
            Console.WriteLine(" Chuoi giai ma (giai ma chung thuc):\n {0}\n" ,giaiMaBaoMat(maHoaBaoMat(chuoikytu, d, N), e, N));
        }

        private string maHoaBaoMat(string chuoikytu, int e, int N)
        {
            string[] mangTu = chuoikytu.Split(' ');
            string chuoiMaHoa = "";
            foreach(string tu in mangTu)
            {
                for(int i=0; i<tu.Length; i++)
                {
                    chuoiMaHoa += mod(chuyenKiTuThanhSo(tu[i]), e, N) + "69";
                }
                chuoiMaHoa += "9696";
            }
            return chuoiMaHoa;
        }

        private string giaiMaBaoMat(string chuoimahoa, int d, int N)
        {
            string[] mangTu = chuoimahoa.Split(new[] {"9696"}, StringSplitOptions.RemoveEmptyEntries);
            string chuoiGiaiMa = "";
            foreach (string tu in mangTu)
            {
                string[] mangKyTu = tu.Split(new[] {"69"}, StringSplitOptions.RemoveEmptyEntries);
                foreach(string kytu in mangKyTu)
                    chuoiGiaiMa += chuyenSoThanhKiTu(mod(Int32.Parse(kytu), d, N));
                chuoiGiaiMa += " ";
            }
            return chuoiGiaiMa;
        }

        private string maHoaChungThuc(string chuoikytu, int d, int N)
        {
            string[] mangTu = chuoikytu.Split(' ');
            string chuoiMaHoa = "";
            foreach (string tu in mangTu)
            {
                for (int i = 0; i < tu.Length; i++)
                {
                    chuoiMaHoa += mod(chuyenKiTuThanhSo(tu[i]), d, N) + "69";
                }
                chuoiMaHoa += "9696";
            }
            return chuoiMaHoa;
        }

        private string giaiMaChungThuc(string chuoimahoa, int e, int N)
        {
            string[] mangTu = chuoimahoa.Split(new[] { "9696" }, StringSplitOptions.RemoveEmptyEntries);
            string chuoiGiaiMa = "";
            foreach (string tu in mangTu)
            {
                string[] mangKyTu = tu.Split(new[] { "69" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string kytu in mangKyTu)
                    chuoiGiaiMa += chuyenSoThanhKiTu(mod(Int32.Parse(kytu), e, N));
                chuoiGiaiMa += " ";
            }
            return chuoiGiaiMa;
        }

        // Phep tinh luy thua
        private int mod(int x, int b, int n) 
        {
            int a = x, y = 1;
            do
            {
                if (b % 2 != 0)
                    y = (y * a) % n;
                b = b >> 1;
                a = (a * a) % n;
            }
            while (b > 0);
            return y;
        }

        private int timNghichDaoCuaE(int e, int n)
        {
            for (int i = 0; i < n; i++)
                if (i != e && (i * e) % n == 1)
                    return i;
            return -1;
        }

        
        private char chuyenSoThanhKiTu(int kt)
        {
            // Trong Z26 ta gan so cho ky tu nhu sau:
            // A B C D E F G H I ... Z
            // 0 1 2 3 4 5 6 7 8 ... 25
            char[] digit = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
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
                    so =  i;
                    break;
                }
            return so;
        }
    }
}
