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
            this.cbMeerderePersonen = new System.Windows.Forms.ComboBox();
            this.cbMeerPersonen = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerwijderPlaats = new System.Windows.Forms.Button();
            this.btnVoegPlaatsToe = new System.Windows.Forms.Button();
            this.lbPlaatsen = new System.Windows.Forms.ListBox();
            this.cbPlaats = new System.Windows.Forms.ComboBox();
            this.lblPlaats = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMeerderePersonen
            // 
            this.cbMeerderePersonen.FormattingEnabled = true;
            this.cbMeerderePersonen.Location = new System.Drawing.Point(179, 455);
            this.cbMeerderePersonen.Name = "cbMeerderePersonen";
            this.cbMeerderePersonen.Size = new System.Drawing.Size(66, 24);
            this.cbMeerderePersonen.TabIndex = 30;
            // 
            // cbMeerPersonen
            // 
            this.cbMeerPersonen.AutoSize = true;
            this.cbMeerPersonen.Location = new System.Drawing.Point(22, 455);
            this.cbMeerPersonen.Name = "cbMeerPersonen";
            this.cbMeerPersonen.Size = new System.Drawing.Size(151, 21);
            this.cbMeerPersonen.TabIndex = 29;
            this.cbMeerPersonen.Text = "Meedere Personen";
            this.cbMeerPersonen.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 33;
            this.button2.Text = "Annuleren";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerwijderPlaats);
            this.groupBox1.Controls.Add(this.btnVoegPlaatsToe);
            this.groupBox1.Controls.Add(this.lbPlaatsen);
            this.groupBox1.Controls.Add(this.cbPlaats);
            this.groupBox1.Controls.Add(this.lblPlaats);
            this.groupBox1.Controls.Add(this.lblAchternaam);
            this.groupBox1.Controls.Add(this.lblGebDatum);
            this.groupBox1.Controls.Add(this.lblTelefoon);
            this.groupBox1.Controls.Add(this.lblPostcode);
            this.groupBox1.Controls.Add(this.lblStad);
            this.groupBox1.Controls.Add(this.lblHuisnummer);
            this.groupBox1.Controls.Add(this.lblRekNummer);
            this.groupBox1.Controls.Add(this.lblNaam);
            this.groupBox1.Controls.Add(this.dtpGebDatum);
            this.groupBox1.Controls.Add(this.tbAchternaam);
            this.groupBox1.Controls.Add(this.tbTelefoon);
            this.groupBox1.Controls.Add(this.tbPostcode);
            this.groupBox1.Controls.Add(this.tbStad);
            this.groupBox1.Controls.Add(this.tbHuisnummer);
            this.groupBox1.Controls.Add(this.tbRekNr);
            this.groupBox1.Controls.Add(this.tbNaam);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 437);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gegevens:";
            // 
            // btnVerwijderPlaats
            // 
            this.btnVerwijderPlaats.Location = new System.Drawing.Point(240, 288);
            this.btnVerwijderPlaats.Name = "btnVerwijderPlaats";
            this.btnVerwijderPlaats.Size = new System.Drawing.Size(144, 50);
            this.btnVerwijderPlaats.TabIndex = 22;
            this.btnVerwijderPlaats.Text = "Verwijder Plaats";
            this.btnVerwijderPlaats.UseVisualStyleBackColor = true;
            this.btnVerwijderPlaats.Click += new System.EventHandler(this.btnVerwijderPlaats_Click);
            // 
            // btnVoegPlaatsToe
            // 
            this.btnVoegPlaatsToe.Location = new System.Drawing.Point(96, 288);
            this.btnVoegPlaatsToe.Name = "btnVoegPlaatsToe";
            this.btnVoegPlaatsToe.Size = new System.Drawing.Size(138, 50);
            this.btnVoegPlaatsToe.TabIndex = 21;
            this.btnVoegPlaatsToe.Text = "Voeg Plaats Toe";
            this.btnVoegPlaatsToe.UseVisualStyleBackColor = true;
            this.btnVoegPlaatsToe.Click += new System.EventHandler(this.btnVoegPlaatsToe_Click);
            // 
            // lbPlaatsen
            // 
            this.lbPlaatsen.FormattingEnabled = true;
            this.lbPlaatsen.ItemHeight = 16;
            this.lbPlaatsen.Location = new System.Drawing.Point(10, 344);
            this.lbPlaatsen.Name = "lbPlaatsen";
            this.lbPlaatsen.Size = new System.Drawing.Size(374, 84);
            this.lbPlaatsen.TabIndex = 20;
            // 
            // cbPlaats
            // 
            this.cbPlaats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaats.FormattingEnabled = true;
            this.cbPlaats.Location = new System.Drawing.Point(136, 258);
            this.cbPlaats.Name = "cbPlaats";
            this.cbPlaats.Size = new System.Drawing.Size(248, 24);
            this.cbPlaats.TabIndex = 19;
            // 
            // lblPlaats
            // 
            this.lblPlaats.AutoSize = true;
            this.lblPlaats.Location = new System.Drawing.Point(7, 261);
            this.lblPlaats.Name = "lblPlaats";
            this.lblPlaats.Size = new System.Drawing.Size(51, 17);
            this.lblPlaats.TabIndex = 18;
            this.lblPlaats.Text = "Plaats:";
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
            this.lblGebDatum.Location = new System.Drawing.Point(7, 95);
            this.lblGebDatum.Name = "lblGebDatum";
            this.lblGebDatum.Size = new System.Drawing.Size(111, 17);
            this.lblGebDatum.TabIndex = 16;
            this.lblGebDatum.Text = "Geboortedatum:";
            // 
            // lblTelefoon
            // 
            this.lblTelefoon.AutoSize = true;
            this.lblTelefoon.Location = new System.Drawing.Point(7, 121);
            this.lblTelefoon.Name = "lblTelefoon";
            this.lblTelefoon.Size = new System.Drawing.Size(68, 17);
            this.lblTelefoon.TabIndex = 15;
            this.lblTelefoon.Text = "Telefoon:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(7, 149);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(71, 17);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblStad
            // 
            this.lblStad.AutoSize = true;
            this.lblStad.Location = new System.Drawing.Point(7, 177);
            this.lblStad.Name = "lblStad";
            this.lblStad.Size = new System.Drawing.Size(41, 17);
            this.lblStad.TabIndex = 13;
            this.lblStad.Text = "Stad:";
            // 
            // lblHuisnummer
            // 
            this.lblHuisnummer.AutoSize = true;
            this.lblHuisnummer.Location = new System.Drawing.Point(7, 205);
            this.lblHuisnummer.Name = "lblHuisnummer";
            this.lblHuisnummer.Size = new System.Drawing.Size(91, 17);
            this.lblHuisnummer.TabIndex = 12;
            this.lblHuisnummer.Text = "Huisnummer:";
            // 
            // lblRekNummer
            // 
            this.lblRekNummer.AutoSize = true;
            this.lblRekNummer.Location = new System.Drawing.Point(7, 233);
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
            this.dtpGebDatum.Location = new System.Drawing.Point(136, 87);
            this.dtpGebDatum.Name = "dtpGebDatum";
            this.dtpGebDatum.Size = new System.Drawing.Size(248, 22);
            this.dtpGebDatum.TabIndex = 9;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(136, 58);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(248, 22);
            this.tbAchternaam.TabIndex = 8;
            // 
            // tbTelefoon
            // 
            this.tbTelefoon.Location = new System.Drawing.Point(136, 115);
            this.tbTelefoon.Name = "tbTelefoon";
            this.tbTelefoon.Size = new System.Drawing.Size(248, 22);
            this.tbTelefoon.TabIndex = 7;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(136, 143);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(248, 22);
            this.tbPostcode.TabIndex = 6;
            // 
            // tbStad
            // 
            this.tbStad.Location = new System.Drawing.Point(136, 171);
            this.tbStad.Name = "tbStad";
            this.tbStad.Size = new System.Drawing.Size(248, 22);
            this.tbStad.TabIndex = 5;
            // 
            // tbHuisnummer
            // 
            this.tbHuisnummer.Location = new System.Drawing.Point(136, 199);
            this.tbHuisnummer.Name = "tbHuisnummer";
            this.tbHuisnummer.Size = new System.Drawing.Size(248, 22);
            this.tbHuisnummer.TabIndex = 4;
            // 
            // tbRekNr
            // 
            this.tbRekNr.Location = new System.Drawing.Point(136, 227);
            this.tbRekNr.Name = "tbRekNr";
            this.tbRekNr.Size = new System.Drawing.Size(248, 22);
            this.tbRekNr.TabIndex = 3;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(136, 30);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(248, 22);
            this.tbNaam.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Materiaal Huren";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(22, 485);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(119, 40);
            this.btnVolgende.TabIndex = 31;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICT4Events_S24_Groep_E.Properties.Resources.Camping_ReeënDal__1_;
            this.pictureBox1.Location = new System.Drawing.Point(430, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 771);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // InschrijfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 787);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbMeerderePersonen);
            this.Controls.Add(this.cbMeerPersonen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolgende);
            this.Name = "InschrijfForm";
            this.Text = "InschrijfForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMeerderePersonen;
        private System.Windows.Forms.CheckBox cbMeerPersonen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}