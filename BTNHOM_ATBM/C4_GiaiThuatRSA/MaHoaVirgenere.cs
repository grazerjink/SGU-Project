using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BTNHOM
{
    public class MaHoaVirgenere
    {
        string[] arrUpper = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J","K", "L", "M", "N", 
                               "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " "};

        string[] arrLower = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                               "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " "};
        string banro = "";
        string khoa = "";

        private void docFile(out string banro, out string khoa)
        {
            StreamReader file = new StreamReader("../../../VIRGENERE.txt");
            banro = file.ReadLine();
            khoa = file.ReadLine();
            file.Close();
        }

        public void tienHanhMaHoa()
        {
            docFile(out banro, out khoa);
            Console.WriteLine(" =========== MA HOA VA GIAI MA VIRGENERE TU FILE ===========\n");
            Console.WriteLine(" Ban ro : {0}\n", banro.Trim());
            Console.WriteLine(" Khoa : {0}\n", khoa);
            Console.WriteLine(" ---------------------------------------------------\n");
            Console.WriteLine(" Chuoi ma hoa : {0}\n", maHoaVigenere(banro, khoa));
            Console.WriteLine(" Chuoi giai ma : {0}\n", giaiMaVigenere(maHoaVigenere(banro, khoa), khoa));
        }

        private string maHoaVigenere(string banRo, string k)
        {
            string key = taoChuoiKhoa(banRo, k);
            string banMa = "";
            for (int i = 0; i < banRo.Length; i++)
            {
                banMa += maHoaKyTuCeasar(banRo[i], key[i]);
            }
            return banMa;
        }

        private string giaiMaVigenere(string banMa, string k)
        {
            string key = taoChuoiKhoa(banMa, k);
            string banRo = "";
                for (int i = 0; i < banMa.Length; i++)
                {
                    banRo += giaiMaKyTuCeasar(banMa[i],key[i]);
                }
            return banRo;
        }

        private string maHoaKyTuCeasar(char p, char k)
        {
            int vt = viTriKyTu(p);
            int so = viTriCuaKhoa(k);
            if (Char.IsUpper(p))
            {
                return arrUpper[(vt + so) % 27];
            }
            else
            {
                return arrLower[(vt + so) % 27];
            }
        }

        private string giaiMaKyTuCeasar(char c, char k)
        {
            int vt = viTriKyTu(c);
            int so = viTriCuaKhoa(k);
            if (Char.IsUpper(c))
            {
                if ((vt - so) < 0)
                    return arrUpper[(vt - so) + 27];
                else
                    return arrUpper[(vt - so) % 27];
            }
            else
            {
                if ((vt - so) < 0)
                    return arrLower[(vt - so) + 27];
                else
                    return arrLower[(vt - so) % 27];
            }
        }

        private string taoChuoiKhoa(string str, string key)
        {
            string khoa = "";
            while (key.Length < str.Length)
                key += key;
            for (int i = 0; i < str.Length; i++)
                khoa = khoa + key[i];
            return khoa.ToUpper();
        }

        private int viTriKyTu(char kytu)
        {
            int vt = 0;
            if(Char.IsUpper(kytu))
            {
                for(int i = 0; i < arrUpper.Length; i++)
                    if (arrUpper[i].Equals(kytu.ToString()))
                        vt = i;
            }
            else
            {
                for (int i = 0; i < arrLower.Length; i++)
                    if (arrLower[i].Equals(kytu.ToString()))
                        vt = i;
            }
            
            return vt;
        }

        private int viTriCuaKhoa(char key)
        {
            int vt = 0;
            for (int i = 0; i < arrUpper.Length; i++)
                if (arrUpper[i].Equals(key.ToString()))
                    vt = i;
            return vt;
        }
    }
}
