using System.Drawing;

namespace WinFormsAppFaehre2025Vorlage
{
    public partial class FormFaehre : Form
    {
        Faehre faehre;

        public FormFaehre()
        {
            InitializeComponent();
            faehre = new Faehre(100, "Costa Concordia");
            textBoxName.Text = faehre.Name;
            textBoxFaehreLaenge.Text = faehre.MaxLaenge.ToString();
            textBoxBelegteLaenge.Text = faehre.BelegteLaenge.ToString();
            faehre.PreisProPerson = 5;
            faehre.PreisProPerson = 10;
            faehre.GrundpreisLKW = 100;
            faehre.GrundpreisPKW = 20;
            textBoxKennzeichen.Focus();

        }

        private void buttonPKWaufnehmen_Click(object sender, EventArgs e)
        {

            decimal preis;
            Fahrzeug fahrzeug = new PKW(textBoxKennzeichen.Text, Convert.ToDecimal(textBoxFahrzeugLänge.Text), Convert.ToInt32(textBoxLeergewicht.Text), Convert.ToInt32(textBoxPersonenanzahl.Text));
            preis = faehre.FahrzeugAufnehmen(fahrzeug);
            textBoxPreisAuto.Text = faehre.FahrzeugAufnehmen(fahrzeug).ToString();
            textBoxBelegteLaenge.Text = faehre.BelegteLaenge.ToString();
            ergebnis(preis);
            aktualisieren();

        }

        private void buttonLKWaufnehmen_Click(object sender, EventArgs e)
        {
            decimal preis;

            Fahrzeug fahrzeug = new LKW(textBoxKennzeichen.Text, Convert.ToDecimal(textBoxFahrzeugLänge.Text), Convert.ToInt32(textBoxLeergewicht.Text), Convert.ToDecimal(textBoxGesamtgewicht.Text));
            preis = faehre.FahrzeugAufnehmen(fahrzeug);
            textBoxLKWPreis.Text = faehre.FahrzeugAufnehmen(fahrzeug).ToString();
                textBoxBelegteLaenge.Text = faehre.BelegteLaenge.ToString();
            ergebnis(preis);
                aktualisieren();
            
        }

        private void aktualisieren()
        {
            listBoxaufgenommeneFahrzeuge.DataSource = null;
            listBoxaufgenommeneFahrzeuge.DataSource = faehre.Autodeck;


        }

        private void ergebnis(decimal preis)
        {
            if (preis == 0)
            {
                MessageBox.Show("Fahrzeug konnte nicht aufgenommen werden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }
    }
}
