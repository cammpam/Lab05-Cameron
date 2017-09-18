using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Cameron
{
    class Unplugged : Concerts
    {
        public string Location()
        {
            return "Indoors";
        }
        public override string Crowd()
        {
            return "25";
        }
        public override int Performers()
        {
            return base.Performers() + 1;
        }
        public override string Merch()
        {
            return "Meet & Greet";
        }
    }
}
