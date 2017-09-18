using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Cameron
{
    abstract class Concerts
    {
        protected virtual bool StayOvernight()
        {
            return false;
        }

        public bool Concessions()
        {
            return true;
        }
        public virtual int Performers()
        {
            return 0;
            
        }
        public virtual string Crowd()
        {
            return "";
        }
        public virtual string Merch()
        {
            return "Cds, Shirts, and Socks";
        }
        public virtual string HeadLine()
        {
            return "";
        }
    }
}
