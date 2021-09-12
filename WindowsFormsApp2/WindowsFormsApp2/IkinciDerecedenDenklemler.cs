using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class IkinciDerecedenDenklemler
    {

        public string KokBul(int a, int b, int c)
        {
            int d = (b * b) - (4 * a * c);
            
            double x1, x2;

            if (d > 0)
            {
                x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                return x1.ToString() + " || " + x2.ToString();
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return x1.ToString() + " || " + x2.ToString();
            }
            else
            {
                return "Kök Yok";
            }
        }

    }
}
