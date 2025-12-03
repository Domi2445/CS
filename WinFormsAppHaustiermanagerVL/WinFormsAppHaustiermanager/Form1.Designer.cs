namespace WinFormsAppHaustiermanager
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
            groupBox1 = new GroupBox();
            buttonNeuesHaustier = new Button();
            textBoxSteuernummer = new TextBox();
            label4 = new Label();
            textBoxGewicht = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            radioButtonRassekatze = new RadioButton();
            radioButtonKatze = new RadioButton();
            radioButtonHund = new RadioButton();
            comboBoxTiere = new ComboBox();
            buttonImpfen = new Button();
            buttonFuettern = new Button();
            buttonShow = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonNeuesHaustier);
            groupBox1.Controls.Add(textBoxSteuernummer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxGewicht);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButtonRassekatze);
            groupBox1.Controls.Add(radioButtonKatze);
            groupBox1.Controls.Add(radioButtonHund);
            groupBox1.Location = new Point(24, 23);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(304, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Haustier";
            // 
            // buttonNeuesHaustier
            // 
            buttonNeuesHaustier.Location = new Point(29, 168);
            buttonNeuesHaustier.Margin = new Padding(1, 1, 1, 1);
            buttonNeuesHaustier.Name = "buttonNeuesHaustier";
            buttonNeuesHaustier.Size = new Size(250, 21);
            buttonNeuesHaustier.TabIndex = 9;
            buttonNeuesHaustier.Text = "Neues Haustier";
            buttonNeuesHaustier.UseVisualStyleBackColor = true;
            buttonNeuesHaustier.Click += buttonNeuesHaustier_Click;
            // 
            // textBoxSteuernummer
            // 
            textBoxSteuernummer.Location = new Point(120, 123);
            textBoxSteuernummer.Margin = new Padding(1, 1, 1, 1);
            textBoxSteuernummer.Name = "textBoxSteuernummer";
            textBoxSteuernummer.Size = new Size(162, 23);
            textBoxSteuernummer.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 123);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Steuernummer";
            // 
            // textBoxGewicht
            // 
            textBoxGewicht.Location = new Point(120, 97);
            textBoxGewicht.Margin = new Padding(1, 1, 1, 1);
            textBoxGewicht.Name = "textBoxGewicht";
            textBoxGewicht.Size = new Size(162, 23);
            textBoxGewicht.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 97);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Gewicht";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(120, 70);
            textBoxName.Margin = new Padding(1, 1, 1, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(162, 23);
            textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 70);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // radioButtonRassekatze
            // 
            radioButtonRassekatze.AutoSize = true;
            radioButtonRassekatze.Location = new Point(163, 33);
            radioButtonRassekatze.Margin = new Padding(1, 1, 1, 1);
            radioButtonRassekatze.Name = "radioButtonRassekatze";
            radioButtonRassekatze.Size = new Size(81, 19);
            radioButtonRassekatze.TabIndex = 2;
            radioButtonRassekatze.TabStop = true;
            radioButtonRassekatze.Text = "Rassekatze";
            radioButtonRassekatze.UseVisualStyleBackColor = true;
            // 
            // radioButtonKatze
            // 
            radioButtonKatze.AutoSize = true;
            radioButtonKatze.Location = new Point(91, 33);
            radioButtonKatze.Margin = new Padding(1, 1, 1, 1);
            radioButtonKatze.Name = "radioButtonKatze";
            radioButtonKatze.Size = new Size(53, 19);
            radioButtonKatze.TabIndex = 1;
            radioButtonKatze.TabStop = true;
            radioButtonKatze.Text = "Katze";
            radioButtonKatze.UseVisualStyleBackColor = true;
            // 
            // radioButtonHund
            // 
            radioButtonHund.AutoSize = true;
            radioButtonHund.Location = new Point(10, 33);
            radioButtonHund.Margin = new Padding(1, 1, 1, 1);
            radioButtonHund.Name = "radioButtonHund";
            radioButtonHund.Size = new Size(55, 19);
            radioButtonHund.TabIndex = 0;
            radioButtonHund.TabStop = true;
            radioButtonHund.Text = "Hund";
            radioButtonHund.UseVisualStyleBackColor = true;
            // 
            // comboBoxTiere
            // 
            comboBoxTiere.FormattingEnabled = true;
            comboBoxTiere.Location = new Point(382, 32);
            comboBoxTiere.Margin = new Padding(1, 1, 1, 1);
            comboBoxTiere.Name = "comboBoxTiere";
            comboBoxTiere.Size = new Size(199, 23);
            comboBoxTiere.TabIndex = 1;
            // 
            // buttonImpfen
            // 
            buttonImpfen.Location = new Point(382, 137);
            buttonImpfen.Margin = new Padding(1, 1, 1, 1);
            buttonImpfen.Name = "buttonImpfen";
            buttonImpfen.Size = new Size(197, 21);
            buttonImpfen.TabIndex = 3;
            buttonImpfen.Text = "Impfen";
            buttonImpfen.UseVisualStyleBackColor = true;
            buttonImpfen.Click += buttonImpfen_Click;
            // 
            // buttonFuettern
            // 
            buttonFuettern.Location = new Point(382, 175);
            buttonFuettern.Margin = new Padding(1, 1, 1, 1);
            buttonFuettern.Name = "buttonFuettern";
            buttonFuettern.Size = new Size(197, 21);
            buttonFuettern.TabIndex = 4;
            buttonFuettern.Text = "Füttern";
            buttonFuettern.UseVisualStyleBackColor = true;
            buttonFuettern.Click += buttonFuettern_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(382, 94);
            buttonShow.Margin = new Padding(1, 1, 1, 1);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(197, 21);
            buttonShow.TabIndex = 5;
            buttonShow.Text = "Anzeigen";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 261);
            Controls.Add(buttonShow);
            Controls.Add(buttonFuettern);
            Controls.Add(buttonImpfen);
            Controls.Add(comboBoxTiere);
            Controls.Add(groupBox1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNeuesHaustier;
        private System.Windows.Forms.TextBox textBoxSteuernummer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGewicht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRassekatze;
        private System.Windows.Forms.RadioButton radioButtonKatze;
        private System.Windows.Forms.RadioButton radioButtonHund;
        private System.Windows.Forms.ComboBox comboBoxTiere;
        private System.Windows.Forms.Button buttonImpfen;
        private System.Windows.Forms.Button buttonFuettern;
        private Button buttonShow;
    }
}
