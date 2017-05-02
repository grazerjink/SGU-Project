using System;
using System.IO;


/* cach mã hóa: kí tự trùng thi thêm x ở phia sau
                neu chuoi lẻ se k ma hoa ki tu o cuối
                neu la ki tu i se them ki tu x dang sau no
                neu la ki tu j se them ki tu z dang sau no*/
namespace BTNHOM
{
    public class MaHoaPlayFair
    {
        char[,] a = new char[5, 5];
        string key;
        string banro;

        private void docFile(out string banro, out string key)
        {
            StreamReader file = new StreamReader("../../../PLAYFAIR.txt");
            banro = file.ReadLine();
            key = file.ReadLine();
            file.Close();
        }

        public void tienHanhMaHoa()
        {
            docFile(out banro, out key);
            Console.WriteLine(" ======== MA HOA VA GIAI MA PLAY FAIR TU FILE ========\n");
            Console.WriteLine(" Ban ro : {0}\n",banro);
            Console.WriteLine(" Khoa : {0}\n", key);
            taobang();
            Console.WriteLine(" \n---------------------------------------------------\n");
            Console.WriteLine(" Chuoi ma hoa : {0}\n", mahoa(banro));
            Console.WriteLine(" Chuoi giai ma : {0}\n", giaima(mahoa(banro)));
        }

