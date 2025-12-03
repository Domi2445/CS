using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustiermanager
{
    public class Haustier
    {
        private string name;
        protected decimal gewicht;
       

        private string art;
        protected int impfungen;

        public Haustier()
        {
            name = "";
            gewicht = 0;
            art = "";
            impfungen = 0;
        }

        public Haustier(string name, decimal gewicht, string art) : this()
        {
            this.name = name;
            this.gewicht = gewicht;
            this.art = art;
            
        }

        public string Name { get => name; set => name = value; }
        public decimal Gewicht { get => gewicht;}
        public string Art { get => art; set => art = value; }
        public int Impfungen { get => impfungen;  }

        public virtual void Impfen()
        {
           impfungen++;
        }
        public virtual void Füttern()
        {
            gewicht *= 1.02m;
        }
        public override string ToString()
        {
            return name;
        }

        
    }
}
