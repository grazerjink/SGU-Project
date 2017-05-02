using System;
using System.IO;
using System.Linq;
using System.Text;

namespace BTNHOM
{
    public class MaHoaDES
    {
        string banro, khoa, p, k;
        string[] key;

        public void tienHanhMaHoa()
        {
            docfile(out banro, out khoa);

            p = hex2binary(banro);
            k = hex2binary(khoa);
            TaoKhoa(out key, k);

            string kqMaHoa = MaHoa(p, key);
            string kqGiaiMa = GiaiMa(kqMaHoa, key);

            Console.WriteLine(" =========== MA HOA VA GIAI MA DES TU FILE ===========\n");
            Console.WriteLine(" Ban ro : {0} \n Chuoi nhi phan: {1}\n", banro,p);
            Console.WriteLine(" Khoa k : {0} \n Chuoi nhi phan: {1}\n",khoa,k);
            Console.WriteLine(" ---------------------------------------------------\n");
            Console.WriteLine(" Chuoi ma hoa: {0} \n Chuoi nhi phan: {1}\n",bin2hex(kqMaHoa), kqMaHoa);
            Console.WriteLine(" Chuoi giai ma: {0} \n Chuoi nhi phan: {1}\n",bin2hex(kqGiaiMa),kqGiaiMa);
        }

        private void docfile(out string p, out string k)
        {
            StreamReader file = new StreamReader("../../../DES.txt");
            p = file.ReadLine();
            k = file.ReadLine();
            file.Close();
        }

        private string hex2binary(string hexvalue)
        {
            return hexvalue.Aggregate(new StringBuilder(), 
                (builder, c) => builder.Append(Convert.ToString(Convert.ToInt64(c.ToString(), 16), 2).PadLeft(4, '0'))).ToString();
        }

        private string bin2hex(string bin)
        {
            int rest = bin.Length % 4;
            bin = bin.PadLeft(rest, '0'); //pad the length out to by divideable by 4

            string output = "";

            for (int i = 0; i <= bin.Length - 4; i += 4)
            {
                output += string.Format("{0:X}", Convert.ToByte(bin.Substring(i, 4), 2));
            }
            return output;
        }

        private string HoanViKhoiTao(string s)
        {
            return ""+ s[57] + s[49] + s[41] + s[33] + s[25] + s[17] + s[9] + s[1] +
                    s[59] + s[51] + s[43] + s[35] + s[27] + s[19] + s[11] + s[3] +
                    s[61] + s[53] + s[45] + s[37] + s[29] + s[21] + s[13] + s[5] +
                    s[63] + s[55] + s[47] + s[39] + s[31] + s[23] + s[15] + s[7] +
                    s[56] + s[48] + s[40] + s[32] + s[24] + s[16] + s[8] + s[0] +
                    s[58] + s[50] + s[42] + s[34] + s[26] + s[18] + s[10] + s[2] +
                    s[60] + s[52] + s[44] + s[36] + s[28] + s[20] + s[12] + s[4] +
                    s[62] + s[54] + s[46] + s[38] + s[30] + s[22] + s[14] + s[6];
        }

        private string HoanViKetThuc(string s)
        {
            return ""+ s[39] + s[7] + s[47] + s[15] + s[55] + s[23] + s[63] + s[31] +
                    s[38] + s[6] + s[46] + s[14] + s[54] + s[22] + s[62] + s[30] +
                    s[37] + s[5] + s[45] + s[13] + s[53] + s[21] + s[61] + s[29] +
                    s[36] + s[4] + s[44] + s[12] + s[52] + s[20] + s[60] + s[28] +
                    s[35] + s[3] + s[43] + s[11] + s[51] + s[19] + s[59] + s[27] +
                    s[34] + s[2] + s[42] + s[10] + s[50] + s[18] + s[58] + s[26] +
                    s[33] + s[1] + s[41] + s[9] + s[49] + s[17] + s[57] + s[25] +
                    s[32] + s[0] + s[40] + s[8] + s[48] + s[16] + s[56] + s[24];
        }

