namespace ICT4Events_S24_Groep_E
{
    partial class InschrijfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InschrijfForm));
            this.cbMeerderePersonen = new System.Windows.Forms.ComboBox();
            this.chbMeerPersonen = new System.Windows.Forms.CheckBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.gbGegevens = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.btnMaakBezoeker = new System.Windows.Forms.Button();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblGebDatum = new System.Windows.Forms.Label();
            this.lblTelefoon = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblStad = new System.Windows.Forms.Label();
            this.lblHuisnummer = new System.Windows.Forms.Label();
            this.lblRekNummer = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.dtpGebDatum = new System.Windows.Forms.DateTimePicker();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbTelefoon = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbStad = new System.Windows.Forms.TextBox();
            this.tbHuisnummer = new System.Windows.Forms.TextBox();
            this.tbRekNr = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnVerwijderPlaats = new System.Windows.Forms.Button();
            this.btnVoegPlaatsToe = new System.Windows.Forms.Button();
            this.lbPlaatsen = new System.Windows.Forms.ListBox();
            this.cbPlaats = new System.Windows.Forms.ComboBox();
            this.lblPlaats = new System.Windows.Forms.Label();
            this.btnMateriaalHuren = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbPlaatsen = new System.Windows.Forms.GroupBox();
            this.gbGegevens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPlaatsen.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMeerderePersonen
            // 
            this.cbMeerderePersonen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeerderePersonen.Enabled = false;
            this.cbMeerderePersonen.FormattingEnabled = true;
            this.cbMeerderePersonen.Location = new System.Drawing.Point(180, 665);
            this.cbMeerderePersonen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMeerderePersonen.Name = "cbMeerderePersonen";
            this.cbMeerderePersonen.Size = new System.Drawing.Size(65, 24);
            this.cbMeerderePersonen.TabIndex = 30;
            // 
            // chbMeerPersonen
            // 
            this.chbMeerPersonen.AutoSize = true;
            this.chbMeerPersonen.Location = new System.Drawing.Point(23, 665);
            this.chbMeerPersonen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMeerPersonen.Name = "chbMeerPersonen";
            this.chbMeerPersonen.Size = new System.Drawing.Size(151, 21);
            this.chbMeerPersonen.TabIndex = 29;
            this.chbMeerPersonen.Text = "Meedere Personen";
            this.chbMeerPersonen.UseVisualStyleBackColor = true;
            this.chbMeerPersonen.CheckedChanged += new System.EventHandler(this.chbMeerPersonen_CheckedChanged);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(299, 694);
            this.btnAnnuleren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(97, 39);
            this.btnAnnuleren.TabIndex = 33;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // gbGegevens
            // 
            this.gbGegevens.Controls.Add(this.label1);
            this.gbGegevens.Controls.Add(this.label2);
            this.gbGegevens.Controls.Add(this.tbWachtwoord);
            this.gbGegevens.Controls.Add(this.tbGebruikersnaam);
            this.gbGegevens.Controls.Add(this.btnMaakBezoeker);
            this.gbGegevens.Controls.Add(this.lblAchternaam);
            this.gbGegevens.Controls.Add(this.lblGebDatum);
            this.gbGegevens.Controls.Add(this.lblTelefoon);
            this.gbGegevens.Controls.Add(this.lblPostcode);
            this.gbGegevens.Controls.Add(this.lblStad);
            this.gbGegevens.Controls.Add(this.lblHuisnummer);
            this.gbGegevens.Controls.Add(this.lblRekNummer);
            this.gbGegevens.Controls.Add(this.lblNaam);
            this.gbGegevens.Controls.Add(this.dtpGebDatum);
            this.gbGegevens.Controls.Add(this.tbAchternaam);
            this.gbGegevens.Controls.Add(this.tbTelefoon);
            this.gbGegevens.Controls.Add(this.tbPostcode);
            this.gbGegevens.Controls.Add(this.tbStad);
            this.gbGegevens.Controls.Add(this.tbHuisnummer);
            this.gbGegevens.Controls.Add(this.tbRekNr);
            this.gbGegevens.Controls.Add(this.tbNaam);
            this.gbGegevens.Location = new System.Drawing.Point(12, 12);
            this.gbGegevens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGegevens.Name = "gbGegevens";
            this.gbGegevens.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGegevens.Size = new System.Drawing.Size(411, 374);
            this.gbGegevens.TabIndex = 28;
            this.gbGegevens.TabStop = false;
            this.gbGegevens.Text = "Gegevens:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Wachtwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Gebruikersnaam:";
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(136, 114);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(248, 22);
            this.tbWachtwoord.TabIndex = 32;
            this.tbWachtwoord.Text = "tieper200";
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(136, 86);
            this.tbGebruikersnaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(248, 22);
            this.tbGebruikersnaam.TabIndex = 31;
            this.tbGebruikersnaam.Text = "Pietertje102";
            // 
            // btnMaakBezoeker
            // 
            this.btnMaakBezoeker.Location = new System.Drawing.Point(255, 324);
            this.btnMaakBezoeker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaakBezoeker.Name = "btnMaakBezoeker";
            this.btnMaakBezoeker.Size = new System.Drawing.Size(129, 43);
            this.btnMaakBezoeker.TabIndex = 30;
            this.btnMaakBezoeker.Text = "Maak Bezoeker";
            this.btnMaakBezoeker.UseVisualStyleBackColor = true;
            this.btnMaakBezoeker.Click += new System.EventHandler(this.btnMaakBezoeker_Click);
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(7, 64);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(88, 17);
            this.lblAchternaam.TabIndex = 17;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblGebDatum
            // 
            this.lblGebDatum.AutoSize = true;
            this.lblGebDatum.Location = new System.Drawing.Point(7, 150);
            this.lblGebDatum.Name = "lblGebDatum";
            this.lblGebDatum.Size = new System.Drawing.Size(111, 17);
            this.lblGebDatum.TabIndex = 16;
            this.lblGebDatum.Text = "Geboortedatum:";
            // 
            // lblTelefoon
            // 
            this.lblTelefoon.AutoSize = true;
            this.lblTelefoon.Location = new System.Drawing.Point(7, 176);
            this.lblTelefoon.Name = "lblTelefoon";
            this.lblTelefoon.Size = new System.Drawing.Size(68, 17);
            this.lblTelefoon.TabIndex = 15;
            this.lblTelefoon.Text = "Telefoon:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(7, 204);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(71, 17);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblStad
            // 
            this.lblStad.AutoSize = true;
            this.lblStad.Location = new System.Drawing.Point(7, 231);
            this.lblStad.Name = "lblStad";
            this.lblStad.Size = new System.Drawing.Size(41, 17);
            this.lblStad.TabIndex = 13;
            this.lblStad.Text = "Stad:";
            // 
            // lblHuisnummer
            // 
            this.lblHuisnummer.AutoSize = true;
            this.lblHuisnummer.Location = new System.Drawing.Point(7, 260);
            this.lblHuisnummer.Name = "lblHuisnummer";
            this.lblHuisnummer.Size = new System.Drawing.Size(91, 17);
            this.lblHuisnummer.TabIndex = 12;
            this.lblHuisnummer.Text = "Huisnummer:";
            // 
            // lblRekNummer
            // 
            this.lblRekNummer.AutoSize = true;
            this.lblRekNummer.Location = new System.Drawing.Point(7, 288);
            this.lblRekNummer.Name = "lblRekNummer";
            this.lblRekNummer.Size = new System.Drawing.Size(60, 17);
            this.lblRekNummer.TabIndex = 11;
            this.lblRekNummer.Text = "Rek. Nr.";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(7, 33);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 10;
            this.lblNaam.Text = "Naam:";
            // 
            // dtpGebDatum
            // 
            this.dtpGebDatum.Location = new System.Drawing.Point(136, 142);
            this.dtpGebDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpGebDatum.Name = "dtpGebDatum";
            this.dtpGebDatum.Size = new System.Drawing.Size(248, 22);
            this.dtpGebDatum.TabIndex = 9;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(136, 58);
            this.tbAchternaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(248, 22);
            this.tbAchternaam.TabIndex = 8;
            this.tbAchternaam.Text = "Halal";
            // 
            // tbTelefoon
            // 
            this.tbTelefoon.Location = new System.Drawing.Point(136, 170);
            this.tbTelefoon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefoon.Name = "tbTelefoon";
            this.tbTelefoon.Size = new System.Drawing.Size(248, 22);
            this.tbTelefoon.TabIndex = 7;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(136, 198);
            this.tbPostcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(248, 22);
            this.tbPostcode.TabIndex = 6;
            // 
            // tbStad
            // 
            this.tbStad.Location = new System.Drawing.Point(136, 226);
            this.tbStad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStad.Name = "tbStad";
            this.tbStad.Size = new System.Drawing.Size(248, 22);
            this.tbStad.TabIndex = 5;
            // 
            // tbHuisnummer
            // 
            this.tbHuisnummer.Location = new System.Drawing.Point(136, 254);
            this.tbHuisnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHuisnummer.Name = "tbHuisnummer";
            this.tbHuisnummer.Size = new System.Drawing.Size(248, 22);
            this.tbHuisnummer.TabIndex = 4;
            // 
            // tbRekNr
            // 
            this.tbRekNr.Location = new System.Drawing.Point(136, 282);
            this.tbRekNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRekNr.Name = "tbRekNr";
            this.tbRekNr.Size = new System.Drawing.Size(248, 22);
            this.tbRekNr.TabIndex = 3;
            this.tbRekNr.Text = "1829938";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(136, 30);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(248, 22);
            this.tbNaam.TabIndex = 0;
            this.tbNaam.Text = "Pieter";
            // 
            // btnVerwijderPlaats
            // 
            this.btnVerwijderPlaats.Location = new System.Drawing.Point(251, 76);
            this.btnVerwijderPlaats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijderPlaats.Name = "btnVerwijderPlaats";
            this.btnVerwijderPlaats.Size = new System.Drawing.Size(144, 50);
            this.btnVerwijderPlaats.TabIndex = 22;
            this.btnVerwijderPlaats.Text = "Verwijder Plaats";
            this.btnVerwijderPlaats.UseVisualStyleBackColor = true;
            this.btnVerwijderPlaats.Click += new System.EventHandler(this.btnVerwijderPlaats_Click);
            // 
            // btnVoegPlaatsToe
            // 
            this.btnVoegPlaatsToe.Location = new System.Drawing.Point(107, 76);
            this.btnVoegPlaatsToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoegPlaatsToe.Name = "btnVoegPlaatsToe";
            this.btnVoegPlaatsToe.Size = new System.Drawing.Size(139, 50);
            this.btnVoegPlaatsToe.TabIndex = 21;
            this.btnVoegPlaatsToe.Text = "Voeg Plaats Toe";
            this.btnVoegPlaatsToe.UseVisualStyleBackColor = true;
            this.btnVoegPlaatsToe.Click += new System.EventHandler(this.btnVoegPlaatsToe_Click);
            // 
            // lbPlaatsen
            // 
            this.lbPlaatsen.FormattingEnabled = true;
            this.lbPlaatsen.ItemHeight = 16;
            this.lbPlaatsen.Location = new System.Drawing.Point(20, 132);
            this.lbPlaatsen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPlaatsen.Name = "lbPlaatsen";
            this.lbPlaatsen.Size = new System.Drawing.Size(375, 84);
            this.lbPlaatsen.TabIndex = 20;
            // 
            // cbPlaats
            // 
            this.cbPlaats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaats.FormattingEnabled = true;
            this.cbPlaats.Location = new System.Drawing.Point(147, 46);
            this.cbPlaats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPlaats.Name = "cbPlaats";
            this.cbPlaats.Size = new System.Drawing.Size(248, 24);
            this.cbPlaats.TabIndex = 19;
            // 
            // lblPlaats
            // 
            this.lblPlaats.AutoSize = true;
            this.lblPlaats.Location = new System.Drawing.Point(17, 49);
            this.lblPlaats.Name = "lblPlaats";
            this.lblPlaats.Size = new System.Drawing.Size(51, 17);
            this.lblPlaats.TabIndex = 18;
            this.lblPlaats.Text = "Plaats:";
            // 
            // btnMateriaalHuren
            // 
            this.btnMateriaalHuren.Location = new System.Drawing.Point(148, 694);
            this.btnMateriaalHuren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMateriaalHuren.Name = "btnMateriaalHuren";
            this.btnMateriaalHuren.Size = new System.Drawing.Size(119, 39);
            this.btnMateriaalHuren.TabIndex = 32;
            this.btnMateriaalHuren.Text = "Materiaal Huren";
            this.btnMateriaalHuren.UseVisualStyleBackColor = true;
            this.btnMateriaalHuren.Click += new System.EventHandler(this.btnMateriaalHuren_Click);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(23, 694);
            this.btnVolgende.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(119, 39);
            this.btnVolgende.TabIndex = 31;
            this.btnVolgende.Text = "Bevestig";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICT4Events_S24_Groep_E.Properties.Resources.Camping_ReeënDal__1_;
            this.pictureBox1.Location = new System.Drawing.Point(429, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // gbPlaatsen
            // 
            this.gbPlaatsen.Controls.Add(this.cbPlaats);
            this.gbPlaatsen.Controls.Add(this.btnVerwijderPlaats);
            this.gbPlaatsen.Controls.Add(this.lblPlaats);
            this.gbPlaatsen.Controls.Add(this.btnVoegPlaatsToe);
            this.gbPlaatsen.Controls.Add(this.lbPlaatsen);
            this.gbPlaatsen.Location = new System.Drawing.Point(12, 391);
            this.gbPlaatsen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlaatsen.Name = "gbPlaatsen";
            this.gbPlaatsen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlaatsen.Size = new System.Drawing.Size(411, 263);
            this.gbPlaatsen.TabIndex = 35;
            this.gbPlaatsen.TabStop = false;
            this.gbPlaatsen.Text = "Plaatsen";
            // 
            // InschrijfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 786);
            this.Controls.Add(this.gbPlaatsen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbMeerderePersonen);
            this.Controls.Add(this.chbMeerPersonen);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.gbGegevens);
            this.Controls.Add(this.btnMateriaalHuren);
            this.Controls.Add(this.btnVolgende);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InschrijfForm";
            this.Text = "InschrijfForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InschrijfForm_FormClosing);
            this.gbGegevens.ResumeLayout(false);
            this.gbGegevens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPlaatsen.ResumeLayout(false);
            this.gbPlaatsen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMeerderePersonen;
        private System.Windows.Forms.CheckBox chbMeerPersonen;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.GroupBox gbGegevens;
        private System.Windows.Forms.Button btnVerwijderPlaats;
        private System.Windows.Forms.Button btnVoegPlaatsToe;
        private System.Windows.Forms.ListBox lbPlaatsen;
        private System.Windows.Forms.ComboBox cbPlaats;
        private System.Windows.Forms.Label lblPlaats;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblGebDatum;
        private System.Windows.Forms.Label lblTelefoon;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblStad;
        private System.Windows.Forms.Label lblHuisnummer;
        private System.Windows.Forms.Label lblRekNummer;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.DateTimePicker dtpGebDatum;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbTelefoon;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbStad;
        private System.Windows.Forms.TextBox tbHuisnummer;
        private System.Windows.Forms.TextBox tbRekNr;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnMateriaalHuren;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.Button btnMaakBezoeker;
        private System.Windows.Forms.GroupBox gbPlaatsen;
    }
}