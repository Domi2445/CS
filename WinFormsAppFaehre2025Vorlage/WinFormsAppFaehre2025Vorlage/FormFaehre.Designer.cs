namespace WinFormsAppFaehre2025Vorlage
{

        partial class FormFaehre
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxLKW = new GroupBox();
            buttonLKWaufnehmen = new Button();
            textBoxLKWPreis = new TextBox();
            textBoxGesamtgewicht = new TextBox();
            labelLKWPreis = new Label();
            labelGesamtgewicht = new Label();
            groupBoxAuto = new GroupBox();
            buttonPKWaufnehmen = new Button();
            textBoxPreisAuto = new TextBox();
            textBoxPersonenanzahl = new TextBox();
            labelPreisAuto = new Label();
            labelPersonenanzahl = new Label();
            groupBoxFahrzeug = new GroupBox();
            textBoxFahrzeugLänge = new TextBox();
            textBoxKennzeichen = new TextBox();
            labelFahrzeugeLänge = new Label();
            labelKennzeichen = new Label();
            textBoxLeergewicht = new TextBox();
            labelLeergewicht = new Label();
            groupBoxFähre = new GroupBox();
            listBoxaufgenommeneFahrzeuge = new ListBox();
            labelaufgenommeneFahrzeuge = new Label();
            textBoxFaehreLaenge = new TextBox();
            labelLänge = new Label();
            textBoxBelegteLaenge = new TextBox();
            labelBelegteBreite = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            groupBoxLKW.SuspendLayout();
            groupBoxAuto.SuspendLayout();
            groupBoxFahrzeug.SuspendLayout();
            groupBoxFähre.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLKW
            // 
            groupBoxLKW.Controls.Add(buttonLKWaufnehmen);
            groupBoxLKW.Controls.Add(textBoxLKWPreis);
            groupBoxLKW.Controls.Add(textBoxGesamtgewicht);
            groupBoxLKW.Controls.Add(labelLKWPreis);
            groupBoxLKW.Controls.Add(labelGesamtgewicht);
            groupBoxLKW.Location = new Point(466, 352);
            groupBoxLKW.Margin = new Padding(4, 4, 4, 4);
            groupBoxLKW.Name = "groupBoxLKW";
            groupBoxLKW.Padding = new Padding(4, 4, 4, 4);
            groupBoxLKW.Size = new Size(393, 157);
            groupBoxLKW.TabIndex = 7;
            groupBoxLKW.TabStop = false;
            groupBoxLKW.Text = "LKW";
            // 
            // buttonLKWaufnehmen
            // 
            buttonLKWaufnehmen.Location = new Point(15, 92);
            buttonLKWaufnehmen.Margin = new Padding(4, 4, 4, 4);
            buttonLKWaufnehmen.Name = "buttonLKWaufnehmen";
            buttonLKWaufnehmen.Size = new Size(365, 41);
            buttonLKWaufnehmen.TabIndex = 23;
            buttonLKWaufnehmen.Text = "LKW aufnehmen";
            buttonLKWaufnehmen.UseVisualStyleBackColor = true;
            buttonLKWaufnehmen.Click += buttonLKWaufnehmen_Click;
            // 
            // textBoxLKWPreis
            // 
            textBoxLKWPreis.Location = new Point(282, 24);
            textBoxLKWPreis.Margin = new Padding(4, 4, 4, 4);
            textBoxLKWPreis.Name = "textBoxLKWPreis";
            textBoxLKWPreis.ReadOnly = true;
            textBoxLKWPreis.Size = new Size(97, 23);
            textBoxLKWPreis.TabIndex = 22;
            // 
            // textBoxGesamtgewicht
            // 
            textBoxGesamtgewicht.Location = new Point(105, 24);
            textBoxGesamtgewicht.Margin = new Padding(4, 4, 4, 4);
            textBoxGesamtgewicht.Name = "textBoxGesamtgewicht";
            textBoxGesamtgewicht.Size = new Size(116, 23);
            textBoxGesamtgewicht.TabIndex = 20;
            // 
            // labelLKWPreis
            // 
            labelLKWPreis.AutoSize = true;
            labelLKWPreis.Location = new Point(240, 34);
            labelLKWPreis.Margin = new Padding(4, 0, 4, 0);
            labelLKWPreis.Name = "labelLKWPreis";
            labelLKWPreis.Size = new Size(32, 15);
            labelLKWPreis.TabIndex = 21;
            labelLKWPreis.Text = "Preis";
            // 
            // labelGesamtgewicht
            // 
            labelGesamtgewicht.AutoSize = true;
            labelGesamtgewicht.Location = new Point(12, 34);
            labelGesamtgewicht.Margin = new Padding(4, 0, 4, 0);
            labelGesamtgewicht.Name = "labelGesamtgewicht";
            labelGesamtgewicht.Size = new Size(89, 15);
            labelGesamtgewicht.TabIndex = 19;
            labelGesamtgewicht.Text = "Gesamtgewicht";
            // 
            // groupBoxAuto
            // 
            groupBoxAuto.Controls.Add(buttonPKWaufnehmen);
            groupBoxAuto.Controls.Add(textBoxPreisAuto);
            groupBoxAuto.Controls.Add(textBoxPersonenanzahl);
            groupBoxAuto.Controls.Add(labelPreisAuto);
            groupBoxAuto.Controls.Add(labelPersonenanzahl);
            groupBoxAuto.Location = new Point(466, 185);
            groupBoxAuto.Margin = new Padding(4, 4, 4, 4);
            groupBoxAuto.Name = "groupBoxAuto";
            groupBoxAuto.Padding = new Padding(4, 4, 4, 4);
            groupBoxAuto.Size = new Size(393, 157);
            groupBoxAuto.TabIndex = 6;
            groupBoxAuto.TabStop = false;
            groupBoxAuto.Text = "Auto";
            // 
            // buttonPKWaufnehmen
            // 
            buttonPKWaufnehmen.Location = new Point(21, 90);
            buttonPKWaufnehmen.Margin = new Padding(4, 4, 4, 4);
            buttonPKWaufnehmen.Name = "buttonPKWaufnehmen";
            buttonPKWaufnehmen.Size = new Size(365, 41);
            buttonPKWaufnehmen.TabIndex = 18;
            buttonPKWaufnehmen.Text = "Auto aufnehmen";
            buttonPKWaufnehmen.UseVisualStyleBackColor = true;
            buttonPKWaufnehmen.Click += buttonPKWaufnehmen_Click;
            // 
            // textBoxPreisAuto
            // 
            textBoxPreisAuto.Location = new Point(288, 22);
            textBoxPreisAuto.Margin = new Padding(4, 4, 4, 4);
            textBoxPreisAuto.Name = "textBoxPreisAuto";
            textBoxPreisAuto.ReadOnly = true;
            textBoxPreisAuto.Size = new Size(97, 23);
            textBoxPreisAuto.TabIndex = 17;
            // 
            // textBoxPersonenanzahl
            // 
            textBoxPersonenanzahl.Location = new Point(111, 22);
            textBoxPersonenanzahl.Margin = new Padding(4, 4, 4, 4);
            textBoxPersonenanzahl.Name = "textBoxPersonenanzahl";
            textBoxPersonenanzahl.Size = new Size(116, 23);
            textBoxPersonenanzahl.TabIndex = 15;
            // 
            // labelPreisAuto
            // 
            labelPreisAuto.AutoSize = true;
            labelPreisAuto.Location = new Point(246, 31);
            labelPreisAuto.Margin = new Padding(4, 0, 4, 0);
            labelPreisAuto.Name = "labelPreisAuto";
            labelPreisAuto.Size = new Size(32, 15);
            labelPreisAuto.TabIndex = 16;
            labelPreisAuto.Text = "Preis";
            // 
            // labelPersonenanzahl
            // 
            labelPersonenanzahl.AutoSize = true;
            labelPersonenanzahl.Location = new Point(18, 31);
            labelPersonenanzahl.Margin = new Padding(4, 0, 4, 0);
            labelPersonenanzahl.Name = "labelPersonenanzahl";
            labelPersonenanzahl.Size = new Size(90, 15);
            labelPersonenanzahl.TabIndex = 14;
            labelPersonenanzahl.Text = "Personenanzahl";
            // 
            // groupBoxFahrzeug
            // 
            groupBoxFahrzeug.Controls.Add(textBoxFahrzeugLänge);
            groupBoxFahrzeug.Controls.Add(textBoxKennzeichen);
            groupBoxFahrzeug.Controls.Add(labelFahrzeugeLänge);
            groupBoxFahrzeug.Controls.Add(labelKennzeichen);
            groupBoxFahrzeug.Controls.Add(textBoxLeergewicht);
            groupBoxFahrzeug.Controls.Add(labelLeergewicht);
            groupBoxFahrzeug.Location = new Point(466, 19);
            groupBoxFahrzeug.Margin = new Padding(4, 4, 4, 4);
            groupBoxFahrzeug.Name = "groupBoxFahrzeug";
            groupBoxFahrzeug.Padding = new Padding(4, 4, 4, 4);
            groupBoxFahrzeug.Size = new Size(393, 157);
            groupBoxFahrzeug.TabIndex = 5;
            groupBoxFahrzeug.TabStop = false;
            groupBoxFahrzeug.Text = "Fahrzeug";
            // 
            // textBoxFahrzeugLänge
            // 
            textBoxFahrzeugLänge.Location = new Point(111, 67);
            textBoxFahrzeugLänge.Margin = new Padding(4, 4, 4, 4);
            textBoxFahrzeugLänge.Name = "textBoxFahrzeugLänge";
            textBoxFahrzeugLänge.Size = new Size(116, 23);
            textBoxFahrzeugLänge.TabIndex = 13;
            // 
            // textBoxKennzeichen
            // 
            textBoxKennzeichen.Location = new Point(111, 22);
            textBoxKennzeichen.Margin = new Padding(4, 4, 4, 4);
            textBoxKennzeichen.Name = "textBoxKennzeichen";
            textBoxKennzeichen.Size = new Size(116, 23);
            textBoxKennzeichen.TabIndex = 9;
            // 
            // labelFahrzeugeLänge
            // 
            labelFahrzeugeLänge.AutoSize = true;
            labelFahrzeugeLänge.Location = new Point(18, 76);
            labelFahrzeugeLänge.Margin = new Padding(4, 0, 4, 0);
            labelFahrzeugeLänge.Name = "labelFahrzeugeLänge";
            labelFahrzeugeLänge.Size = new Size(39, 15);
            labelFahrzeugeLänge.TabIndex = 12;
            labelFahrzeugeLänge.Text = "Länge";
            // 
            // labelKennzeichen
            // 
            labelKennzeichen.AutoSize = true;
            labelKennzeichen.Location = new Point(18, 31);
            labelKennzeichen.Margin = new Padding(4, 0, 4, 0);
            labelKennzeichen.Name = "labelKennzeichen";
            labelKennzeichen.Size = new Size(74, 15);
            labelKennzeichen.TabIndex = 8;
            labelKennzeichen.Text = "Kennzeichen";
            // 
            // textBoxLeergewicht
            // 
            textBoxLeergewicht.Location = new Point(111, 116);
            textBoxLeergewicht.Margin = new Padding(4, 4, 4, 4);
            textBoxLeergewicht.Name = "textBoxLeergewicht";
            textBoxLeergewicht.Size = new Size(116, 23);
            textBoxLeergewicht.TabIndex = 11;
            // 
            // labelLeergewicht
            // 
            labelLeergewicht.AutoSize = true;
            labelLeergewicht.Location = new Point(18, 126);
            labelLeergewicht.Margin = new Padding(4, 0, 4, 0);
            labelLeergewicht.Name = "labelLeergewicht";
            labelLeergewicht.Size = new Size(71, 15);
            labelLeergewicht.TabIndex = 10;
            labelLeergewicht.Text = "Leergewicht";
            // 
            // groupBoxFähre
            // 
            groupBoxFähre.Controls.Add(listBoxaufgenommeneFahrzeuge);
            groupBoxFähre.Controls.Add(labelaufgenommeneFahrzeuge);
            groupBoxFähre.Controls.Add(textBoxFaehreLaenge);
            groupBoxFähre.Controls.Add(labelLänge);
            groupBoxFähre.Controls.Add(textBoxBelegteLaenge);
            groupBoxFähre.Controls.Add(labelBelegteBreite);
            groupBoxFähre.Controls.Add(textBoxName);
            groupBoxFähre.Controls.Add(labelName);
            groupBoxFähre.Location = new Point(16, 19);
            groupBoxFähre.Margin = new Padding(4, 4, 4, 4);
            groupBoxFähre.Name = "groupBoxFähre";
            groupBoxFähre.Padding = new Padding(4, 4, 4, 4);
            groupBoxFähre.Size = new Size(425, 490);
            groupBoxFähre.TabIndex = 4;
            groupBoxFähre.TabStop = false;
            groupBoxFähre.Text = "Fähre";
            // 
            // listBoxaufgenommeneFahrzeuge
            // 
            listBoxaufgenommeneFahrzeuge.FormattingEnabled = true;
            listBoxaufgenommeneFahrzeuge.ItemHeight = 15;
            listBoxaufgenommeneFahrzeuge.Location = new Point(27, 256);
            listBoxaufgenommeneFahrzeuge.Margin = new Padding(4, 4, 4, 4);
            listBoxaufgenommeneFahrzeuge.Name = "listBoxaufgenommeneFahrzeuge";
            listBoxaufgenommeneFahrzeuge.Size = new Size(358, 199);
            listBoxaufgenommeneFahrzeuge.TabIndex = 7;
            // 
            // labelaufgenommeneFahrzeuge
            // 
            labelaufgenommeneFahrzeuge.AutoSize = true;
            labelaufgenommeneFahrzeuge.Location = new Point(23, 236);
            labelaufgenommeneFahrzeuge.Margin = new Padding(4, 0, 4, 0);
            labelaufgenommeneFahrzeuge.Name = "labelaufgenommeneFahrzeuge";
            labelaufgenommeneFahrzeuge.Size = new Size(149, 15);
            labelaufgenommeneFahrzeuge.TabIndex = 6;
            labelaufgenommeneFahrzeuge.Text = "aufgenommene Fahrzeuge";
            // 
            // textBoxFaehreLaenge
            // 
            textBoxFaehreLaenge.Location = new Point(119, 73);
            textBoxFaehreLaenge.Margin = new Padding(4, 4, 4, 4);
            textBoxFaehreLaenge.Name = "textBoxFaehreLaenge";
            textBoxFaehreLaenge.Size = new Size(116, 23);
            textBoxFaehreLaenge.TabIndex = 5;
            // 
            // labelLänge
            // 
            labelLänge.AutoSize = true;
            labelLänge.Location = new Point(20, 82);
            labelLänge.Margin = new Padding(4, 0, 4, 0);
            labelLänge.Name = "labelLänge";
            labelLänge.Size = new Size(39, 15);
            labelLänge.TabIndex = 4;
            labelLänge.Text = "Länge";
            // 
            // textBoxBelegteLaenge
            // 
            textBoxBelegteLaenge.Location = new Point(119, 122);
            textBoxBelegteLaenge.Margin = new Padding(4, 4, 4, 4);
            textBoxBelegteLaenge.Name = "textBoxBelegteLaenge";
            textBoxBelegteLaenge.Size = new Size(116, 23);
            textBoxBelegteLaenge.TabIndex = 3;
            // 
            // labelBelegteBreite
            // 
            labelBelegteBreite.AutoSize = true;
            labelBelegteBreite.Location = new Point(20, 131);
            labelBelegteBreite.Margin = new Padding(4, 0, 4, 0);
            labelBelegteBreite.Name = "labelBelegteBreite";
            labelBelegteBreite.Size = new Size(81, 15);
            labelBelegteBreite.TabIndex = 2;
            labelBelegteBreite.Text = "Belegte Länge";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(119, 28);
            textBoxName.Margin = new Padding(4, 4, 4, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(116, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(20, 37);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // FormFaehre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 538);
            Controls.Add(groupBoxLKW);
            Controls.Add(groupBoxAuto);
            Controls.Add(groupBoxFahrzeug);
            Controls.Add(groupBoxFähre);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormFaehre";
            Text = "Fähre";
            groupBoxLKW.ResumeLayout(false);
            groupBoxLKW.PerformLayout();
            groupBoxAuto.ResumeLayout(false);
            groupBoxAuto.PerformLayout();
            groupBoxFahrzeug.ResumeLayout(false);
            groupBoxFahrzeug.PerformLayout();
            groupBoxFähre.ResumeLayout(false);
            groupBoxFähre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLKW;
            private System.Windows.Forms.Button buttonLKWaufnehmen;
            private System.Windows.Forms.TextBox textBoxLKWPreis;
            private System.Windows.Forms.TextBox textBoxGesamtgewicht;
            private System.Windows.Forms.Label labelLKWPreis;
            private System.Windows.Forms.Label labelGesamtgewicht;
            private System.Windows.Forms.GroupBox groupBoxAuto;
            private System.Windows.Forms.Button buttonPKWaufnehmen;
            private System.Windows.Forms.TextBox textBoxPreisAuto;
            private System.Windows.Forms.TextBox textBoxPersonenanzahl;
            private System.Windows.Forms.Label labelPreisAuto;
            private System.Windows.Forms.Label labelPersonenanzahl;
            private System.Windows.Forms.GroupBox groupBoxFahrzeug;
            private System.Windows.Forms.TextBox textBoxFahrzeugLänge;
            private System.Windows.Forms.TextBox textBoxKennzeichen;
            private System.Windows.Forms.Label labelFahrzeugeLänge;
            private System.Windows.Forms.Label labelKennzeichen;
            private System.Windows.Forms.TextBox textBoxLeergewicht;
            private System.Windows.Forms.Label labelLeergewicht;
            private System.Windows.Forms.GroupBox groupBoxFähre;
            private System.Windows.Forms.ListBox listBoxaufgenommeneFahrzeuge;
            private System.Windows.Forms.Label labelaufgenommeneFahrzeuge;
            private System.Windows.Forms.TextBox textBoxFaehreLaenge;
            private System.Windows.Forms.Label labelLänge;
            private System.Windows.Forms.TextBox textBoxBelegteLaenge;
            private System.Windows.Forms.Label labelBelegteBreite;
            private System.Windows.Forms.TextBox textBoxName;
            private System.Windows.Forms.Label labelName;
        }
    }



