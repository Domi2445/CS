using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class LKW : Fahrzeug
    {
        private decimal gesamtgewicht;
        public LKW( string kennzeichen, decimal laenge, int leergewicht, decimal gesamtgewicht) : base(kennzeichen, laenge, leergewicht)
        {
           
            this.Gesamtgewicht = gesamtgewicht;
        }

        public decimal Gesamtgewicht { get => gesamtgewicht; set => gesamtgewicht = value; }

        public override string ToString()
        {
            return base.ToString() + "LKW";
        }
    }
}
