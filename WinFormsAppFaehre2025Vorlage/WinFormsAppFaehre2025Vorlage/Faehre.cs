using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class Faehre
    {
        private decimal belegteLaenge;
        private decimal grundpreisPKW;
        private decimal grundpreisLKW;
        private decimal maxLaenge;
        private string name;
        private decimal preisProPerson;
        private decimal preisProTonne;
        private List<Fahrzeug> autodeck;


        public decimal BelegteLaenge { get => belegteLaenge; set => belegteLaenge = value; }
        public decimal GrundpreisPKW { get => grundpreisPKW; set => grundpreisPKW = value; }
        public decimal GrundpreisLKW { get => grundpreisLKW; set => grundpreisLKW = value; }
        public decimal MaxLaenge { get => maxLaenge; set => maxLaenge = value; }
        public string Name { get => name; set => name = value; }
        public decimal PreisProPerson { get => preisProPerson; set => preisProPerson = value; }
        public decimal PreisProTonne { get => preisProTonne; set => preisProTonne = value; }
        public List<Fahrzeug> Autodeck { get => autodeck; set => autodeck = value; }

        public Faehre()
        {
            belegteLaenge = 0;
           
          
            autodeck = new List<Fahrzeug>();
        }

        public Faehre(decimal maxLaenge, string name): this()
        {
            this.maxLaenge = maxLaenge;
            this.name = name;
          
        }

        public decimal FahrzeugAufnehmen(Fahrzeug fahrzeug)
        {
            decimal errechneterpreis = 0;
            if((maxLaenge - belegteLaenge) >= (decimal)fahrzeug.Laenge)
            {

                if (fahrzeug.GetType() == typeof(LKW))
                {
                    LKW lKW = (LKW)fahrzeug;
                    errechneterpreis = grundpreisLKW + lKW.Gesamtgewicht / 1000 * preisProTonne;
                }

                else
                {

                    PKW pKW = (PKW)fahrzeug;
                    errechneterpreis = grundpreisPKW + pKW.Personenanzahl * preisProPerson;
                }

                Autodeck.Add(fahrzeug);
                belegteLaenge += fahrzeug.Laenge;

            }
                

            
            return errechneterpreis;
        }


        
    }
}