        private string HoanViKhoa(string s)
        {
            // Xài ngay lúc đầu tiến hành tách
            return "" + s[56] + s[48] + s[40] + s[32] + s[24] + s[16] + s[8] +
                         s[0] + s[57] + s[49] + s[41] + s[33] + s[25] + s[17] +
                         s[9] + s[1] + s[58] + s[50] + s[42] + s[34] + s[26] +
                         s[18] + s[10] + s[2] + s[59] + s[51] + s[43] + s[35] +
                         s[62] + s[54] + s[46] + s[38] + s[30] + s[22] + s[14] +
                         s[6] + s[61] + s[53] + s[45] + s[37] + s[29] + s[21] +
                         s[13] + s[5] + s[60] + s[52] + s[44] + s[36] + s[28] +
                         s[20] + s[12] + s[4] + s[27] + s[19] + s[11] + s[3];
        }

        private string NenKhoa(string s)
        {
            // Nén khóa là hoán vị dãy khóa
            return "" + s[13] + s[16] + s[10] + s[23] + s[0] + s[4] + s[2] + s[27] +
                         s[14] + s[5] + s[20] + s[9] + s[22] + s[18] + s[11] + s[3] +
                         s[25] + s[7] + s[15] + s[6] + s[26] + s[19] + s[12] + s[1] +
                         s[40] + s[51] + s[30] + s[36] + s[46] + s[54] + s[29] + s[39] +
                         s[50] + s[44] + s[32] + s[47] + s[43] + s[48] + s[38] + s[55] +
                         s[33] + s[52] + s[45] + s[41] + s[49] + s[35] + s[28] + s[31];
        }

        private void TaoKhoa(out string[] key, string k)
        {
            /*
             * Dịch vòng khóa
             */
            key = new string[17];
            k = HoanViKhoa(k);
            string kl = k.Substring(0, 28); // Lấy nửa khóa trái
            string kr = k.Substring(28, 28); // Lấy nửa khóa phải
            for (int i = 1; i <= 16; i++)
            {
                if (i == 1 || i == 2 || i == 9 || i == 16)
                {
                    kl = kl.Substring(1) + kl.Substring(0, 1);
                    kr = kr.Substring(1) + kr.Substring(0, 1);
                }
                else
                {
                    kl = kl.Substring(2) + kl.Substring(0, 2);
                    kr = kr.Substring(2) + kr.Substring(0, 2);
                }
                k = kl + kr;
                key[i] = NenKhoa(k);
            }
        }

        private string Expand(string s)
        {
            return "" + s[31] + s[0] + s[1] + s[2] + s[3] + s[4] +
                         s[3] + s[4] + s[5] + s[6] + s[7] + s[8] +
                         s[7] + s[8] + s[9] + s[10] + s[11] + s[12] +
                         s[11] + s[12] + s[13] + s[14] + s[15] + s[16] +
                         s[15] + s[16] + s[17] + s[18] + s[19] + s[20] +
                         s[19] + s[20] + s[21] + s[22] + s[23] + s[24] +
                         s[23] + s[24] + s[25] + s[26] + s[27] + s[28] +
                         s[27] + s[28] + s[29] + s[30] + s[31] + s[0];
        }

        private string XOR(string e, string k)
        {
            int cal;
            string result = null;
            for (int i = 0; i < 48; i++)
            {
                cal = e[i] ^ k[i];
                result += cal.ToString();
            }
            return result;
        }

        private string Pbox(string s)
        {
            return "" + s[15] + s[6] + s[19] + s[20] + s[28] + s[11] + s[27] + s[16] +
                        s[0] + s[14] + s[22] + s[25] + s[4] + s[17] + s[30] + s[9] +
                        s[1] + s[7] + s[23] + s[13] + s[31] + s[26] + s[2] + s[8] +
                        s[18] + s[12] + s[29] + s[5] + s[21] + s[10] + s[3] + s[24];
        }

        private string XORF(string f, string l)
        {
            int cal;
            string result = null;
            for (int i = 0; i < 32; i++)
            {
                cal = f[i] ^ l[i];
                result += cal.ToString();
            }
            return result;
        }

        private string MaHoa(string p, string[] key)
        {
            /* Đầu tiên là phải hoán vị khởi tạo ngay vòng 1
             * Tách khóa K (56bit) thành 2 phần 28 bit rồi dịch vòng trái 
             * 
             */
            string s, xor, pbox;
            string ip = HoanViKhoiTao(p);
            string[] l = new string[17];
            l[0] = ip.Substring(0, 32);
            string r = ip.Substring(32, 32);
            for (int i = 1; i <= 16; i++)
            {
                xor = XOR(Expand(r), key[i]);
                s = Sboxes.S_boxes(xor);
                pbox = Pbox(s);
                l[i] = r;
                r = XORF(pbox, l[i - 1]);
            }
            ip = r + l[16];
            ip = HoanViKetThuc(ip);
            return ip;
        }

