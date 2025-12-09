using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVererbung
{
    internal class Tier
    {
        public string Name { get; set; }

        public Tier(string name)
        {
            Name = name;
            Console.WriteLine($"Tierkonstruktor mit Parameter aufgerufen: {Name}");
        }

        public virtual void Essen()
        {
            Console.WriteLine($"Name {Name} isst gerade");
        }
    }
}
