using System.Collections.Generic;

namespace WindowsFormsApp2
{
    class KokluSayilar
    {
        string kd;
        string ki;
        string dere;

        public string[] KokAl(int derece, int sayi)
        {
            hesapla(derece, sayi);
            string[] koks = { this.kd, this.dere, this.ki };
            return koks;
        }
        public void hesapla(int derece, int sayi)
        {
            bolenHesapla();
            void bolenHesapla()
            {
                int sayiTutucu = sayi;
                List<int> bolenler = new List<int>();
                while (sayiTutucu > 1)
                {
                    for (int i = 2; i <= sayi; i++)
                    {
                        if (sayiTutucu % i == 0)
                        {
                            bolenler.Add(i);
                            sayiTutucu /= i;
                            break;
                        }
                    }
                }
                frekansHesapla(bolenler);
            }

            void frekansHesapla(List<int> bolenler)
            {

                List<int> temp = bolenler;
                Dictionary<int, int> frekansTablosu = new Dictionary<int, int>();
                List<int> yapilanlar = new List<int>();
                for (int num = 0; num < bolenler.Count; num++)
                {

                    int thisnumber = bolenler[num];
                    if (yapilanlar.Contains(thisnumber) == false)
                    {
                        yapilanlar.Add(thisnumber);
                        int freq = 1;
                        for (int num2 = 0; num2 < temp.Count; num2++)
                        {
                            if (num != num2)
                            {
                                if (thisnumber == temp[num2] && temp[num2] != 0)
                                {
                                    freq++;
                                    temp[num2] = 0;
                                }
                            }
                        }
                        if (bolenler[num] != 0)
                            frekansTablosu.Add(bolenler[num], freq);

                    }
                }
                kokHesapla(frekansTablosu);
            }

            void kokHesapla(Dictionary<int, int> frekansTablo)
            {
                int kokici = 1;
                int kokdisi = 1;
                foreach (KeyValuePair<int, int> pair in frekansTablo)
                {
                    int bolum = pair.Value / derece;
                    int kdis = 1;
                    if (bolum > 0)
                    {
                        kdis = usdondur(pair.Key, bolum);
                    }

                    int moddeger = pair.Value % derece;
                    int kic = 1;
                    if (moddeger > 0)
                    {
                        kic = usdondur(pair.Key, moddeger);
                    }


                    if (kdis <= 0) { kdis = 1; }

                    kokdisi *= kdis;
                    if (kic > 0)
                    {
                        kokici *= kic;
                    }
                }
                sonucVer(kokdisi, kokici);
            }
            void sonucVer(int kokdisi, int kokici)
            {
                this.dere = derece.ToString();
                if (kokici == 1)
                {
                    this.ki = "";
                    this.kd = kokdisi.ToString();
                }
                else
                {
                    if (kokdisi == 1)
                    {
                        this.kd = "";
                        this.ki = kokici.ToString();
                    }
                    else
                    {
                        this.kd = kokdisi.ToString();
                        this.ki = kokici.ToString();
                    }
                }
            }
        }

        //kullanılan bir void:
        int usdondur(int taban, int kuvvet)
        {
            int dondurulecek = taban;
            for (int i = 1; i < kuvvet; i++)
            {
                dondurulecek *= taban;
            }
            return dondurulecek;
        }
    }
}
