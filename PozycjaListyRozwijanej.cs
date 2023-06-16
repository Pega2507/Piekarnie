using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class PozycjaListyRozwijanej
    {
        private Int32 identyfikator = 0;
        public Int32 Identyfikator
        {
            set { this.identyfikator = value; }
            get { return this.identyfikator; }
        }

        private String nazwa = "";
        public String Nazwa
        {
            set { this.nazwa = value; }
            get { return this.nazwa; }
        }

        public PozycjaListyRozwijanej(Int32 id, String name)
        {
            this.Identyfikator = id;
            this.Nazwa = name;
        }



        public override String ToString()
        {
            return this.Nazwa;
        }
    }
}
