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
            // Prüfen ob Liste voll ist
            if (liste.Count >= 3)
            {
                OnVorschlaegeDelegate?.Invoke();
                
            }

            // Prüfen ob Vorschlag schon existiert
            if (liste.Contains(Vorschlag))
            {
                OnVorschlaegeDoppeltDelegate?.Invoke();
                
            }

            else
            {
                // Vorschlag hinzufügen
                liste.Add(Vorschlag);
            }
        }
        public void AlleLoeschen()
        {
            liste.Clear();
        }
    }
}
