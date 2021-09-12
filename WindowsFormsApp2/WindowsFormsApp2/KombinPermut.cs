using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class KombinPermut
    {

        public int Faktoriyel(int n)
        {
            int sonuc = 1;
            while(n >= 1)
            {
                sonuc *= n;
                n--;
            }

            return sonuc;
        }

        public int Kombinasyon(int n, int r)
        {
            return Faktoriyel(n) / (Faktoriyel(n - r) * Faktoriyel(r));
        }

        public int Permutasyon(int n, int r)
        {
            return Faktoriyel(n) / Faktoriyel(n - r);
        }

    }
}
