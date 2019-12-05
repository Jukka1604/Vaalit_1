using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vaalit_1
{
    class Program
    {
        static void Main(string[] args)
            
        {

            // lista ehdokkaista
            List<Ehdokas> ehdokkaat = new List<Ehdokas>();


            //luetaan tiedosto
            int counter = 0;
            string line;

            //StreamReader file = new StreamReader(@"M:\Tietorakenteet ja algoritmit\ehdokkaat.txt", System.Text.Encoding.GetEncoding(1252), true);
            StreamReader file = new StreamReader(@"M:\Tietorakenteet ja algoritmit\ehdokkaat.txt", System.Text.Encoding.Default  );

            while ((line=file.ReadLine()) != null)
            {
                //Aino	Ristimäki	SDP	99
                string[] osat=line.Split(); //tekee merkkijonotaulukon

                string en = osat[0];
                string sn = osat[1];
                string puolue = osat[2];
                int aanimaara = int.Parse(osat[3]);

                //Tehdään olio
                Ehdokas e = new Ehdokas(en, sn, puolue, aanimaara);

                // Lisätään olio listaan
                ehdokkaat.Add(e);
                // ehdokkaat.Add(new Ehdokas(en, sn, puolue, aanimaara)); toinen vaihtoehto
                //Console.WriteLine( osat[0] + " " + osat[1]);
                counter++;
            }

            file.Close();

            //  järjestetään lista läpi

            //ehdokkaat.Sort(); Icompa

            ehdokkaat.Sort(VertailuAanimaaranMukaan.AanienMukaan());

            // käydään lista läpi

            foreach (var ehdokas in ehdokkaat)
            {

                Console.WriteLine(ehdokas);

            }

            Console.ReadLine();

        }
    }
}
