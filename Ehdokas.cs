using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaalit_1
{
    class Ehdokas : IComparable<Ehdokas> 

        //icomparable vaikuuttaa sort-komentoon / CompareTo

    {

        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Puolue { get; set; }
        public int Aanimaara { get; set; }
        public double Vertailuluku { get; set; }

        public Ehdokas(string en, string sn, string puolue, int aanimaara)
        {

            this.Etunimi = en;
            this.Sukunimi = sn;
            this.Puolue = puolue;
            this.Aanimaara = aanimaara;

        }

        public int CompareTo(Ehdokas other)
        {

            // return this.Aanimaara-other.Aanimaara;   //jos oltaisiin vain äänimäärä nmukaan lajiteltu
            return other.Aanimaara - this.Aanimaara;   //jos oltaisiin vain äänimäärä nmukaan lajiteltu
            /*int ret=this.Sukunimi.CompareTo(other.Sukunimi);

            if (ret == 0)
                ret = this.Etunimi.CompareTo(other.Etunimi); 

            return ret;*/


        }

        public override string ToString()

        {

            return this.Sukunimi + " " + this.Etunimi + " " + this.Puolue + " " + this.Aanimaara + " " + this.Vertailuluku;

        }

        
    }
}
