using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Megrendelesek
    {
        private string sorTipus;
        public string SORTIPUS
        {
            get { return sorTipus; }
            set { sorTipus = value; }
        }


        private string datum;
        public string DATUM
        {
            get { return datum; }
            set { datum = value; }
        }

        private int rendelesSzam;
        public int RENDELESSZAM
        {
            get { return rendelesSzam; }
            set { rendelesSzam = value; }
        }

        private string email;
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        private List<Tetel> tetelek;

        public void TetelHozzaad(string kod, int db)
        {
            tetelek.Add(new Tetel(kod,db));
        }
        public Megrendelesek(string datum, int rendelesSzam, string email)
        {
            this.datum = datum;
            this.rendelesSzam = rendelesSzam;
            this.email = email;
            tetelek = new List<Tetel>();
        }
    }
}
