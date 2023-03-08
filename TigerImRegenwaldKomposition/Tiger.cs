using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerImRegenwaldKomposition {
    internal class Tiger {
        private string name;

        public void SetName(string name) {
            this.name = name;
        }
        public string GetName() {
            return this.name;
        }

        public Tiger(string name) {
            this.name=name;
        }

    }
}
