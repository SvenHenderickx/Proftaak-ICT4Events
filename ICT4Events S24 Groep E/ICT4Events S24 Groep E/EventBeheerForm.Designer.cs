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
            this.gbGebruikers = new System.Windows.Forms.GroupBox();
            this.cbPlaats = new System.Windows.Forms.ComboBox();
            this.btnZeker = new System.Windows.Forms.Button();
            this.btnNee = new System.Windows.Forms.Button();
            this.cbGebruiker = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbGebruikerinfo = new System.Windows.Forms.ListBox();
            this.btnInfoOpvraag = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDatabaseConnectie = new System.Windows.Forms.Button();
            this.cbCategorieSelecter = new System.Windows.Forms.ComboBox();
            this.cbMateriaalSelecter = new System.Windows.Forms.ComboBox();
            this.cbPlaatsenSelecter = new System.Windows.Forms.ComboBox();
            this.cbDeelnemerSelecter = new System.Windows.Forms.ComboBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.cbMateriaal = new System.Windows.Forms.ComboBox();
            this.cbPlaatsen = new System.Windows.Forms.ComboBox();
            this.cbDeelnemersEventbeheer = new System.Windows.Forms.ComboBox();
            this.cbAdresSelecter = new System.Windows.Forms.ComboBox();
            this.cbPlaatsSelecter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPasEventAan = new System.Windows.Forms.Button();
            this.tbAdresEventbeheer = new System.Windows.Forms.TextBox();
            this.tbEventNaamEventbeheer = new System.Windows.Forms.TextBox();
            this.tbPlaatsEventbeheer = new System.Windows.Forms.TextBox();
            this.cbEventsEventbeheer = new System.Windows.Forms.ComboBox();
            this.btnVerwijderEvent = new System.Windows.Forms.Button();
            this.btnMaakEventAan = new System.Windows.Forms.Button();
            this.tbEventNaam = new System.Windows.Forms.TextBox();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.gebruikerTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.gbGebruikers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.gebruikerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGebruikers
            // 
            this.gbGebruikers.Controls.Add(this.cbPlaats);
            this.gbGebruikers.Controls.Add(this.btnZeker);
            this.gbGebruikers.Controls.Add(this.btnNee);
            this.gbGebruikers.Controls.Add(this.cbGebruiker);
            this.gbGebruikers.Controls.Add(this.btnVerwijder);
            this.gbGebruikers.Controls.Add(this.lbGebruikerinfo);
            this.gbGebruikers.Controls.Add(this.btnInfoOpvraag);
            this.gbGebruikers.Enabled = false;
            this.gbGebruikers.Location = new System.Drawing.Point(6, 6);
            this.gbGebruikers.Name = "gbGebruikers";
            this.gbGebruikers.Size = new System.Drawing.Size(766, 305);
            this.gbGebruikers.TabIndex = 0;
            this.gbGebruikers.TabStop = false;
            this.gbGebruikers.Text = "Gebruikers";
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
            this.btnInfoOpvraag.Click += new System.EventHandler(this.btnInfoOpvraag_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnDatabaseConnectie);
            this.groupBox2.Controls.Add(this.cbCategorieSelecter);
            this.groupBox2.Controls.Add(this.cbMateriaalSelecter);
            this.groupBox2.Controls.Add(this.cbPlaatsenSelecter);
            this.groupBox2.Controls.Add(this.cbDeelnemerSelecter);
            this.groupBox2.Controls.Add(this.cbCategorie);
            this.groupBox2.Controls.Add(this.cbMateriaal);
            this.groupBox2.Controls.Add(this.cbPlaatsen);
            this.groupBox2.Controls.Add(this.cbDeelnemersEventbeheer);
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
            this.groupBox2.Controls.Add(this.tbAdresEventbeheer);
            this.groupBox2.Controls.Add(this.tbEventNaamEventbeheer);
            this.groupBox2.Controls.Add(this.tbPlaatsEventbeheer);
            this.groupBox2.Controls.Add(this.cbEventsEventbeheer);
            this.groupBox2.Controls.Add(this.btnVerwijderEvent);
            this.groupBox2.Controls.Add(this.btnMaakEventAan);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EventBeheer";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(385, 225);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Verwijder";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(385, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Verwijder";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(696, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "voeg toe";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(385, 202);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Verwijder";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(696, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "voeg toe";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(696, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "voeg toe";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Verwijder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "voeg toe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDatabaseConnectie
            // 
            this.btnDatabaseConnectie.Location = new System.Drawing.Point(93, 328);
            this.btnDatabaseConnectie.Name = "btnDatabaseConnectie";
            this.btnDatabaseConnectie.Size = new System.Drawing.Size(113, 23);
            this.btnDatabaseConnectie.TabIndex = 6;
            this.btnDatabaseConnectie.Text = "Database Connectie";
            this.btnDatabaseConnectie.UseVisualStyleBackColor = true;
            this.btnDatabaseConnectie.Click += new System.EventHandler(this.btnDatabaseConnectie_Click);
            // 
            // cbCategorieSelecter
            // 
            this.cbCategorieSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorieSelecter.Location = new System.Drawing.Point(459, 227);
            this.cbCategorieSelecter.Name = "cbCategorieSelecter";
            this.cbCategorieSelecter.Size = new System.Drawing.Size(231, 21);
            this.cbCategorieSelecter.TabIndex = 0;
            // 
            // cbMateriaalSelecter
            // 
            this.cbMateriaalSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaalSelecter.Location = new System.Drawing.Point(459, 202);
            this.cbMateriaalSelecter.Name = "cbMateriaalSelecter";
            this.cbMateriaalSelecter.Size = new System.Drawing.Size(231, 21);
            this.cbMateriaalSelecter.TabIndex = 0;
            // 
            // cbPlaatsenSelecter
            // 
            this.cbPlaatsenSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsenSelecter.Location = new System.Drawing.Point(459, 176);
            this.cbPlaatsenSelecter.Name = "cbPlaatsenSelecter";
            this.cbPlaatsenSelecter.Size = new System.Drawing.Size(231, 21);
            this.cbPlaatsenSelecter.TabIndex = 0;
            // 
            // cbDeelnemerSelecter
            // 
            this.cbDeelnemerSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeelnemerSelecter.Location = new System.Drawing.Point(459, 153);
            this.cbDeelnemerSelecter.Name = "cbDeelnemerSelecter";
            this.cbDeelnemerSelecter.Size = new System.Drawing.Size(231, 21);
            this.cbDeelnemerSelecter.TabIndex = 0;
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.Location = new System.Drawing.Point(148, 227);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(231, 21);
            this.cbCategorie.TabIndex = 0;
            // 
            // cbMateriaal
            // 
            this.cbMateriaal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaal.Location = new System.Drawing.Point(148, 202);
            this.cbMateriaal.Name = "cbMateriaal";
            this.cbMateriaal.Size = new System.Drawing.Size(231, 21);
            this.cbMateriaal.TabIndex = 0;
            // 
            // cbPlaatsen
            // 
            this.cbPlaatsen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsen.Location = new System.Drawing.Point(148, 176);
            this.cbPlaatsen.Name = "cbPlaatsen";
            this.cbPlaatsen.Size = new System.Drawing.Size(231, 21);
            this.cbPlaatsen.TabIndex = 0;
            // 
            // cbDeelnemersEventbeheer
            // 
            this.cbDeelnemersEventbeheer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeelnemersEventbeheer.Location = new System.Drawing.Point(148, 152);
            this.cbDeelnemersEventbeheer.Name = "cbDeelnemersEventbeheer";
            this.cbDeelnemersEventbeheer.Size = new System.Drawing.Size(231, 21);
            this.cbDeelnemersEventbeheer.TabIndex = 0;
            // 
            // cbAdresSelecter
            // 
            this.cbAdresSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdresSelecter.Location = new System.Drawing.Point(425, 126);
            this.cbAdresSelecter.Name = "cbAdresSelecter";
            this.cbAdresSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbAdresSelecter.TabIndex = 0;
            // 
            // cbPlaatsSelecter
            // 
            this.cbPlaatsSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsSelecter.Location = new System.Drawing.Point(425, 101);
            this.cbPlaatsSelecter.Name = "cbPlaatsSelecter";
            this.cbPlaatsSelecter.Size = new System.Drawing.Size(333, 21);
            this.cbPlaatsSelecter.TabIndex = 0;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "materiaal";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deelnemers";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plaats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Einddatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Startdatum";
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
            // tbAdresEventbeheer
            // 
            this.tbAdresEventbeheer.Location = new System.Drawing.Point(148, 126);
            this.tbAdresEventbeheer.Name = "tbAdresEventbeheer";
            this.tbAdresEventbeheer.Size = new System.Drawing.Size(270, 20);
            this.tbAdresEventbeheer.TabIndex = 2;
            // 
            // tbEventNaamEventbeheer
            // 
            this.tbEventNaamEventbeheer.Location = new System.Drawing.Point(488, 62);
            this.tbEventNaamEventbeheer.Name = "tbEventNaamEventbeheer";
            this.tbEventNaamEventbeheer.Size = new System.Drawing.Size(270, 20);
            this.tbEventNaamEventbeheer.TabIndex = 2;
            // 
            // tbPlaatsEventbeheer
            // 
            this.tbPlaatsEventbeheer.Location = new System.Drawing.Point(148, 101);
            this.tbPlaatsEventbeheer.Name = "tbPlaatsEventbeheer";
            this.tbPlaatsEventbeheer.Size = new System.Drawing.Size(270, 20);
            this.tbPlaatsEventbeheer.TabIndex = 2;
            // 
            // cbEventsEventbeheer
            // 
            this.cbEventsEventbeheer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventsEventbeheer.FormattingEnabled = true;
            this.cbEventsEventbeheer.Location = new System.Drawing.Point(148, 19);
            this.cbEventsEventbeheer.Name = "cbEventsEventbeheer";
            this.cbEventsEventbeheer.Size = new System.Drawing.Size(448, 21);
            this.cbEventsEventbeheer.TabIndex = 1;
            this.cbEventsEventbeheer.SelectedIndexChanged += new System.EventHandler(this.cbEvents_SelectedIndexChanged);
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
            // tbEventNaam
            // 
            this.tbEventNaam.Location = new System.Drawing.Point(0, 0);
            this.tbEventNaam.Name = "tbEventNaam";
            this.tbEventNaam.Size = new System.Drawing.Size(100, 20);
            this.tbEventNaam.TabIndex = 0;
            // 
            // cbEvents
            // 
            this.cbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvents.FormattingEnabled = true;
            this.cbEvents.Location = new System.Drawing.Point(148, 19);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(529, 21);
            this.cbEvents.TabIndex = 1;
            this.cbEvents.SelectedIndexChanged += new System.EventHandler(this.cbEvents_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.eventTab);
            this.tabControl1.Controls.Add(this.gebruikerTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 401);
            this.tabControl1.TabIndex = 2;
            // 
            // eventTab
            // 
            this.eventTab.Controls.Add(this.groupBox2);
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(781, 375);
            this.eventTab.TabIndex = 0;
            this.eventTab.Text = "Event";
            this.eventTab.UseVisualStyleBackColor = true;
            this.eventTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gebruikerTab
            // 
            this.gebruikerTab.Controls.Add(this.gbGebruikers);
            this.gebruikerTab.Location = new System.Drawing.Point(4, 22);
            this.gebruikerTab.Name = "gebruikerTab";
            this.gebruikerTab.Padding = new System.Windows.Forms.Padding(3);
            this.gebruikerTab.Size = new System.Drawing.Size(781, 375);
            this.gebruikerTab.TabIndex = 1;
            this.gebruikerTab.Text = "Gebruiker";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMaakEventAan_Click);
            // 
            // EventBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventBeheerForm";
            this.Text = "EventBeheerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerugNaarLogIn);
            this.gbGebruikers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.eventTab.ResumeLayout(false);
            this.gebruikerTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGebruikers;
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
        private System.Windows.Forms.ComboBox cbEventsEventbeheer;
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
        private System.Windows.Forms.ComboBox cbDeelnemersEventbeheer;
        private System.Windows.Forms.ComboBox cbAdresSelecter;
        private System.Windows.Forms.ComboBox cbPlaatsSelecter;
        private System.Windows.Forms.TextBox tbAdresEventbeheer;
        private System.Windows.Forms.TextBox tbPlaatsEventbeheer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEventNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbEventNaamEventbeheer;
        private System.Windows.Forms.Button btnDatabaseConnectie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}