        void xuatmang()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a[i, j] == '*') Console.Write("i/j ");
                    else
                        Console.Write(" {0}  ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        bool ktrakitu(char i)// kiem tra xem ki tu do co trong khoa hay k de ko them vao mang nua
        {
            if ((i == 'i' || i == 'j') && key.IndexOf('*') >= 0) return true;
            if (key.IndexOf(i) >= 0) return true;
            else return false;
        }
        void keytoiuu()
        {
            docFile(out banro, out key);
            string s = "";
            key = key.Replace('i', '*'); key = key.Replace('j', '*');
            for (int i = 0; i < key.Length; i++)
            {

                if (s.IndexOf(key[i]) >= 0) continue;
                else s = s + key[i];
            }

            key = s;
            //Console.WriteLine(key);
        }
        void taobang()
        {
            int dong = 0, cot = 0;
            keytoiuu();
            //key lam ki tu dau tien
            foreach (var i in key)
            {
                a[dong, cot] = i;
                if (cot == 4) { dong++; cot = 0; }
                else cot++;
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (ktrakitu(i)) continue;// chac chan se bo qua truong hop ca i va j co trong key
                                          //neu i,j k co trong key
                else if (i == 'i') { i = 'j'; a[dong, cot] = '*'; }
                else a[dong, cot] = i;
                if (cot == 4) { dong++; cot = 0; }
                else cot++;

            }
            xuatmang();
        }
        void timvitri(ref int x, ref int y, char value)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (a[i, j] == value)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                    else if ((value == 'i' || value == 'j') && a[i, j] == '*')
                    {
                        x = i;
                        y = j;
                        break;
                    }
            }
        }
        string tachchuoi(string chuoi)
        {
            int n = chuoi.Length;
            int i = 0;
            while (i < n)
            {
                if (i == n - 1) break;
                if (chuoi[i] == chuoi[i + 1]) chuoi = chuoi.Insert(i + 1, "x");
                i += 2;
                n = chuoi.Length;
            }
            return chuoi;
        }
        string kiemtraij(char mahoa, char chuoi)
        {
            if (chuoi == 'i') return mahoa.ToString() + '1';
            else if (chuoi == 'j') return mahoa.ToString() + '2';
            return mahoa.ToString();
        }
        public string mahoa(string chuoi)
        {

            int d1 = 0, c1 = 0, d2 = 0, c2 = 0;// k gan =0 se bi loi use of unassgined local variable
            string s = "";
            chuoi = tachchuoi(chuoi);
            //Console.WriteLine("tach chuoi {0}", chuoi);
            int n;
            if (chuoi.Length % 2 == 0) n = chuoi.Length;
            else n = chuoi.Length - 1;
            for (int i = 0; i < n; i += 2)
            {
                timvitri(ref d1, ref c1, chuoi[i]); //Console.WriteLine("{0},{1}", d1, c1);
                timvitri(ref d2, ref c2, chuoi[i + 1]); //Console.WriteLine("{0},{1}", d2, c2);
                if (d1 == d2)
                {
                    if (c1 == 4) c1 = 0; else c1++;
                    if (c2 == 4) c2 = 0; else c2++;
                    s = s + kiemtraij(a[d1, c1], chuoi[i]) + kiemtraij(a[d2, c2], chuoi[i + 1]);
                }
                else if (c1 == c2)
                {
                    if (d1 == 4) d1 = 0; else d1++;
                    if (d2 == 4) d2 = 0; else d2++;
                    s = s + kiemtraij(a[d1, c1], chuoi[i]) + kiemtraij(a[d2, c2], chuoi[i + 1]);
                }
                else
                {
                    s = s + kiemtraij(a[d1, c2], chuoi[i]) + kiemtraij(a[d2, c1], chuoi[i + 1]); // lay cung dong nen thay cot la xong
                }
            }
            if (chuoi.Length % 2 != 0) s = s + chuoi[chuoi.Length - 1];
            string s2 = "";
            foreach (var i in s)
            {
                if (i == '*') s2 = s2 + "i";
                else s2 = s2 + i;
            }
            //Console.WriteLine(s2);
            return s2;
        }
        public string giaima(string chuoi)
        {
            bool flag = true;//danh dau ki tu dau tien la i hoac j de bo wa ki tu ke ben cua no
            string s = "";
            int d1 = 0, c1 = 0, d2 = 0, c2 = 0;
            int n;
            char kt1, kt2;
            n = chuoi.Length;

            for (int i = 0; i < n; i += 2)
            {
                if (i == n - 1) { s = s + chuoi[n - 1]; break; }//neu la ki tu cuoi se ko xet nua de tranh truong hop thêm ki tu sau i,j chuỗi se bi dien đổi chieu dài chẵn lẻ
                timvitri(ref d1, ref c1, chuoi[i]);
                if (chuoi[i + 1] == '1' || chuoi[i + 1] == '2') timvitri(ref d2, ref c2, chuoi[i + 2]);
                else timvitri(ref d2, ref c2, chuoi[i + 1]);
                //Console.WriteLine("{0},{1}", d1, c1);
                //Console.WriteLine("{0},{1}", d2, c2);
                if (d1 == d2)
                {
                    if (c1 == 0) c1 = 4; else c1--;
                    if (c2 == 0) c2 = 4; else c2--;

                    kt1 = a[d1, c1]; kt2 = a[d2, c2];
                }
                else if (c1 == c2)
                {
                    if (d1 == 0) d1 = 4; else d1--;
                    if (d2 == 0) d2 = 4; else d2--;
                    kt1 = a[d1, c1]; kt2 = a[d2, c2];
                }
                else
                {
                    kt1 = a[d1, c2]; kt2 = a[d2, c1]; // lay cung dong nen thay cot la xong
                }
                if (kt1 == '*')
                {
                    if (flag)
                    {
                        if (chuoi[i + 1] == '1') s = s + "i" + kt2;
                        else s = s + "j" + kt2;
                        i++;

                    }
                    else { flag = true; i = i - 2; }
                }
                else if (kt2 == '*')
                {
                    if (chuoi[i + 2] == '1') s = s + kt1 + "i";//vi la kt2 nen vi tri phai +them 1 vi i dang ở kt1
                    else s = s + kt1 + "j";
                    i++;
                }
                else s = s + kt1 + kt2;
                //Console.WriteLine("{0},{1}", kt1, kt2);
                //Console.WriteLine(i);
            }
            return s;
        }
    }
}
