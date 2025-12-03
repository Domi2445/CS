using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustiermanager
{
    public class Katze : Haustier
    {
        public Katze(string name, decimal gewicht) : base(name, gewicht, "Katze") { }

        public Katze(string name, decimal gewicht, string art) : base(name, gewicht, art) { }
    }
}
