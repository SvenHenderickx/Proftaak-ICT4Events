namespace ICT4Events_S24_Groep_E
{
    partial class InschrijfFormBezoeker
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnMateriaalHuren = new System.Windows.Forms.Button();
            this.lblHoofdboekerInfo = new System.Windows.Forms.Label();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.lblResterendeBezoekers = new System.Windows.Forms.Label();
            this.gbGegevens = new System.Windows.Forms.GroupBox();
            this.btnMaakBezoeker = new System.Windows.Forms.Button();
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.tbGebruikersNaam = new System.Windows.Forms.TextBox();
            this.lblWachtWoord = new System.Windows.Forms.Label();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblGebDatum = new System.Windows.Forms.Label();
            this.lblTelefoon = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblStad = new System.Windows.Forms.Label();
            this.lblHuisnummer = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.dtpGebDatum = new System.Windows.Forms.DateTimePicker();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbTelefoon = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbStad = new System.Windows.Forms.TextBox();
            this.tbHuisnummer = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.gbGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(298, 411);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(98, 47);
            this.btnAnnuleren.TabIndex = 35;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnMateriaalHuren
            // 
            this.btnMateriaalHuren.Location = new System.Drawing.Point(131, 411);
            this.btnMateriaalHuren.Name = "btnMateriaalHuren";
            this.btnMateriaalHuren.Size = new System.Drawing.Size(121, 47);
            this.btnMateriaalHuren.TabIndex = 34;
            this.btnMateriaalHuren.Text = "Materiaal Huren";
            this.btnMateriaalHuren.UseVisualStyleBackColor = true;
            this.btnMateriaalHuren.Click += new System.EventHandler(this.btnMateriaalHuren_Click);
            // 
            // lblHoofdboekerInfo
            // 
            this.lblHoofdboekerInfo.AutoSize = true;
            this.lblHoofdboekerInfo.Location = new System.Drawing.Point(13, 378);
            this.lblHoofdboekerInfo.Name = "lblHoofdboekerInfo";
            this.lblHoofdboekerInfo.Size = new System.Drawing.Size(46, 17);
            this.lblHoofdboekerInfo.TabIndex = 32;
            this.lblHoofdboekerInfo.Text = "label1";
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(22, 411);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(103, 47);
            this.btnVolgende.TabIndex = 33;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // lblResterendeBezoekers
            // 
            this.lblResterendeBezoekers.AutoSize = true;
            this.lblResterendeBezoekers.Location = new System.Drawing.Point(11, 357);
            this.lblResterendeBezoekers.Name = "lblResterendeBezoekers";
            this.lblResterendeBezoekers.Size = new System.Drawing.Size(163, 17);
            this.lblResterendeBezoekers.TabIndex = 31;
            this.lblResterendeBezoekers.Text = "lblResterendeBezoekers";
            // 
            // gbGegevens
            // 
            this.gbGegevens.Controls.Add(this.btnMaakBezoeker);
            this.gbGegevens.Controls.Add(this.lblGebruikersNaam);
            this.gbGegevens.Controls.Add(this.tbGebruikersNaam);
            this.gbGegevens.Controls.Add(this.lblWachtWoord);
            this.gbGegevens.Controls.Add(this.tbWachtwoord);
            this.gbGegevens.Controls.Add(this.lblAchternaam);
            this.gbGegevens.Controls.Add(this.lblGebDatum);
            this.gbGegevens.Controls.Add(this.lblTelefoon);
            this.gbGegevens.Controls.Add(this.lblPostcode);
            this.gbGegevens.Controls.Add(this.lblStad);
            this.gbGegevens.Controls.Add(this.lblHuisnummer);
            this.gbGegevens.Controls.Add(this.lblNaam);
            this.gbGegevens.Controls.Add(this.dtpGebDatum);
            this.gbGegevens.Controls.Add(this.tbAchternaam);
            this.gbGegevens.Controls.Add(this.tbTelefoon);
            this.gbGegevens.Controls.Add(this.tbPostcode);
            this.gbGegevens.Controls.Add(this.tbStad);
            this.gbGegevens.Controls.Add(this.tbHuisnummer);
            this.gbGegevens.Controls.Add(this.tbNaam);
            this.gbGegevens.Location = new System.Drawing.Point(12, 12);
            this.gbGegevens.Name = "gbGegevens";
            this.gbGegevens.Size = new System.Drawing.Size(411, 338);
            this.gbGegevens.TabIndex = 30;
            this.gbGegevens.TabStop = false;
            this.gbGegevens.Text = "Gegevens:";
            // 
            // btnMaakBezoeker
            // 
            this.btnMaakBezoeker.Location = new System.Drawing.Point(255, 289);
            this.btnMaakBezoeker.Name = "btnMaakBezoeker";
            this.btnMaakBezoeker.Size = new System.Drawing.Size(129, 43);
            this.btnMaakBezoeker.TabIndex = 27;
            this.btnMaakBezoeker.Text = "Maak Bezoeker";
            this.btnMaakBezoeker.UseVisualStyleBackColor = true;
            this.btnMaakBezoeker.Click += new System.EventHandler(this.btnMaakBezoeker_Click);
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(7, 92);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(117, 17);
            this.lblGebruikersNaam.TabIndex = 26;
            this.lblGebruikersNaam.Text = "Gebruikersnaam:";
            // 
            // tbGebruikersNaam
            // 
            this.tbGebruikersNaam.Location = new System.Drawing.Point(136, 86);
            this.tbGebruikersNaam.Name = "tbGebruikersNaam";
            this.tbGebruikersNaam.Size = new System.Drawing.Size(248, 22);
            this.tbGebruikersNaam.TabIndex = 25;
            this.tbGebruikersNaam.Text = "TieperPiet";
            // 
            // lblWachtWoord
            // 
            this.lblWachtWoord.AutoSize = true;
            this.lblWachtWoord.Location = new System.Drawing.Point(6, 119);
            this.lblWachtWoord.Name = "lblWachtWoord";
            this.lblWachtWoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtWoord.TabIndex = 24;
            this.lblWachtWoord.Text = "Wachtwoord:";
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(136, 114);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(248, 22);
            this.tbWachtwoord.TabIndex = 23;
            this.tbWachtwoord.Text = "Tieper";
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
            this.lblStad.Location = new System.Drawing.Point(7, 232);
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
            this.dtpGebDatum.Name = "dtpGebDatum";
            this.dtpGebDatum.Size = new System.Drawing.Size(248, 22);
            this.dtpGebDatum.TabIndex = 9;
            this.dtpGebDatum.Value = new System.DateTime(2015, 4, 13, 0, 0, 0, 0);
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(136, 58);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(248, 22);
            this.tbAchternaam.TabIndex = 8;
            this.tbAchternaam.Text = "Halal";
            // 
            // tbTelefoon
            // 
            this.tbTelefoon.Location = new System.Drawing.Point(136, 170);
            this.tbTelefoon.Name = "tbTelefoon";
            this.tbTelefoon.Size = new System.Drawing.Size(248, 22);
            this.tbTelefoon.TabIndex = 7;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(136, 198);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(248, 22);
            this.tbPostcode.TabIndex = 6;
            // 
            // tbStad
            // 
            this.tbStad.Location = new System.Drawing.Point(136, 226);
            this.tbStad.Name = "tbStad";
            this.tbStad.Size = new System.Drawing.Size(248, 22);
            this.tbStad.TabIndex = 5;
            // 
            // tbHuisnummer
            // 
            this.tbHuisnummer.Location = new System.Drawing.Point(136, 254);
            this.tbHuisnummer.Name = "tbHuisnummer";
            this.tbHuisnummer.Size = new System.Drawing.Size(248, 22);
            this.tbHuisnummer.TabIndex = 4;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(136, 30);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(248, 22);
            this.tbNaam.TabIndex = 0;
            this.tbNaam.Text = "Pieter";
            // 
            // InschrijfFormBezoeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 485);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnMateriaalHuren);
            this.Controls.Add(this.lblHoofdboekerInfo);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.lblResterendeBezoekers);
            this.Controls.Add(this.gbGegevens);
            this.Name = "InschrijfFormBezoeker";
            this.Text = "InschrijfFormBezoeker";
            this.gbGegevens.ResumeLayout(false);
            this.gbGegevens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnMateriaalHuren;
        private System.Windows.Forms.Label lblHoofdboekerInfo;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Label lblResterendeBezoekers;
        private System.Windows.Forms.GroupBox gbGegevens;
        private System.Windows.Forms.Button btnMaakBezoeker;
        private System.Windows.Forms.Label lblGebruikersNaam;
        private System.Windows.Forms.TextBox tbGebruikersNaam;
        private System.Windows.Forms.Label lblWachtWoord;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblGebDatum;
        private System.Windows.Forms.Label lblTelefoon;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblStad;
        private System.Windows.Forms.Label lblHuisnummer;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.DateTimePicker dtpGebDatum;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbTelefoon;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbStad;
        private System.Windows.Forms.TextBox tbHuisnummer;
        private System.Windows.Forms.TextBox tbNaam;
    }
}