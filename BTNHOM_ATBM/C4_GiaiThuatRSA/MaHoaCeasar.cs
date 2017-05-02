using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BTNHOM
{
    public class MaHoaCeasar
    {
        string chuoi;
        int khoa;

        public MaHoaCeasar() { }

        private void docFile(out string banro, out int khoa)
        {
            StreamReader file = new StreamReader("../../../CEASAR.txt");
            banro = file.ReadLine();
            khoa = int.Parse(file.ReadLine());
            file.Close();
        }

        public void tienHanhMaHoa()
        {
            docFile(out chuoi, out khoa);
            Console.WriteLine(" ======== MA HOA VA GIAI MA CEASAR TU FILE ========\n");
            Console.WriteLine(" Ban ro : {0}\n", chuoi);
            Console.WriteLine(" Khoa : {0}\n", khoa);
            Console.WriteLine(" ---------------------------------------------------\n");
            Console.WriteLine(" Chuoi ma hoa: {0}\n", maHoaCeasar(chuoi, khoa));
            Console.WriteLine(" Chuoi giai ma: {0}\n", giaiMaCeasar(maHoaCeasar(chuoi,khoa), khoa));
        }

        static public string maHoaCeasar(string chuoi, int khoa)
        {
            string banMa = null;
            foreach (char c in chuoi)
            {
                if (('A' <= c && c <= 'Z'))
                {
                        int vt = 90 - c;
                        if (vt >= khoa)
                            banMa += Convert.ToChar((System.Convert.ToInt32(c) + khoa));
                        else
                            banMa = banMa + Convert.ToChar((khoa - vt + 64));
                }
                else if (('a' <= c && c <= 'z'))
                {
                    int vt = 122 - c;
                    if (vt >= khoa)
                        banMa += Convert.ToChar((System.Convert.ToInt32(c) + khoa));
                    else
                        banMa = banMa + Convert.ToChar((khoa - vt + 96));
                }
                else
                    banMa += Convert.ToChar((System.Convert.ToInt32(c) + khoa));
            }
            return banMa;
        }

        static public string giaiMaCeasar(string chuoi, int khoa)
        {
            string banRo = null;
            foreach (char c in chuoi)
            {
                if (('A' <= c && c <= 'Z'))
                {
                    int vt = c - 65;
                    if (vt >= khoa)
                        banRo += Convert.ToChar((System.Convert.ToInt32(c) - khoa));
                    else
                        banRo = banRo + Convert.ToChar((91 - (khoa - vt)));
                }
                else if (('a' <= c && c <= 'z'))
                {
                    int vt = c - 97;
                    if (vt >= khoa)
                        banRo += Convert.ToChar((System.Convert.ToInt32(c) - khoa));
                    else
                        banRo = banRo + Convert.ToChar((123 - (khoa - vt)));
                }
                else
                    banRo += Convert.ToChar((System.Convert.ToInt32(c) - khoa));
            }
            return banRo;
        }
    }
}
