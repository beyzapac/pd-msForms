using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Kesirler
    {

        public int[] Bolme(int pay1, int payda1, int pay2, int payda2)
        {

            int pay = pay1 * payda2;
            int payda = payda1 * pay2;

            return Sadelestir(pay, payda);
        }

        public int[] Carpma(int pay1, int payda1, int pay2, int payda2)
        {

            int pay = pay1 * pay2;
            int payda = payda1 * payda2;

            return Sadelestir(pay, payda);
        }

        public int[] Toplam(int pay1, int payda1, int pay2, int payda2)
        {

            pay1 = pay1 * payda2;
            pay2 = pay2 * payda1;

            pay1 = pay1 + pay2;
            payda1 = payda1 * payda2;

            return Sadelestir(pay1, payda1);
        }

        public int[] Cikar(int pay1, int payda1, int pay2, int payda2)
        {

            pay1 = pay1 * payda2;
            pay2 = pay2 * payda1;

            pay1 = Math.Abs(pay1 - pay2);
            payda1 = payda1 * payda2;

            return Sadelestir(pay1, payda1);
        }

        public int[] Sadelestir(int pay, int payda)
        {
            int[] payPayda = new int[2];

            double mod;
            double payim = 0;
            double paydam = 0;


            if (pay < payda) 
            {
                mod = payda % pay;
                if (mod != 0)
                {
                    payim = pay / mod;
                    paydam = payda / mod;
                }
                else
                {
                    payim = pay / pay;
                    paydam = payda / pay;
                }
            }
            else
            { 
                mod = pay % payda;
                if (mod != 0)
                {
                    payim = pay / mod;
                    paydam = payda / mod;
                }
                else
                { //mod 0 a eþitse
                    payim = pay / payda;
                    payda = 1;
                }

            }


            payPayda[0] = Convert.ToInt32(Math.Floor(payim));
            payPayda[1] = Convert.ToInt32(Math.Floor(paydam));

            return payPayda;
        }
    }
}
