using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustiermanager
{
    public class Hund : Haustier
    {
      
        private int nummer;



        public Hund(string name, decimal gewicht, int nummer) : base(name, gewicht, "Hund") 
        {
           
            this.Nummer = nummer;
        }

        public int Nummer { get => nummer; set => nummer = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
