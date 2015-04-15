namespace ICT4Events_S24_Groep_E
{
    partial class EventBeheerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventBeheerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPlaats = new System.Windows.Forms.ComboBox();
            this.btnZeker = new System.Windows.Forms.Button();
            this.btnNee = new System.Windows.Forms.Button();
            this.cbGebruiker = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbGebruikerinfo = new System.Windows.Forms.ListBox();
            this.btnInfoOpvraag = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPasEventAan = new System.Windows.Forms.Button();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.btnVerwijderEvent = new System.Windows.Forms.Button();
            this.btnMaakEventAan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.gebruikerTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPlaats = new System.Windows.Forms.TextBox();
            this.cbPlaatsSelecter = new System.Windows.Forms.ComboBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.cbAdresSelecter = new System.Windows.Forms.ComboBox();
            this.cbDeelnemers = new System.Windows.Forms.ComboBox();
            this.cbDeelnemerSelecter = new System.Windows.Forms.ComboBox();
            this.cbPlaatsen = new System.Windows.Forms.ComboBox();
            this.cbPlaatsenSelecter = new System.Windows.Forms.ComboBox();
            this.cbMateriaal = new System.Windows.Forms.ComboBox();
            this.cbMateriaalSelecter = new System.Windows.Forms.ComboBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.cbCategorieSelecter = new System.Windows.Forms.ComboBox();
            this.tbEventNaam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.gebruikerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPlaats);
            this.groupBox1.Controls.Add(this.btnZeker);
            this.groupBox1.Controls.Add(this.btnNee);
            this.groupBox1.Controls.Add(this.cbGebruiker);
            this.groupBox1.Controls.Add(this.btnVerwijder);
            this.groupBox1.Controls.Add(this.lbGebruikerinfo);
            this.groupBox1.Controls.Add(this.btnInfoOpvraag);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gebruikers";
            // 
            // cbPlaats
            // 
            this.cbPlaats.FormattingEnabled = true;
            this.cbPlaats.Location = new System.Drawing.Point(5, 254);
            this.cbPlaats.Name = "cbPlaats";
            this.cbPlaats.Size = new System.Drawing.Size(121, 21);
            this.cbPlaats.TabIndex = 5;
            // 
            // btnZeker
            // 
            this.btnZeker.Location = new System.Drawing.Point(560, 222);
            this.btnZeker.Name = "btnZeker";
            this.btnZeker.Size = new System.Drawing.Size(75, 23);
            this.btnZeker.TabIndex = 4;
            this.btnZeker.Text = "Zeker?";
            this.btnZeker.UseVisualStyleBackColor = true;
            this.btnZeker.Click += new System.EventHandler(this.btnZeker_Click);
            // 
            // btnNee
            // 
            this.btnNee.Location = new System.Drawing.Point(641, 222);
            this.btnNee.Name = "btnNee";
            this.btnNee.Size = new System.Drawing.Size(75, 23);
            this.btnNee.TabIndex = 4;
            this.btnNee.Text = "Nee";
            this.btnNee.UseVisualStyleBackColor = true;
            this.btnNee.Click += new System.EventHandler(this.btnNee_Click);
            // 
            // cbGebruiker
            // 
            this.cbGebruiker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGebruiker.FormattingEnabled = true;
            this.cbGebruiker.Location = new System.Drawing.Point(133, 224);
            this.cbGebruiker.Name = "cbGebruiker";
            this.cbGebruiker.Size = new System.Drawing.Size(421, 21);
            this.cbGebruiker.TabIndex = 3;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(5, 224);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(121, 23);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "verwijder gebruiker";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lbGebruikerinfo
            // 
            this.lbGebruikerinfo.FormattingEnabled = true;
            this.lbGebruikerinfo.Location = new System.Drawing.Point(218, 19);
            this.lbGebruikerinfo.Name = "lbGebruikerinfo";
            this.lbGebruikerinfo.Size = new System.Drawing.Size(542, 199);
            this.lbGebruikerinfo.TabIndex = 1;
            // 
            // btnInfoOpvraag
            // 
            this.btnInfoOpvraag.Location = new System.Drawing.Point(100, 19);
            this.btnInfoOpvraag.Name = "btnInfoOpvraag";
            this.btnInfoOpvraag.Size = new System.Drawing.Size(112, 34);
            this.btnInfoOpvraag.TabIndex = 0;
            this.btnInfoOpvraag.Text = "Vraag informatie op voor alle gebruikers";
            this.btnInfoOpvraag.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCategorieSelecter);
            this.groupBox2.Controls.Add(this.cbMateriaalSelecter);
            this.groupBox2.Controls.Add(this.cbPlaatsenSelecter);
            this.groupBox2.Controls.Add(this.cbDeelnemerSelecter);
            this.groupBox2.Controls.Add(this.cbCategorie);
            this.groupBox2.Controls.Add(this.cbMateriaal);
            this.groupBox2.Controls.Add(this.cbPlaatsen);
            this.groupBox2.Controls.Add(this.cbDeelnemers);
            this.groupBox2.Controls.Add(this.cbAdresSelecter);
            this.groupBox2.Controls.Add(this.cbPlaatsSelecter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpEindDatum);
            this.groupBox2.Controls.Add(this.dtpBeginDatum);
            this.groupBox2.Controls.Add(this.btnPasEventAan);
            this.groupBox2.Controls.Add(this.tbAdres);
            this.groupBox2.Controls.Add(this.tbEventNaam);
            this.groupBox2.Controls.Add(this.tbPlaats);
            this.groupBox2.Controls.Add(this.cbEvents);
            this.groupBox2.Controls.Add(this.btnVerwijderEvent);
            this.groupBox2.Controls.Add(this.btnMaakEventAan);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EventBeheer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Event";
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(148, 72);
            this.dtpEindDatum.MinDate = new System.DateTime(2015, 4, 14, 0, 0, 0, 0);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpEindDatum.TabIndex = 4;
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(148, 46);
            this.dtpBeginDatum.MinDate = new System.DateTime(2015, 4, 14, 0, 0, 0, 0);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDatum.TabIndex = 4;
            // 
            // btnPasEventAan
            // 
            this.btnPasEventAan.Location = new System.Drawing.Point(602, 17);
            this.btnPasEventAan.Name = "btnPasEventAan";
            this.btnPasEventAan.Size = new System.Drawing.Size(75, 23);
            this.btnPasEventAan.TabIndex = 3;
            this.btnPasEventAan.Text = "Pas aan";
            this.btnPasEventAan.UseVisualStyleBackColor = true;
            this.btnPasEventAan.Click += new System.EventHandler(this.btnPasEventAan_Click);
            // 
            // cbEvents
            // 
            this.cbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(148, 19);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(448, 21);
            this.cbEvents.TabIndex = 1;
            this.cbEvents.SelectedIndexChanged += new System.EventHandler(this.cbEvents_SelectedIndexChanged);
            // 
            // btnVerwijderEvent
            // 
            this.btnVerwijderEvent.Location = new System.Drawing.Point(683, 17);
            this.btnVerwijderEvent.Name = "btnVerwijderEvent";
            this.btnVerwijderEvent.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderEvent.TabIndex = 0;
            this.btnVerwijderEvent.Text = "Verwijderen";
            this.btnVerwijderEvent.UseVisualStyleBackColor = true;
            this.btnVerwijderEvent.Click += new System.EventHandler(this.btnVerwijderEvent_Click);
            // 
            // btnMaakEventAan
            // 
            this.btnMaakEventAan.Location = new System.Drawing.Point(12, 328);
            this.btnMaakEventAan.Name = "btnMaakEventAan";
            this.btnMaakEventAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakEventAan.TabIndex = 0;
            this.btnMaakEventAan.Text = "Aanmaken";
            this.btnMaakEventAan.UseVisualStyleBackColor = true;
            this.btnMaakEventAan.Click += new System.EventHandler(this.btnMaakEventAan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.eventTab);
            this.tabControl1.Controls.Add(this.gebruikerTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 516);
            this.tabControl1.TabIndex = 2;
            // 
            // eventTab
            // 
            this.eventTab.Controls.Add(this.groupBox2);
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(781, 490);
            this.eventTab.TabIndex = 0;
            this.eventTab.Text = "Event";
            this.eventTab.UseVisualStyleBackColor = true;
            this.eventTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gebruikerTab
            // 
            this.gebruikerTab.Controls.Add(this.groupBox1);
            this.gebruikerTab.Location = new System.Drawing.Point(4, 22);
            this.gebruikerTab.Name = "gebruikerTab";
            this.gebruikerTab.Padding = new System.Windows.Forms.Padding(3);
            this.gebruikerTab.Size = new System.Drawing.Size(781, 490);
            this.gebruikerTab.TabIndex = 1;
            this.gebruikerTab.Text = "Gebruiker";
            this.gebruikerTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "eind datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "plaats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deelnemers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Plaatsen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "materiaal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Categorieën";
            // 
            // tbPlaats
            // 
            this.tbPlaats.Location = new System.Drawing.Point(148, 101);
            this.tbPlaats.Name = "tbPlaats";
            this.tbPlaats.Size = new System.Drawing.Size(270, 20);
            this.tbPlaats.TabIndex = 2;
            // 
            // cbPlaatsSelecter
            // 
            this.cbPlaatsSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsSelecter.Location = new System.Drawing.Point(425, 101);
            this.cbPlaatsSelecter.Name = "cbPlaatsSelecter";
            this.cbPlaatsSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbPlaatsSelecter.TabIndex = 0;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(148, 126);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(270, 20);
            this.tbAdres.TabIndex = 2;
            // 
            // cbAdresSelecter
            // 
            this.cbAdresSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdresSelecter.Location = new System.Drawing.Point(425, 126);
            this.cbAdresSelecter.Name = "cbAdresSelecter";
            this.cbAdresSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbAdresSelecter.TabIndex = 0;
            // 
            // cbDeelnemers
            // 
            this.cbDeelnemers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeelnemers.Location = new System.Drawing.Point(148, 152);
            this.cbDeelnemers.Name = "cbDeelnemers";
            this.cbDeelnemers.Size = new System.Drawing.Size(270, 21);
            this.cbDeelnemers.TabIndex = 0;
            // 
            // cbDeelnemerSelecter
            // 
            this.cbDeelnemerSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeelnemerSelecter.Location = new System.Drawing.Point(425, 152);
            this.cbDeelnemerSelecter.Name = "cbDeelnemerSelecter";
            this.cbDeelnemerSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbDeelnemerSelecter.TabIndex = 0;
            // 
            // cbPlaatsen
            // 
            this.cbPlaatsen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsen.Location = new System.Drawing.Point(148, 176);
            this.cbPlaatsen.Name = "cbPlaatsen";
            this.cbPlaatsen.Size = new System.Drawing.Size(270, 21);
            this.cbPlaatsen.TabIndex = 0;
            // 
            // cbPlaatsenSelecter
            // 
            this.cbPlaatsenSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsenSelecter.Location = new System.Drawing.Point(425, 176);
            this.cbPlaatsenSelecter.Name = "cbPlaatsenSelecter";
            this.cbPlaatsenSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbPlaatsenSelecter.TabIndex = 0;
            // 
            // cbMateriaal
            // 
            this.cbMateriaal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaal.Location = new System.Drawing.Point(148, 202);
            this.cbMateriaal.Name = "cbMateriaal";
            this.cbMateriaal.Size = new System.Drawing.Size(270, 21);
            this.cbMateriaal.TabIndex = 0;
            // 
            // cbMateriaalSelecter
            // 
            this.cbMateriaalSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaalSelecter.Location = new System.Drawing.Point(425, 202);
            this.cbMateriaalSelecter.Name = "cbMateriaalSelecter";
            this.cbMateriaalSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbMateriaalSelecter.TabIndex = 0;
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.Location = new System.Drawing.Point(148, 227);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(270, 21);
            this.cbCategorie.TabIndex = 0;
            // 
            // cbCategorieSelecter
            // 
            this.cbCategorieSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorieSelecter.Location = new System.Drawing.Point(425, 227);
            this.cbCategorieSelecter.Name = "cbCategorieSelecter";
            this.cbCategorieSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbCategorieSelecter.TabIndex = 0;
            // 
            // tbEventNaam
            // 
            this.tbEventNaam.Location = new System.Drawing.Point(488, 62);
            this.tbEventNaam.Name = "tbEventNaam";
            this.tbEventNaam.Size = new System.Drawing.Size(270, 20);
            this.tbEventNaam.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Naam";
            // 
            // EventBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 542);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventBeheerForm";
            this.Text = "EventBeheerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.eventTab.ResumeLayout(false);
            this.gebruikerTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbGebruikerinfo;
        private System.Windows.Forms.Button btnInfoOpvraag;
        private System.Windows.Forms.Button btnZeker;
        private System.Windows.Forms.Button btnNee;
        private System.Windows.Forms.ComboBox cbGebruiker;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ComboBox cbPlaats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerwijderEvent;
        private System.Windows.Forms.Button btnMaakEventAan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage gebruikerTab;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.Button btnPasEventAan;
        private System.Windows.Forms.DateTimePicker dtpEindDatum;
        private System.Windows.Forms.DateTimePicker dtpBeginDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategorieSelecter;
        private System.Windows.Forms.ComboBox cbMateriaalSelecter;
        private System.Windows.Forms.ComboBox cbPlaatsenSelecter;
        private System.Windows.Forms.ComboBox cbDeelnemerSelecter;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ComboBox cbMateriaal;
        private System.Windows.Forms.ComboBox cbPlaatsen;
        private System.Windows.Forms.ComboBox cbDeelnemers;
        private System.Windows.Forms.ComboBox cbAdresSelecter;
        private System.Windows.Forms.ComboBox cbPlaatsSelecter;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbPlaats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEventNaam;
    }
}