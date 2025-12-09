namespace WindowsFormsAppDelegateEinführung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxVorschlag = new System.Windows.Forms.ListBox();
            this.textBoxVorschlag = new System.Windows.Forms.TextBox();
            this.buttonAufnehmen = new System.Windows.Forms.Button();
            this.buttonAlleLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxVorschlag
            // 
            this.listBoxVorschlag.FormattingEnabled = true;
            this.listBoxVorschlag.ItemHeight = 29;
            this.listBoxVorschlag.Location = new System.Drawing.Point(52, 179);
            this.listBoxVorschlag.Name = "listBoxVorschlag";
            this.listBoxVorschlag.Size = new System.Drawing.Size(363, 120);
            this.listBoxVorschlag.TabIndex = 0;
            // 
            // textBoxVorschlag
            // 
            this.textBoxVorschlag.Location = new System.Drawing.Point(52, 91);
            this.textBoxVorschlag.Name = "textBoxVorschlag";
            this.textBoxVorschlag.Size = new System.Drawing.Size(363, 35);
            this.textBoxVorschlag.TabIndex = 1;
            // 
            // buttonAufnehmen
            // 
            this.buttonAufnehmen.Location = new System.Drawing.Point(489, 85);
            this.buttonAufnehmen.Name = "buttonAufnehmen";
            this.buttonAufnehmen.Size = new System.Drawing.Size(266, 46);
            this.buttonAufnehmen.TabIndex = 2;
            this.buttonAufnehmen.Text = "Aufnehmen";
            this.buttonAufnehmen.UseVisualStyleBackColor = true;
            this.buttonAufnehmen.Click += new System.EventHandler(this.buttonAufnehmen_Click);
            // 
            // buttonAlleLoeschen
            // 
            this.buttonAlleLoeschen.Location = new System.Drawing.Point(489, 179);
            this.buttonAlleLoeschen.Name = "buttonAlleLoeschen";
            this.buttonAlleLoeschen.Size = new System.Drawing.Size(266, 122);
            this.buttonAlleLoeschen.TabIndex = 3;
            this.buttonAlleLoeschen.Text = "Alle Löschen";
            this.buttonAlleLoeschen.UseVisualStyleBackColor = true;
            this.buttonAlleLoeschen.Click += new System.EventHandler(this.buttonAlleLoeschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.buttonAlleLoeschen);
            this.Controls.Add(this.buttonAufnehmen);
            this.Controls.Add(this.textBoxVorschlag);
            this.Controls.Add(this.listBoxVorschlag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVorschlag;
        private System.Windows.Forms.TextBox textBoxVorschlag;
        private System.Windows.Forms.Button buttonAufnehmen;
        private System.Windows.Forms.Button buttonAlleLoeschen;
    }
}

