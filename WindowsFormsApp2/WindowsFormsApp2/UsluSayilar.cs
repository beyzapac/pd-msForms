using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class UsluSayilar
    {

        public int UsAl(int taban, int us)
        {
            int result = 1;
            for(int i = 1; i <= us; i++)
            {
                result = result * taban;   
            }

            return result;
        }

        public int[] UsCarp(int taban1, int us1, int taban2, int us2)
        {
            int[] res = new int[2];
            if(taban1 == taban2 && us1 != us2)
            {
                res[0] = taban1;
                res[1] = us1 + us2;
            }else if(taban1 != taban2 && us1 == us2)
            {
                res[0] = taban1 + taban2;
                res[1] = us1;
            }
            else
            {
                res[0] = -1;
                res[1] = -1;
            }

            return res;
        }

        public int[] UsBol(int taban1, int us1, int taban2, int us2)
        {
            int[] res = new int[2];
            if (taban1 == taban2 && us1 != us2)
            {
                res[0] = taban1;
                res[1] = us1 - us2;
            }
            else if (taban1 != taban2 && us1 == us2)
            {
                res[0] = taban1 - taban2;
                res[1] = us1;
            }
            else
            {
                res[0] = -1;
                res[1] = -1;
            }

            return res;
        }

    }
}
