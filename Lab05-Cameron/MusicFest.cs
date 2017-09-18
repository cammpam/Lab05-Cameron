using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Cameron
{
    class MusicFest : Concerts
    {
        public string Location()
        {
            return "Outdoors";
        }
        public override string Crowd()
        {
            return "Over 3000";
        }
        protected override bool StayOvernight()
        {
            return true;
        }
        public override int Performers()
        {
            return base.Performers() + 25;
        }
        public override string Merch()
        {
            return "Cds, Shirts, Photos, and Meet & Greet";
        }

    }
}
