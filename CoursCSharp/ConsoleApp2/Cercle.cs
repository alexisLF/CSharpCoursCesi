using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cercle
    {
        int x { get; set; }
        int y { get; set; }

        public Cercle()
        {
            this.x = 9;
            this.y = 8;
        }

        public Cercle (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            string s = "";
            s += "x: " + x + ", y: " + y;
            return s;
        }
    }
}
