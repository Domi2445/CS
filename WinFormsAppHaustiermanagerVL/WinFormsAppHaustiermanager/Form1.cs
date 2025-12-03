namespace WinFormsAppHaustiermanager
{
    public partial class Form1 : Form
    {
        Manager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new Manager();

        }

        private void buttonNeuesHaustier_Click(object sender, EventArgs e)
        {
            if (radioButtonHund.Checked)
            {
                Haustier haustier = new Hund(textBoxName.Text, Convert.ToDecimal(textBoxGewicht.Text), Convert.ToInt32(textBoxSteuernummer.Text));
                manager.AddHaustier(haustier);
                aktualisieren();
               
            }

            if (radioButtonKatze.Checked)
            {
                Haustier haustier = new Katze(textBoxName.Text, Convert.ToDecimal(textBoxGewicht.Text));
                manager.AddHaustier(haustier);
                aktualisieren();
            }

            if (radioButtonRassekatze.Checked)
            {
                Haustier haustier = new Rassekatze(textBoxName.Text, Convert.ToDecimal(textBoxGewicht.Text));
                manager.AddHaustier(haustier);
                aktualisieren();
            }
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
           Haustier haustier = (Haustier ) comboBoxTiere.SelectedItem;
            textBoxGewicht.Text = haustier.Gewicht.ToString();
            textBoxName.Text = haustier.Name.ToString();

            if (haustier.Art.Equals("Hund"))
            {
                
                radioButtonHund.Checked = true;
                if (haustier is Hund hund) 
                {

                    textBoxSteuernummer.Text = hund.Nummer.ToString();
                }            }

            if(haustier.Art.Equals("Katze"))
            {
                radioButtonKatze.Checked = true;
            }

            if(haustier.Art.Equals("Rassekatze"))
            {
                radioButtonRassekatze.Checked= true;
            }

            

        }

        private void buttonImpfen_Click(object sender, EventArgs e)
        {
            Haustier haustier = (Haustier) comboBoxTiere.SelectedItem;

            if (haustier.Equals("Rassekatze"))
            {
                if (haustier is Rassekatze rassekatze)
                {
                    rassekatze.Impfen();
                }

            }

            else
            {
                haustier.Impfen();
            }
        }

        private void buttonFuettern_Click(object sender, EventArgs e)
        {
            Haustier haustier = (Haustier)comboBoxTiere.SelectedItem;
            if (haustier.Equals("Rassekatze"))
            {
                if (haustier is Rassekatze rassekatze)
                {
                    rassekatze.Füttern();
                    
                }

            }

            else
            {
                haustier.Füttern();
            }

            textBoxGewicht.Text = haustier.Gewicht.ToString();

        }

        private void aktualisieren()
        {
            comboBoxTiere.DataSource = null;
            comboBoxTiere.DataSource = manager.HaustierList;

        }
    }
}
