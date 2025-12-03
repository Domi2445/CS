using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsAppHaustiermanager
{
    internal class Manager
    {
        List<Haustier> haustierList;

        public Manager()
        {
            haustierList = new List<Haustier>();
        }

        internal List<Haustier> HaustierList { get => haustierList; private set => haustierList = value; }

        public void AddHaustier(Haustier haustier)
        {
            haustierList.Add(haustier);
        }

        //public anzeigen(Haustier haustier)
        //{

        //}

    }
}
