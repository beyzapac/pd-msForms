using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class TemelIslemler
    {
        int[] s;
        List<int> asalSayilar = new List<int>();

        void AsalUret(int sayac)
        {


            for (int sayi = 2; sayi <= sayac; sayi++)
            {
                bool kontrol = false;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = true;
                        break;
                    }
                }

                if (!kontrol)
                {

                    asalSayilar.Add(sayi);
                }
            }
        }

        public string AsalCarpalar(int sayi)
        {
            string result = "";

            int i = 1;
            int bolen = 2;

            while (sayi >= bolen)
            {
                if (sayi % bolen == 0)
                {
                    sayi /= bolen;
                    result += bolen + ", ";
                    i += 1;
                }
                else
                    bolen += 1;
            }

            return result;
        }

        public string Mutlak(int a, int b)
        {
            a = a - b;
            if(a < 0)
            {
                a = a * (-1);
            }
            return a.ToString();
        }

        public string OKEKBEB(int sayi1, int sayi2)
        {

            int OKEK = 0, OBEB = 0, k;

            if (sayi1 < sayi2) { k = sayi2; } else { k = sayi1; }

            for (; k <= sayi1 * sayi2; k++)                      
            {
                if (k % sayi1 == 0 && k % sayi2 == 0)
                {
                    OKEK = k; break;       
                }
            }

            if (sayi1 > sayi2) { k = sayi2; } else { k = sayi1; }   

            for (; k > 0; k--)                
            {
                if (sayi1 % k == 0 && sayi2 % k == 0)
                {
                    OBEB = k; break;        
                }
            }
            return "OBEB = " + OBEB + " - OKEK = " + OKEK;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }










    }
}
