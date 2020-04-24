using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2c_sharp
{
    class Trapeze : Tetragon
    {
        public bool isTrapeze()
        {
            if (GetSideAB() == GetSideCD())
            
                return true;
            else
                return false;
        }

    }
}