        private string GiaiMa(string c, string[] key)
        {
            string s, xor, pbox;
            string ip = HoanViKhoiTao(c);
            string[] r = new string[17];
            string l = ip.Substring(32, 32);
            r[16] = ip.Substring(0, 32);
            for (int i = 16; i >= 1; i--)
            {
                xor = XOR(Expand(l), key[i]);
                s = Sboxes.S_boxes(xor);
                pbox = Pbox(s);
                r[i - 1] = l;
                l = XORF(pbox, r[i]);
            }
            ip = l + r[0];
            ip = HoanViKetThuc(ip);
            return ip;
        }
    }

    static class Sboxes
    {
        static public string S_boxes(string input)
        {
            string s1, s2, s3, s4, s5, s6, s7, s8;
            s1 = input.Substring(0, 6);
            s2 = input.Substring(6, 6);
            s3 = input.Substring(12, 6);
            s4 = input.Substring(18, 6);
            s5 = input.Substring(24, 6);
            s6 = input.Substring(30, 6);
            s7 = input.Substring(36, 6);
            s8 = input.Substring(42, 6);
            return S1(s1) + S2(s2) + S3(s3) + S4(s4) + S5(s5) + S6(s6) + S7(s7) + S8(s8);
        }
        static private int BinToDec(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }
        static private string HexToBin(string hexvalue)
        {
            return hexvalue.Aggregate(new StringBuilder(), (builder, c) =>
                    builder.Append(Convert.ToString(Convert.ToInt64(c.ToString(), 16), 2).PadLeft(4, '0'))).ToString();
        }
        static private string S1(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "E"; t[0, 1] = "4"; t[0, 2] = "D"; t[0, 3] = "1"; t[0, 4] = "2"; t[0, 5] = "F"; t[0, 6] = "B"; t[0, 7] = "8";
            t[0, 8] = "3"; t[0, 9] = "A"; t[0, 10] = "6"; t[0, 11] = "C"; t[0, 12] = "5"; t[0, 13] = "9"; t[0, 14] = "0"; t[0, 15] = "7";
            t[1, 0] = "0"; t[1, 1] = "F"; t[1, 2] = "7"; t[1, 3] = "4"; t[1, 4] = "E"; t[1, 5] = "2"; t[1, 6] = "D"; t[1, 7] = "1";
            t[1, 8] = "A"; t[1, 9] = "6"; t[1, 10] = "C"; t[1, 11] = "B"; t[1, 12] = "9"; t[1, 13] = "5"; t[1, 14] = "3"; t[1, 15] = "8";
            t[2, 0] = "4"; t[2, 1] = "1"; t[2, 2] = "E"; t[2, 3] = "8"; t[2, 4] = "D"; t[2, 5] = "6"; t[2, 6] = "2"; t[2, 7] = "B";
            t[2, 8] = "F"; t[2, 9] = "C"; t[2, 10] = "9"; t[2, 11] = "7"; t[2, 12] = "3"; t[2, 13] = "A"; t[2, 14] = "5"; t[2, 15] = "0";
            t[3, 0] = "F"; t[3, 1] = "C"; t[3, 2] = "8"; t[3, 3] = "2"; t[3, 4] = "4"; t[3, 5] = "9"; t[3, 6] = "1"; t[3, 7] = "7";
            t[3, 8] = "5"; t[3, 9] = "B"; t[3, 10] = "3"; t[3, 11] = "E"; t[3, 12] = "A"; t[3, 13] = "0"; t[3, 14] = "6"; t[3, 15] = "D";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S2(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "F"; t[0, 1] = "1"; t[0, 2] = "8"; t[0, 3] = "E"; t[0, 4] = "6"; t[0, 5] = "B"; t[0, 6] = "3"; t[0, 7] = "4";
            t[0, 8] = "9"; t[0, 9] = "7"; t[0, 10] = "2"; t[0, 11] = "D"; t[0, 12] = "C"; t[0, 13] = "0"; t[0, 14] = "5"; t[0, 15] = "A";
            t[1, 0] = "3"; t[1, 1] = "D"; t[1, 2] = "4"; t[1, 3] = "7"; t[1, 4] = "F"; t[1, 5] = "2"; t[1, 6] = "8"; t[1, 7] = "E";
            t[1, 8] = "C"; t[1, 9] = "0"; t[1, 10] = "1"; t[1, 11] = "A"; t[1, 12] = "6"; t[1, 13] = "9"; t[1, 14] = "B"; t[1, 15] = "5";
            t[2, 0] = "0"; t[2, 1] = "E"; t[2, 2] = "7"; t[2, 3] = "B"; t[2, 4] = "A"; t[2, 5] = "4"; t[2, 6] = "D"; t[2, 7] = "1";
            t[2, 8] = "5"; t[2, 9] = "8"; t[2, 10] = "C"; t[2, 11] = "6"; t[2, 12] = "9"; t[2, 13] = "3"; t[2, 14] = "2"; t[2, 15] = "F";
            t[3, 0] = "D"; t[3, 1] = "8"; t[3, 2] = "A"; t[3, 3] = "1"; t[3, 4] = "3"; t[3, 5] = "F"; t[3, 6] = "4"; t[3, 7] = "2";
            t[3, 8] = "B"; t[3, 9] = "6"; t[3, 10] = "7"; t[3, 11] = "C"; t[3, 12] = "0"; t[3, 13] = "5"; t[3, 14] = "E"; t[3, 15] = "9";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S3(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "A"; t[0, 1] = "0"; t[0, 2] = "9"; t[0, 3] = "E"; t[0, 4] = "6"; t[0, 5] = "3"; t[0, 6] = "F"; t[0, 7] = "5";
            t[0, 8] = "1"; t[0, 9] = "D"; t[0, 10] = "C"; t[0, 11] = "7"; t[0, 12] = "B"; t[0, 13] = "4"; t[0, 14] = "2"; t[0, 15] = "8";
            t[1, 0] = "D"; t[1, 1] = "7"; t[1, 2] = "0"; t[1, 3] = "9"; t[1, 4] = "3"; t[1, 5] = "4"; t[1, 6] = "6"; t[1, 7] = "A";
            t[1, 8] = "2"; t[1, 9] = "8"; t[1, 10] = "5"; t[1, 11] = "E"; t[1, 12] = "C"; t[1, 13] = "B"; t[1, 14] = "F"; t[1, 15] = "1";
            t[2, 0] = "D"; t[2, 1] = "6"; t[2, 2] = "4"; t[2, 3] = "9"; t[2, 4] = "8"; t[2, 5] = "F"; t[2, 6] = "3"; t[2, 7] = "0";
            t[2, 8] = "B"; t[2, 9] = "1"; t[2, 10] = "2"; t[2, 11] = "C"; t[2, 12] = "5"; t[2, 13] = "A"; t[2, 14] = "E"; t[2, 15] = "7";
            t[3, 0] = "1"; t[3, 1] = "A"; t[3, 2] = "D"; t[3, 3] = "0"; t[3, 4] = "6"; t[3, 5] = "9"; t[3, 6] = "8"; t[3, 7] = "7";
            t[3, 8] = "4"; t[3, 9] = "F"; t[3, 10] = "E"; t[3, 11] = "3"; t[3, 12] = "B"; t[3, 13] = "5"; t[3, 14] = "2"; t[3, 15] = "C";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S4(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "7"; t[0, 1] = "D"; t[0, 2] = "E"; t[0, 3] = "3"; t[0, 4] = "0"; t[0, 5] = "6"; t[0, 6] = "9"; t[0, 7] = "A";
            t[0, 8] = "1"; t[0, 9] = "2"; t[0, 10] = "8"; t[0, 11] = "5"; t[0, 12] = "B"; t[0, 13] = "C"; t[0, 14] = "4"; t[0, 15] = "F";
            t[1, 0] = "D"; t[1, 1] = "8"; t[1, 2] = "B"; t[1, 3] = "5"; t[1, 4] = "6"; t[1, 5] = "F"; t[1, 6] = "0"; t[1, 7] = "3";
            t[1, 8] = "4"; t[1, 9] = "7"; t[1, 10] = "2"; t[1, 11] = "C"; t[1, 12] = "1"; t[1, 13] = "A"; t[1, 14] = "E"; t[1, 15] = "9";
            t[2, 0] = "A"; t[2, 1] = "6"; t[2, 2] = "9"; t[2, 3] = "0"; t[2, 4] = "C"; t[2, 5] = "B"; t[2, 6] = "7"; t[2, 7] = "D";
            t[2, 8] = "F"; t[2, 9] = "1"; t[2, 10] = "3"; t[2, 11] = "E"; t[2, 12] = "5"; t[2, 13] = "2"; t[2, 14] = "8"; t[2, 15] = "4";
            t[3, 0] = "3"; t[3, 1] = "F"; t[3, 2] = "0"; t[3, 3] = "6"; t[3, 4] = "A"; t[3, 5] = "1"; t[3, 6] = "D"; t[3, 7] = "8";
            t[3, 8] = "9"; t[3, 9] = "4"; t[3, 10] = "5"; t[3, 11] = "B"; t[3, 12] = "C"; t[3, 13] = "7"; t[3, 14] = "2"; t[3, 15] = "E";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S5(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "2"; t[0, 1] = "C"; t[0, 2] = "4"; t[0, 3] = "1"; t[0, 4] = "7"; t[0, 5] = "A"; t[0, 6] = "B"; t[0, 7] = "6";
            t[0, 8] = "8"; t[0, 9] = "5"; t[0, 10] = "3"; t[0, 11] = "F"; t[0, 12] = "D"; t[0, 13] = "0"; t[0, 14] = "E"; t[0, 15] = "9";
            t[1, 0] = "E"; t[1, 1] = "B"; t[1, 2] = "2"; t[1, 3] = "C"; t[1, 4] = "4"; t[1, 5] = "7"; t[1, 6] = "D"; t[1, 7] = "1";
            t[1, 8] = "5"; t[1, 9] = "0"; t[1, 10] = "F"; t[1, 11] = "A"; t[1, 12] = "3"; t[1, 13] = "9"; t[1, 14] = "8"; t[1, 15] = "6";
            t[2, 0] = "4"; t[2, 1] = "2"; t[2, 2] = "1"; t[2, 3] = "B"; t[2, 4] = "A"; t[2, 5] = "D"; t[2, 6] = "7"; t[2, 7] = "8";
            t[2, 8] = "F"; t[2, 9] = "9"; t[2, 10] = "C"; t[2, 11] = "5"; t[2, 12] = "6"; t[2, 13] = "3"; t[2, 14] = "0"; t[2, 15] = "E";
            t[3, 0] = "B"; t[3, 1] = "8"; t[3, 2] = "C"; t[3, 3] = "7"; t[3, 4] = "1"; t[3, 5] = "E"; t[3, 6] = "2"; t[3, 7] = "D";
            t[3, 8] = "6"; t[3, 9] = "F"; t[3, 10] = "0"; t[3, 11] = "9"; t[3, 12] = "A"; t[3, 13] = "4"; t[3, 14] = "5"; t[3, 15] = "3";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S6(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "C"; t[0, 1] = "1"; t[0, 2] = "A"; t[0, 3] = "F"; t[0, 4] = "9"; t[0, 5] = "2"; t[0, 6] = "6"; t[0, 7] = "8";
            t[0, 8] = "0"; t[0, 9] = "D"; t[0, 10] = "3"; t[0, 11] = "4"; t[0, 12] = "E"; t[0, 13] = "7"; t[0, 14] = "5"; t[0, 15] = "B";
            t[1, 0] = "A"; t[1, 1] = "F"; t[1, 2] = "4"; t[1, 3] = "2"; t[1, 4] = "7"; t[1, 5] = "C"; t[1, 6] = "9"; t[1, 7] = "5";
            t[1, 8] = "6"; t[1, 9] = "1"; t[1, 10] = "D"; t[1, 11] = "E"; t[1, 12] = "0"; t[1, 13] = "B"; t[1, 14] = "3"; t[1, 15] = "8";
            t[2, 0] = "9"; t[2, 1] = "E"; t[2, 2] = "F"; t[2, 3] = "5"; t[2, 4] = "2"; t[2, 5] = "8"; t[2, 6] = "C"; t[2, 7] = "3";
            t[2, 8] = "7"; t[2, 9] = "0"; t[2, 10] = "4"; t[2, 11] = "A"; t[2, 12] = "1"; t[2, 13] = "D"; t[2, 14] = "B"; t[2, 15] = "6";
            t[3, 0] = "4"; t[3, 1] = "3"; t[3, 2] = "2"; t[3, 3] = "C"; t[3, 4] = "9"; t[3, 5] = "5"; t[3, 6] = "F"; t[3, 7] = "A";
            t[3, 8] = "B"; t[3, 9] = "E"; t[3, 10] = "1"; t[3, 11] = "7"; t[3, 12] = "6"; t[3, 13] = "0"; t[3, 14] = "8"; t[3, 15] = "D";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S7(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "4"; t[0, 1] = "B"; t[0, 2] = "2"; t[0, 3] = "E"; t[0, 4] = "F"; t[0, 5] = "0"; t[0, 6] = "8"; t[0, 7] = "D";
            t[0, 8] = "3"; t[0, 9] = "C"; t[0, 10] = "9"; t[0, 11] = "7"; t[0, 12] = "5"; t[0, 13] = "A"; t[0, 14] = "6"; t[0, 15] = "1";
            t[1, 0] = "D"; t[1, 1] = "0"; t[1, 2] = "B"; t[1, 3] = "7"; t[1, 4] = "4"; t[1, 5] = "9"; t[1, 6] = "1"; t[1, 7] = "A";
            t[1, 8] = "E"; t[1, 9] = "3"; t[1, 10] = "5"; t[1, 11] = "C"; t[1, 12] = "2"; t[1, 13] = "F"; t[1, 14] = "8"; t[1, 15] = "6";
            t[2, 0] = "1"; t[2, 1] = "4"; t[2, 2] = "B"; t[2, 3] = "D"; t[2, 4] = "C"; t[2, 5] = "3"; t[2, 6] = "7"; t[2, 7] = "E";
            t[2, 8] = "A"; t[2, 9] = "F"; t[2, 10] = "6"; t[2, 11] = "8"; t[2, 12] = "0"; t[2, 13] = "5"; t[2, 14] = "9"; t[2, 15] = "2";
            t[3, 0] = "6"; t[3, 1] = "B"; t[3, 2] = "D"; t[3, 3] = "8"; t[3, 4] = "1"; t[3, 5] = "4"; t[3, 6] = "A"; t[3, 7] = "7";
            t[3, 8] = "9"; t[3, 9] = "5"; t[3, 10] = "0"; t[3, 11] = "F"; t[3, 12] = "E"; t[3, 13] = "2"; t[3, 14] = "3"; t[3, 15] = "C";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
        static private string S8(string input)
        {
            string[,] t = new string[4, 16];
            t[0, 0] = "D"; t[0, 1] = "2"; t[0, 2] = "8"; t[0, 3] = "4"; t[0, 4] = "6"; t[0, 5] = "F"; t[0, 6] = "B"; t[0, 7] = "1";
            t[0, 8] = "A"; t[0, 9] = "9"; t[0, 10] = "3"; t[0, 11] = "E"; t[0, 12] = "5"; t[0, 13] = "0"; t[0, 14] = "C"; t[0, 15] = "7";
            t[1, 0] = "1"; t[1, 1] = "F"; t[1, 2] = "D"; t[1, 3] = "8"; t[1, 4] = "A"; t[1, 5] = "3"; t[1, 6] = "7"; t[1, 7] = "4";
            t[1, 8] = "C"; t[1, 9] = "5"; t[1, 10] = "6"; t[1, 11] = "B"; t[1, 12] = "0"; t[1, 13] = "E"; t[1, 14] = "9"; t[1, 15] = "2";
            t[2, 0] = "7"; t[2, 1] = "B"; t[2, 2] = "4"; t[2, 3] = "1"; t[2, 4] = "9"; t[2, 5] = "C"; t[2, 6] = "E"; t[2, 7] = "2";
            t[2, 8] = "0"; t[2, 9] = "6"; t[2, 10] = "A"; t[2, 11] = "D"; t[2, 12] = "F"; t[2, 13] = "3"; t[2, 14] = "5"; t[2, 15] = "8";
            t[3, 0] = "2"; t[3, 1] = "1"; t[3, 2] = "E"; t[3, 3] = "7"; t[3, 4] = "4"; t[3, 5] = "A"; t[3, 6] = "8"; t[3, 7] = "D";
            t[3, 8] = "F"; t[3, 9] = "C"; t[3, 10] = "9"; t[3, 11] = "0"; t[3, 12] = "3"; t[3, 13] = "5"; t[3, 14] = "6"; t[3, 15] = "B";
            int row = BinToDec("" + input[0] + input[5]);
            int col = BinToDec("" + input[1] + input[2] + input[3] + input[4]);
            return HexToBin(t[row, col]);
        }
    }
}
