using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class PKW : Fahrzeug
    {
        private int personenanzahl;
        public PKW( string kennzeichen, decimal laenge, int leergewicht, int personenanzahl) : base( kennzeichen, laenge, leergewicht)
        {
            this.Personenanzahl = personenanzahl;
        }

        public int Personenanzahl { get => personenanzahl; set => personenanzahl = value; }

        public override string ToString()
        {
            return "PKW: " + base.ToString();
        }


    }
}
