using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ModulerAritmetik
    {

        public int Mod(int x, int mod)
        {
            int i = 1;
            int temp = 0;

            while(mod * i < x)
            {
                i++;
            }

            i = i - 1;

            return x - (mod * i);
        }

    }
}
