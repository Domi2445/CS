namespace WinFormsAppMitarbeiterzeit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxMitarbeiterzeiten = new ListBox();
            comboBoxProjekte = new ComboBox();
            buttonAuswerten = new Button();
            labelAnzahl = new Label();
            textBoxAuswerten = new TextBox();
            textBoxDurchschnitt = new TextBox();
            buttonDurchschnitt = new Button();
            SuspendLayout();
            // 
            // listBoxMitarbeiterzeiten
            // 
            listBoxMitarbeiterzeiten.FormattingEnabled = true;
            listBoxMitarbeiterzeiten.ItemHeight = 25;
            listBoxMitarbeiterzeiten.Location = new Point(51, 55);
            listBoxMitarbeiterzeiten.Name = "listBoxMitarbeiterzeiten";
            listBoxMitarbeiterzeiten.Size = new Size(609, 204);
            listBoxMitarbeiterzeiten.TabIndex = 0;
            // 
            // comboBoxProjekte
            // 
            comboBoxProjekte.FormattingEnabled = true;
            comboBoxProjekte.Location = new Point(52, 290);
            comboBoxProjekte.Name = "comboBoxProjekte";
            comboBoxProjekte.Size = new Size(260, 33);
            comboBoxProjekte.TabIndex = 1;
            // 
            // buttonAuswerten
            // 
            buttonAuswerten.Location = new Point(336, 288);
            buttonAuswerten.Name = "buttonAuswerten";
            buttonAuswerten.Size = new Size(145, 34);
            buttonAuswerten.TabIndex = 2;
            buttonAuswerten.Text = "Auswerten";
            buttonAuswerten.UseVisualStyleBackColor = true;
            buttonAuswerten.Click += buttonAuswerten_Click;
            // 
            // labelAnzahl
            // 
            labelAnzahl.AutoSize = true;
            labelAnzahl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAnzahl.Location = new Point(706, 65);
            labelAnzahl.Name = "labelAnzahl";
            labelAnzahl.Size = new Size(126, 48);
            labelAnzahl.TabIndex = 3;
            labelAnzahl.Text = "Anzahl";
            // 
            // textBoxAuswerten
            // 
            textBoxAuswerten.Location = new Point(514, 295);
            textBoxAuswerten.Name = "textBoxAuswerten";
            textBoxAuswerten.Size = new Size(150, 31);
            textBoxAuswerten.TabIndex = 4;
            // 
            // textBoxDurchschnitt
            // 
            textBoxDurchschnitt.Location = new Point(514, 347);
            textBoxDurchschnitt.Name = "textBoxDurchschnitt";
            textBoxDurchschnitt.Size = new Size(150, 31);
            textBoxDurchschnitt.TabIndex = 6;
            // 
            // buttonDurchschnitt
            // 
            buttonDurchschnitt.Location = new Point(336, 340);
            buttonDurchschnitt.Name = "buttonDurchschnitt";
            buttonDurchschnitt.Size = new Size(145, 34);
            buttonDurchschnitt.TabIndex = 5;
            buttonDurchschnitt.Text = "Durchschnitt";
            buttonDurchschnitt.UseVisualStyleBackColor = true;
            buttonDurchschnitt.Click += buttonDurchschnitt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 414);
            Controls.Add(textBoxDurchschnitt);
            Controls.Add(buttonDurchschnitt);
            Controls.Add(textBoxAuswerten);
            Controls.Add(labelAnzahl);
            Controls.Add(buttonAuswerten);
            Controls.Add(comboBoxProjekte);
            Controls.Add(listBoxMitarbeiterzeiten);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMitarbeiterzeiten;
        private ComboBox comboBoxProjekte;
        private Button buttonAuswerten;
        private Label labelAnzahl;
        private TextBox textBoxAuswerten;
        private TextBox textBoxDurchschnitt;
        private Button buttonDurchschnitt;
    }
}
