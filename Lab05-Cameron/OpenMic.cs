using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Cameron
{
    class OpenMic : Concerts
    {
        public override string Crowd()
        {
            return "Varies based on Venue";
        }
        public override int Performers()
        {
            return base.Performers() + 2;
        }
        protected bool OpenSlots()
        {
            return true;
        }
        public string Location()
        {
            return "Varies";
        }
    }

}
