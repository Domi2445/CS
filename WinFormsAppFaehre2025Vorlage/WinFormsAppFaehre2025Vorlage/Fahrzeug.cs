using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class Fahrzeug
    {
        private decimal gesamtpreis;
        private string kennzeichen;
        private decimal laenge;
        private int leergewicht;
        private string marke;


        public Fahrzeug( string kennzeichen, decimal laenge, int leergewicht)
        {
           
            this.Kennzeichen = kennzeichen;
            this.Laenge = laenge;
            this.Leergewicht = leergewicht;
            
        }

        public decimal Gesamtpreis { get => gesamtpreis; set => gesamtpreis = value; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public decimal Laenge { get => laenge; set => laenge = value; }
        public int Leergewicht { get => leergewicht; set => leergewicht = value; }
        public string Marke { get => marke; set => marke = value; }

        public override string ToString()
        {
            return  kennzeichen;
        }
    }
}
