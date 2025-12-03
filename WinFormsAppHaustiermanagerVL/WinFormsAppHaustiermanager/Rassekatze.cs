using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustiermanager
{
    public class Rassekatze : Katze
    {
        public Rassekatze(string name, decimal gewicht) : base(name, gewicht, "Rassekatze") {}

        public override void Impfen()
        {
            base.Impfen();
            if(impfungen > 3)
            {
                MessageBox.Show("Maximal nur 3 Impfungen erlaubt");
            }
        }

        public override void Füttern()
        {
            gewicht *= 1.03m;
            
        }
    }
}
