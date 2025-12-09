using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDelegateEinführung
{
    class Vorschlaege
    {
        List<string> liste;
        public delegate void VorschlaegeDelegate();
        public VorschlaegeDelegate OnVorschlaegeDelegate = null;
        public delegate void VorschlaegeDoppeltDelegate();
        public VorschlaegeDoppeltDelegate OnVorschlaegeDoppeltDelegate = null;

        public List<string> Liste { get => liste; private set => liste = value; }

        public Vorschlaege()
        {
            liste = new List<string>();
        }
        public void VorschlagAufnehmen(string Vorschlag)
        {
            if (liste.Count != 3)
            {
                liste.Add(Vorschlag);

                foreach(String s in liste)
                {
                    if(s.Equals(Vorschlag))
                    {
                        OnVorschlaegeDoppeltDelegate?.Invoke();
                    }
                }

                
            }
            else
            {
                OnVorschlaegeDelegate?.Invoke();
            }
        }
        public void AlleLoeschen()
        {
            liste.Clear();
        }
    }
}
