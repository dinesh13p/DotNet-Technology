using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnettutorials
{
    internal class ImplicitTypeConversions
    {

        public void run() { }

        private void sameTypeExample()
        {
            byte a = 10;

            short b = a;
            int c = a;
            long d = a;
        }

        private void differentTypeExample()
        {
            long a = 10;
            float b = a; //compatible
                         //Char <-> int

            char aa = 'a';
            int bb = aa;

        }
    }
}
