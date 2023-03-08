using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TigerImRegenwaldKomposition {
    internal class Regenwald {
        private int pos = 0;
        private Tiger[] unsereTiger = new Tiger[4];

        public Tiger[] GetTiger() { 
            return unsereTiger;
        }

        public void SetTiger(Tiger t) {
            if ( pos < 5 ) {
                unsereTiger[pos] = t;
                pos++;
            }
        }

    }
}
