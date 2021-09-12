using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kesirler kesirler = new Kesirler();
        KombinPermut kp = new KombinPermut();
        IkinciDerecedenDenklemler idd = new IkinciDerecedenDenklemler();
        KokluSayilar ks = new KokluSayilar();
        ModulerAritmetik mod = new ModulerAritmetik();
        OranOranti oo = new OranOranti();
        TemelIslemler ti = new TemelIslemler();
        UsluSayilar us = new UsluSayilar();

        private void button1_Click(object sender, EventArgs e)
        {
            int[] payPayda= kesirler.Carpma(int.Parse(pay1.Text), int.Parse(payda1.Text), int.Parse(pay2.Text), int.Parse(payda2.Text));

            sonucKesir.Text = payPayda[0] + " / " + payPayda[1];
        }

        private void kesirBolme_Click(object sender, EventArgs e)
        {
            int[] payPayda = kesirler.Bolme(int.Parse(pay1.Text), int.Parse(payda1.Text), int.Parse(pay2.Text), int.Parse(payda2.Text));

            sonucKesir.Text = payPayda[0] + " / " + payPayda[1];
        }

        private void kesirCikar_Click(object sender, EventArgs e)
        {
            int[] payPayda = kesirler.Cikar(int.Parse(pay1.Text), int.Parse(payda1.Text), int.Parse(pay2.Text), int.Parse(payda2.Text));

            sonucKesir.Text = payPayda[0] + " / " + payPayda[1];
        }

        private void kesirTopla_Click(object sender, EventArgs e)
        {
            int[] payPayda = kesirler.Toplam(int.Parse(pay1.Text), int.Parse(payda1.Text), int.Parse(pay2.Text), int.Parse(payda2.Text));

            sonucKesir.Text = payPayda[0] + " / " + payPayda[1];
        }

        private void kombBtn_Click(object sender, EventArgs e)
        {
            permKombSonuc.Text = kp.Kombinasyon(int.Parse(komb1Text.Text), int.Parse(komb2Text.Text)).ToString();
        }

        private void permBtn_Click(object sender, EventArgs e)
        {
            permKombSonuc.Text = kp.Permutasyon(int.Parse(permText1.Text), int.Parse(permText2.Text)).ToString();
        }

        private void denklemKokBul_Click(object sender, EventArgs e)
        {
            denklemSonucLbl.Text = idd.KokBul(int.Parse(denklemAText.Text), int.Parse(denklemBText.Text), int.Parse(denklemCtext.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] kokler = ks.KokAl(int.Parse(kokDereceText.Text), int.Parse(kokSayiText.Text));
            kokDisLbl.Text = kokler[0];
            kokDereceLbl.Text = kokler[1];
            kokIcLbl.Text = kokler[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modulerSonuLbl.Text = mod.Mod(int.Parse(modulerXText.Text), int.Parse(modulerMText.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oranOrantiSonucLbl.Text = oo.DogruOran(int.Parse(dogruOTextX1.Text), int.Parse(dogruOTextX2.Text), int.Parse(dogruOTextY1.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oranOrantiSonucLbl.Text = oo.TersOran(int.Parse(tersOTextX1.Text), int.Parse(tersOTextX2.Text), int.Parse(tersOTextY1.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asalCarpanSonucLbl.Text = ti.AsalCarpalar(int.Parse(asalCarpanGirisText.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mutlakSonucLbl.Text = ti.Mutlak(int.Parse(mutlak1Text.Text), int.Parse(mutlak2Text.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            obebSonucLbl.Text = ti.OKEKBEB(int.Parse(obeb1Txt.Text), int.Parse(obeb2Txt.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temelSonucLbl.Text = ti.Topla(int.Parse(temel1Txt.Text), int.Parse(temel2Txt.Text)).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temelSonucLbl.Text = ti.Cikar(int.Parse(temel1Txt.Text), int.Parse(temel2Txt.Text)).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temelSonucLbl.Text = ti.Bol(int.Parse(temel1Txt.Text), int.Parse(temel2Txt.Text)).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temelSonucLbl.Text = ti.Carp(int.Parse(temel1Txt.Text), int.Parse(temel2Txt.Text)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            usluSonuc.Text = us.UsAl(int.Parse(usluTaban.Text), int.Parse(usluUs.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                int pay = int.Parse(Interaction.InputBox("Lütfen kesirin PAY kısmını giriniz..", "Pay", "2"));
                int payda = int.Parse(Interaction.InputBox("Lütfen kesirin PAYDA kısmını giriniz..", "Payda", "4"));
                int[] s = kesirler.Sadelestir(pay, payda);
                sonucKesir.Text = s[0].ToString() + " / " + s[1].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hatalı dönüştürme : Lütfen bir sayı giriniz." + ex.Message);
                
            }

            
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int[] res = us.UsCarp(int.Parse(carpTaban1.Text), int.Parse(carpUs1.Text), int.Parse(carpTaban2.Text), int.Parse(carpUs2.Text));
            if (res[0] == -1 && res[1] == -1)
            {
                usluSonuc.Text = "Değerler çarpmaya uygun değil..";
            }
            else
            {
                usluSonuc.Text = res[0].ToString() + " ^ " + res[1].ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int[] res = us.UsBol(int.Parse(carpTaban1.Text), int.Parse(carpUs1.Text), int.Parse(carpTaban2.Text), int.Parse(carpUs2.Text));
            if (res[0] == -1 && res[1] == -1)
            {
                usluSonuc.Text = "Değerler bölmeye uygun değil..";
            }
            else
            {
                usluSonuc.Text = res[0].ToString() + " ^ " + res[1].ToString();
            }
        }
    }
}
