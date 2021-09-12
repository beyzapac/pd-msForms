using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class OranOranti
    {
        public int DogruOran(int x1, int x2, int y1)
        {
            return x2 * y1 / x1;
        }


        public int TersOran(int x1, int x2, int y1)
        {
            return x1 * y1 / x2;
        }
    }
}
