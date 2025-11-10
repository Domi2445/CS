using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMitarbeiterzeit
{
    public class Mitarbeiterzeit
    {
        private string mitarbeitername;
        private DateTime datum;
        private double stunden;
        private string projekt;

        public Mitarbeiterzeit(string mitarbeitername, DateTime datum, double stunden, string projekt)
        {
            this.mitarbeitername = mitarbeitername;
            this.datum = datum;
            this.stunden = stunden;
            this.projekt = projekt;
        }

        public string Mitarbeitername { get => mitarbeitername; set => mitarbeitername = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public double Stunden { get => stunden; set => stunden = value; }
        public string Projekt { get => projekt; set => projekt = value; }


    }
}
