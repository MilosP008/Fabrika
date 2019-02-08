namespace Fabrika
{
    partial class Form1
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
            this.listaSvihVozilaLabel = new System.Windows.Forms.Label();
            this.dodajVoziloDugme = new System.Windows.Forms.Button();
            this.obrisiVoziloDugme = new System.Windows.Forms.Button();
            this.listaVozila = new System.Windows.Forms.ListBox();
            this.dodajVoziloPanel = new System.Windows.Forms.Panel();
            this.validacijaLabel = new System.Windows.Forms.Label();
            this.osobineGroupBox = new System.Windows.Forms.GroupBox();
            this.osobina3CheckBox = new System.Windows.Forms.CheckBox();
            this.osobina3TextBox = new System.Windows.Forms.TextBox();
            this.osobina2TextBox = new System.Windows.Forms.TextBox();
            this.osobina1TextBox = new System.Windows.Forms.TextBox();
            this.osobina3Label = new System.Windows.Forms.Label();
            this.osobina2Label = new System.Windows.Forms.Label();
            this.osobina1Label = new System.Windows.Forms.Label();
            this.vrstaComboBox = new System.Windows.Forms.ComboBox();
            this.vrstaVozilaLabel = new System.Windows.Forms.Label();
            this.markaVozilaLabel = new System.Windows.Forms.Label();
            this.bojaLabel = new System.Windows.Forms.Label();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.bojaTextBox = new System.Windows.Forms.TextBox();
            this.dodajVoziloLabel = new System.Windows.Forms.Label();
            this.otkaziDugme = new System.Windows.Forms.Button();
            this.dodajDugme = new System.Windows.Forms.Button();
            this.izadjiDugme = new System.Windows.Forms.Button();
            this.dodajVoziloPanel.SuspendLayout();
            this.osobineGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaSvihVozilaLabel
            // 
            this.listaSvihVozilaLabel.AutoSize = true;
            this.listaSvihVozilaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaSvihVozilaLabel.Location = new System.Drawing.Point(320, 26);
            this.listaSvihVozilaLabel.Name = "listaSvihVozilaLabel";
            this.listaSvihVozilaLabel.Size = new System.Drawing.Size(178, 29);
            this.listaSvihVozilaLabel.TabIndex = 2;
            this.listaSvihVozilaLabel.Text = "Lista svih vozila";
            // 
            // dodajVoziloDugme
            // 
            this.dodajVoziloDugme.Location = new System.Drawing.Point(713, 415);
            this.dodajVoziloDugme.Name = "dodajVoziloDugme";
            this.dodajVoziloDugme.Size = new System.Drawing.Size(75, 23);
            this.dodajVoziloDugme.TabIndex = 3;
            this.dodajVoziloDugme.Text = "Dodaj vozilo";
            this.dodajVoziloDugme.UseVisualStyleBackColor = true;
            this.dodajVoziloDugme.Click += new System.EventHandler(this.dodajVoziloDugme_Click);
            // 
            // obrisiVoziloDugme
            // 
            this.obrisiVoziloDugme.Location = new System.Drawing.Point(632, 415);
            this.obrisiVoziloDugme.Name = "obrisiVoziloDugme";
            this.obrisiVoziloDugme.Size = new System.Drawing.Size(75, 23);
            this.obrisiVoziloDugme.TabIndex = 4;
            this.obrisiVoziloDugme.Text = "Obrisi vozilo";
            this.obrisiVoziloDugme.UseVisualStyleBackColor = true;
            this.obrisiVoziloDugme.Click += new System.EventHandler(this.obrisiVoziloDugme_Click);
            // 
            // listaVozila
            // 
            this.listaVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaVozila.FormattingEnabled = true;
            this.listaVozila.HorizontalScrollbar = true;
            this.listaVozila.ItemHeight = 20;
            this.listaVozila.Location = new System.Drawing.Point(12, 80);
            this.listaVozila.Name = "listaVozila";
            this.listaVozila.Size = new System.Drawing.Size(776, 324);
            this.listaVozila.TabIndex = 5;
            this.listaVozila.SelectedIndexChanged += new System.EventHandler(this.listaVozila_SelectedIndexChanged);
            // 
            // dodajVoziloPanel
            // 
            this.dodajVoziloPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dodajVoziloPanel.Controls.Add(this.validacijaLabel);
            this.dodajVoziloPanel.Controls.Add(this.osobineGroupBox);
            this.dodajVoziloPanel.Controls.Add(this.vrstaComboBox);
            this.dodajVoziloPanel.Controls.Add(this.vrstaVozilaLabel);
            this.dodajVoziloPanel.Controls.Add(this.markaVozilaLabel);
            this.dodajVoziloPanel.Controls.Add(this.bojaLabel);
            this.dodajVoziloPanel.Controls.Add(this.markaTextBox);
            this.dodajVoziloPanel.Controls.Add(this.bojaTextBox);
            this.dodajVoziloPanel.Controls.Add(this.dodajVoziloLabel);
            this.dodajVoziloPanel.Controls.Add(this.otkaziDugme);
            this.dodajVoziloPanel.Controls.Add(this.dodajDugme);
            this.dodajVoziloPanel.Location = new System.Drawing.Point(100, 58);
            this.dodajVoziloPanel.Name = "dodajVoziloPanel";
            this.dodajVoziloPanel.Size = new System.Drawing.Size(600, 300);
            this.dodajVoziloPanel.TabIndex = 6;
            this.dodajVoziloPanel.Visible = false;
            // 
            // validacijaLabel
            // 
            this.validacijaLabel.AutoSize = true;
            this.validacijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validacijaLabel.ForeColor = System.Drawing.Color.Red;
            this.validacijaLabel.Location = new System.Drawing.Point(20, 210);
            this.validacijaLabel.Name = "validacijaLabel";
            this.validacijaLabel.Size = new System.Drawing.Size(68, 16);
            this.validacijaLabel.TabIndex = 6;
            this.validacijaLabel.Text = "Validacija";
            this.validacijaLabel.Visible = false;
            // 
            // osobineGroupBox
            // 
            this.osobineGroupBox.Controls.Add(this.osobina3CheckBox);
            this.osobineGroupBox.Controls.Add(this.osobina3TextBox);
            this.osobineGroupBox.Controls.Add(this.osobina2TextBox);
            this.osobineGroupBox.Controls.Add(this.osobina1TextBox);
            this.osobineGroupBox.Controls.Add(this.osobina3Label);
            this.osobineGroupBox.Controls.Add(this.osobina2Label);
            this.osobineGroupBox.Controls.Add(this.osobina1Label);
            this.osobineGroupBox.Location = new System.Drawing.Point(320, 80);
            this.osobineGroupBox.Name = "osobineGroupBox";
            this.osobineGroupBox.Size = new System.Drawing.Size(260, 160);
            this.osobineGroupBox.TabIndex = 5;
            this.osobineGroupBox.TabStop = false;
            this.osobineGroupBox.Text = "Osobine vozila";
            this.osobineGroupBox.Enter += new System.EventHandler(this.osobineGroupBox_Enter);
            // 
            // osobina3CheckBox
            // 
            this.osobina3CheckBox.AutoSize = true;
            this.osobina3CheckBox.Location = new System.Drawing.Point(150, 119);
            this.osobina3CheckBox.Name = "osobina3CheckBox";
            this.osobina3CheckBox.Size = new System.Drawing.Size(69, 17);
            this.osobina3CheckBox.TabIndex = 6;
            this.osobina3CheckBox.Text = "osobina3";
            this.osobina3CheckBox.UseVisualStyleBackColor = true;
            this.osobina3CheckBox.Visible = false;
            // 
            // osobina3TextBox
            // 
            this.osobina3TextBox.Location = new System.Drawing.Point(150, 117);
            this.osobina3TextBox.Name = "osobina3TextBox";
            this.osobina3TextBox.Size = new System.Drawing.Size(100, 20);
            this.osobina3TextBox.TabIndex = 1;
            this.osobina3TextBox.Visible = false;
            // 
            // osobina2TextBox
            // 
            this.osobina2TextBox.Location = new System.Drawing.Point(150, 77);
            this.osobina2TextBox.Name = "osobina2TextBox";
            this.osobina2TextBox.Size = new System.Drawing.Size(100, 20);
            this.osobina2TextBox.TabIndex = 1;
            this.osobina2TextBox.Visible = false;
            // 
            // osobina1TextBox
            // 
            this.osobina1TextBox.Location = new System.Drawing.Point(150, 37);
            this.osobina1TextBox.Name = "osobina1TextBox";
            this.osobina1TextBox.Size = new System.Drawing.Size(100, 20);
            this.osobina1TextBox.TabIndex = 1;
            this.osobina1TextBox.Visible = false;
            // 
            // osobina3Label
            // 
            this.osobina3Label.AutoSize = true;
            this.osobina3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.osobina3Label.Location = new System.Drawing.Point(10, 120);
            this.osobina3Label.Name = "osobina3Label";
            this.osobina3Label.Size = new System.Drawing.Size(50, 13);
            this.osobina3Label.TabIndex = 0;
            this.osobina3Label.Text = "osobina3";
            this.osobina3Label.Visible = false;
            // 
            // osobina2Label
            // 
            this.osobina2Label.AutoSize = true;
            this.osobina2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.osobina2Label.Location = new System.Drawing.Point(10, 80);
            this.osobina2Label.Name = "osobina2Label";
            this.osobina2Label.Size = new System.Drawing.Size(50, 13);
            this.osobina2Label.TabIndex = 0;
            this.osobina2Label.Text = "osobina2";
            this.osobina2Label.Visible = false;
            // 
            // osobina1Label
            // 
            this.osobina1Label.AutoSize = true;
            this.osobina1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.osobina1Label.Location = new System.Drawing.Point(10, 40);
            this.osobina1Label.Name = "osobina1Label";
            this.osobina1Label.Size = new System.Drawing.Size(50, 13);
            this.osobina1Label.TabIndex = 0;
            this.osobina1Label.Text = "osobina1";
            this.osobina1Label.Visible = false;
            // 
            // vrstaComboBox
            // 
            this.vrstaComboBox.FormattingEnabled = true;
            this.vrstaComboBox.Items.AddRange(new object[] {
            "Gradski autobus",
            "Medjugradski autobus",
            "Kabriolet automobil",
            "Klasican automobil",
            "Cisterna kamion",
            "Sleper kamion"});
            this.vrstaComboBox.Location = new System.Drawing.Point(170, 81);
            this.vrstaComboBox.Name = "vrstaComboBox";
            this.vrstaComboBox.Size = new System.Drawing.Size(130, 21);
            this.vrstaComboBox.TabIndex = 4;
            this.vrstaComboBox.SelectedIndexChanged += new System.EventHandler(this.vrstaComboBox_SelectedIndexChanged);
            // 
            // vrstaVozilaLabel
            // 
            this.vrstaVozilaLabel.AutoSize = true;
            this.vrstaVozilaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vrstaVozilaLabel.Location = new System.Drawing.Point(20, 80);
            this.vrstaVozilaLabel.Name = "vrstaVozilaLabel";
            this.vrstaVozilaLabel.Size = new System.Drawing.Size(77, 16);
            this.vrstaVozilaLabel.TabIndex = 3;
            this.vrstaVozilaLabel.Text = "Vrsta vozila";
            // 
            // markaVozilaLabel
            // 
            this.markaVozilaLabel.AutoSize = true;
            this.markaVozilaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.markaVozilaLabel.Location = new System.Drawing.Point(20, 120);
            this.markaVozilaLabel.Name = "markaVozilaLabel";
            this.markaVozilaLabel.Size = new System.Drawing.Size(84, 16);
            this.markaVozilaLabel.TabIndex = 3;
            this.markaVozilaLabel.Text = "Marka vozila";
            // 
            // bojaLabel
            // 
            this.bojaLabel.AutoSize = true;
            this.bojaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bojaLabel.Location = new System.Drawing.Point(20, 160);
            this.bojaLabel.Name = "bojaLabel";
            this.bojaLabel.Size = new System.Drawing.Size(74, 16);
            this.bojaLabel.TabIndex = 3;
            this.bojaLabel.Text = "Boja vozila";
            // 
            // markaTextBox
            // 
            this.markaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.markaTextBox.Location = new System.Drawing.Point(170, 121);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(130, 20);
            this.markaTextBox.TabIndex = 2;
            // 
            // bojaTextBox
            // 
            this.bojaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.bojaTextBox.Location = new System.Drawing.Point(170, 161);
            this.bojaTextBox.Name = "bojaTextBox";
            this.bojaTextBox.Size = new System.Drawing.Size(130, 20);
            this.bojaTextBox.TabIndex = 2;
            // 
            // dodajVoziloLabel
            // 
            this.dodajVoziloLabel.AutoSize = true;
            this.dodajVoziloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajVoziloLabel.Location = new System.Drawing.Point(244, 20);
            this.dodajVoziloLabel.Name = "dodajVoziloLabel";
            this.dodajVoziloLabel.Size = new System.Drawing.Size(112, 24);
            this.dodajVoziloLabel.TabIndex = 1;
            this.dodajVoziloLabel.Text = "Dodaj vozilo";
            // 
            // otkaziDugme
            // 
            this.otkaziDugme.Location = new System.Drawing.Point(441, 274);
            this.otkaziDugme.Name = "otkaziDugme";
            this.otkaziDugme.Size = new System.Drawing.Size(75, 23);
            this.otkaziDugme.TabIndex = 0;
            this.otkaziDugme.Text = "Otkazi";
            this.otkaziDugme.UseVisualStyleBackColor = true;
            this.otkaziDugme.Click += new System.EventHandler(this.otkaziDugme_Click);
            // 
            // dodajDugme
            // 
            this.dodajDugme.Location = new System.Drawing.Point(522, 274);
            this.dodajDugme.Name = "dodajDugme";
            this.dodajDugme.Size = new System.Drawing.Size(75, 23);
            this.dodajDugme.TabIndex = 0;
            this.dodajDugme.Text = "Dodaj";
            this.dodajDugme.UseVisualStyleBackColor = true;
            this.dodajDugme.Click += new System.EventHandler(this.dodajDugme_Click);
            // 
            // izadjiDugme
            // 
            this.izadjiDugme.Location = new System.Drawing.Point(12, 415);
            this.izadjiDugme.Name = "izadjiDugme";
            this.izadjiDugme.Size = new System.Drawing.Size(75, 23);
            this.izadjiDugme.TabIndex = 7;
            this.izadjiDugme.Text = "Izadji";
            this.izadjiDugme.UseVisualStyleBackColor = true;
            this.izadjiDugme.Click += new System.EventHandler(this.izadjiDugme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izadjiDugme);
            this.Controls.Add(this.dodajVoziloPanel);
            this.Controls.Add(this.listaVozila);
            this.Controls.Add(this.obrisiVoziloDugme);
            this.Controls.Add(this.dodajVoziloDugme);
            this.Controls.Add(this.listaSvihVozilaLabel);
            this.Name = "Form1";
            this.Text = "Fabrika";
            this.dodajVoziloPanel.ResumeLayout(false);
            this.dodajVoziloPanel.PerformLayout();
            this.osobineGroupBox.ResumeLayout(false);
            this.osobineGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label listaSvihVozilaLabel;
        private System.Windows.Forms.Button dodajVoziloDugme;
        private System.Windows.Forms.Button obrisiVoziloDugme;
        private System.Windows.Forms.ListBox listaVozila;
        private System.Windows.Forms.Panel dodajVoziloPanel;
        private System.Windows.Forms.Button otkaziDugme;
        private System.Windows.Forms.Button dodajDugme;
        private System.Windows.Forms.Button izadjiDugme;
        private System.Windows.Forms.TextBox bojaTextBox;
        private System.Windows.Forms.Label dodajVoziloLabel;
        private System.Windows.Forms.Label vrstaVozilaLabel;
        private System.Windows.Forms.Label markaVozilaLabel;
        private System.Windows.Forms.Label bojaLabel;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.ComboBox vrstaComboBox;
        private System.Windows.Forms.GroupBox osobineGroupBox;
        private System.Windows.Forms.Label osobina1Label;
        private System.Windows.Forms.Label osobina2Label;
        private System.Windows.Forms.Label osobina3Label;
        private System.Windows.Forms.TextBox osobina3TextBox;
        private System.Windows.Forms.TextBox osobina2TextBox;
        private System.Windows.Forms.TextBox osobina1TextBox;
        private System.Windows.Forms.CheckBox osobina3CheckBox;
        private System.Windows.Forms.Label validacijaLabel;
    }
}

