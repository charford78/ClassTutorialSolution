using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
    class MathLib
    {
        public MathLib()
        {

        }
        public MathLib(int nbr1)
        {

        }
        public int Mod(int nbr1, int nbr2)
        {
            var rem = 0;
            while (nbr1 - nbr2 > nbr2)
            {
                nbr1 = nbr1 - nbr2;            
            }             
            rem = nbr1 - nbr2;
            
            return rem;
        }
        public int Inc(int nbr1)
        {
            return nbr1 + 1;
        }
        
        public int Add(int nbr1, int nbr2)
        {
            return nbr1 + nbr2;
        }
        public int Sub(int nbr1, int nbr2)
        {
            return nbr1 - nbr2;
        }
        public int Mult(int nbr1, int nbr2)
        {
            return nbr1 * nbr2;
        }
        public int Div(int nbr1, int nbr2)
        {
            return nbr1 / nbr2;
        }
    }
}
