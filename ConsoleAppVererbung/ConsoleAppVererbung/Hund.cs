using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVererbung
{
    internal class Hund : Tier
    {
        public string Rasse { get; set; }
        public Hund(string name, string rasse) : base(name)
        {
            Rasse = rasse;
        }

        public override void Essen()
        {
            Console.WriteLine($"{Name} frisst sein Hundefutter.");
        }
        public void Bellen()
        {
            Console.WriteLine($"{Name} bellt: Wuff!");
        }
    }
}
