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
            this.btnZeker = new System.Windows.Forms.Button();
            this.btnNee = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbGebruikerinfo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonVerwijderPlaatsen = new System.Windows.Forms.Button();
            this.buttonVerwijderMateriaal = new System.Windows.Forms.Button();
            this.btnDatabaseConnectie = new System.Windows.Forms.Button();
            this.cbMateriaal = new System.Windows.Forms.ComboBox();
            this.cbPlaatsen = new System.Windows.Forms.ComboBox();
            this.cbDeelnemersEventbeheer = new System.Windows.Forms.ComboBox();
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
            this.materiaalTab = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPrijsVoegMateriaalToe = new System.Windows.Forms.TextBox();
            this.buttonVoegMateriaalToe = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbHuidigMateriaal = new System.Windows.Forms.ListBox();
            this.tbMateriaalToevoegen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMateriaalToevoegen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.plaatsTab = new System.Windows.Forms.TabPage();
            this.buttonVoegPlaatsToe = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbHuidigePlaatsen = new System.Windows.Forms.ListBox();
            this.nudPlaatsPersonen = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.chkPlaatsGeluidoverlast = new System.Windows.Forms.CheckBox();
            this.tbPlaatsToevoegenPrijs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPlaatsNr = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gbGebruikers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.gebruikerTab.SuspendLayout();
            this.materiaalTab.SuspendLayout();
            this.plaatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaatsPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGebruikers
            // 
            this.gbGebruikers.Controls.Add(this.btnZeker);
            this.gbGebruikers.Controls.Add(this.btnNee);
            this.gbGebruikers.Controls.Add(this.btnVerwijder);
            this.gbGebruikers.Controls.Add(this.lbGebruikerinfo);
            this.gbGebruikers.Enabled = false;
            this.gbGebruikers.Location = new System.Drawing.Point(6, 6);
            this.gbGebruikers.Name = "gbGebruikers";
            this.gbGebruikers.Size = new System.Drawing.Size(766, 290);
            this.gbGebruikers.TabIndex = 0;
            this.gbGebruikers.TabStop = false;
            this.gbGebruikers.Text = "Gebruikers";
            // 
            // btnZeker
            // 
            this.btnZeker.Location = new System.Drawing.Point(6, 48);
            this.btnZeker.Name = "btnZeker";
            this.btnZeker.Size = new System.Drawing.Size(112, 23);
            this.btnZeker.TabIndex = 4;
            this.btnZeker.Text = "Zeker?";
            this.btnZeker.UseVisualStyleBackColor = true;
            this.btnZeker.Click += new System.EventHandler(this.btnZeker_Click);
            // 
            // btnNee
            // 
            this.btnNee.Location = new System.Drawing.Point(6, 77);
            this.btnNee.Name = "btnNee";
            this.btnNee.Size = new System.Drawing.Size(112, 23);
            this.btnNee.TabIndex = 4;
            this.btnNee.Text = "Nee";
            this.btnNee.UseVisualStyleBackColor = true;
            this.btnNee.Click += new System.EventHandler(this.btnNee_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(6, 19);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(112, 23);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "Verwijder gebruiker";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lbGebruikerinfo
            // 
            this.lbGebruikerinfo.FormattingEnabled = true;
            this.lbGebruikerinfo.Location = new System.Drawing.Point(124, 19);
            this.lbGebruikerinfo.Name = "lbGebruikerinfo";
            this.lbGebruikerinfo.Size = new System.Drawing.Size(636, 264);
            this.lbGebruikerinfo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonVerwijderPlaatsen);
            this.groupBox2.Controls.Add(this.buttonVerwijderMateriaal);
            this.groupBox2.Controls.Add(this.btnDatabaseConnectie);
            this.groupBox2.Controls.Add(this.cbMateriaal);
            this.groupBox2.Controls.Add(this.cbPlaatsen);
            this.groupBox2.Controls.Add(this.cbDeelnemersEventbeheer);
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
            this.groupBox2.Size = new System.Drawing.Size(769, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EventBeheer";
            // 
            // buttonVerwijderPlaatsen
            // 
            this.buttonVerwijderPlaatsen.Location = new System.Drawing.Point(424, 196);
            this.buttonVerwijderPlaatsen.Name = "buttonVerwijderPlaatsen";
            this.buttonVerwijderPlaatsen.Size = new System.Drawing.Size(68, 23);
            this.buttonVerwijderPlaatsen.TabIndex = 7;
            this.buttonVerwijderPlaatsen.Text = "Verwijder";
            this.buttonVerwijderPlaatsen.UseVisualStyleBackColor = true;
            this.buttonVerwijderPlaatsen.Click += new System.EventHandler(this.buttonVerwijderPlaatsen_Click);
            // 
            // buttonVerwijderMateriaal
            // 
            this.buttonVerwijderMateriaal.Location = new System.Drawing.Point(424, 222);
            this.buttonVerwijderMateriaal.Name = "buttonVerwijderMateriaal";
            this.buttonVerwijderMateriaal.Size = new System.Drawing.Size(68, 23);
            this.buttonVerwijderMateriaal.TabIndex = 7;
            this.buttonVerwijderMateriaal.Text = "Verwijder";
            this.buttonVerwijderMateriaal.UseVisualStyleBackColor = true;
            this.buttonVerwijderMateriaal.Click += new System.EventHandler(this.buttonVerwijderMateriaal_Click);
            // 
            // btnDatabaseConnectie
            // 
            this.btnDatabaseConnectie.Location = new System.Drawing.Point(92, 261);
            this.btnDatabaseConnectie.Name = "btnDatabaseConnectie";
            this.btnDatabaseConnectie.Size = new System.Drawing.Size(113, 23);
            this.btnDatabaseConnectie.TabIndex = 6;
            this.btnDatabaseConnectie.Text = "Database Connectie";
            this.btnDatabaseConnectie.UseVisualStyleBackColor = true;
            this.btnDatabaseConnectie.Click += new System.EventHandler(this.btnDatabaseConnectie_Click);
            // 
            // cbMateriaal
            // 
            this.cbMateriaal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaal.Location = new System.Drawing.Point(148, 224);
            this.cbMateriaal.Name = "cbMateriaal";
            this.cbMateriaal.Size = new System.Drawing.Size(270, 21);
            this.cbMateriaal.TabIndex = 0;
            // 
            // cbPlaatsen
            // 
            this.cbPlaatsen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaatsen.Location = new System.Drawing.Point(148, 198);
            this.cbPlaatsen.Name = "cbPlaatsen";
            this.cbPlaatsen.Size = new System.Drawing.Size(270, 21);
            this.cbPlaatsen.TabIndex = 0;
            // 
            // cbDeelnemersEventbeheer
            // 
            this.cbDeelnemersEventbeheer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeelnemersEventbeheer.Location = new System.Drawing.Point(148, 174);
            this.cbDeelnemersEventbeheer.Name = "cbDeelnemersEventbeheer";
            this.cbDeelnemersEventbeheer.Size = new System.Drawing.Size(270, 21);
            this.cbDeelnemersEventbeheer.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Materiaal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Plaatsen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deelnemers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plaats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Einddatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 77);
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
            this.dtpEindDatum.Location = new System.Drawing.Point(148, 97);
            this.dtpEindDatum.MinDate = new System.DateTime(2015, 4, 14, 0, 0, 0, 0);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(270, 20);
            this.dtpEindDatum.TabIndex = 4;
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(148, 71);
            this.dtpBeginDatum.MinDate = new System.DateTime(2015, 4, 14, 0, 0, 0, 0);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(270, 20);
            this.dtpBeginDatum.TabIndex = 4;
            // 
            // btnPasEventAan
            // 
            this.btnPasEventAan.Location = new System.Drawing.Point(424, 17);
            this.btnPasEventAan.Name = "btnPasEventAan";
            this.btnPasEventAan.Size = new System.Drawing.Size(75, 23);
            this.btnPasEventAan.TabIndex = 3;
            this.btnPasEventAan.Text = "Pas aan";
            this.btnPasEventAan.UseVisualStyleBackColor = true;
            this.btnPasEventAan.Click += new System.EventHandler(this.btnPasEventAan_Click);
            // 
            // tbAdresEventbeheer
            // 
            this.tbAdresEventbeheer.Location = new System.Drawing.Point(148, 148);
            this.tbAdresEventbeheer.Name = "tbAdresEventbeheer";
            this.tbAdresEventbeheer.Size = new System.Drawing.Size(270, 20);
            this.tbAdresEventbeheer.TabIndex = 2;
            // 
            // tbEventNaamEventbeheer
            // 
            this.tbEventNaamEventbeheer.Location = new System.Drawing.Point(148, 46);
            this.tbEventNaamEventbeheer.Name = "tbEventNaamEventbeheer";
            this.tbEventNaamEventbeheer.Size = new System.Drawing.Size(270, 20);
            this.tbEventNaamEventbeheer.TabIndex = 2;
            // 
            // tbPlaatsEventbeheer
            // 
            this.tbPlaatsEventbeheer.Location = new System.Drawing.Point(148, 123);
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
            this.cbEventsEventbeheer.Size = new System.Drawing.Size(270, 21);
            this.cbEventsEventbeheer.TabIndex = 1;
            this.cbEventsEventbeheer.SelectedIndexChanged += new System.EventHandler(this.cbEvents_SelectedIndexChanged);
            // 
            // btnVerwijderEvent
            // 
            this.btnVerwijderEvent.Location = new System.Drawing.Point(505, 17);
            this.btnVerwijderEvent.Name = "btnVerwijderEvent";
            this.btnVerwijderEvent.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderEvent.TabIndex = 0;
            this.btnVerwijderEvent.Text = "Verwijderen";
            this.btnVerwijderEvent.UseVisualStyleBackColor = true;
            this.btnVerwijderEvent.Click += new System.EventHandler(this.btnVerwijderEvent_Click);
            // 
            // btnMaakEventAan
            // 
            this.btnMaakEventAan.Location = new System.Drawing.Point(11, 261);
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
            this.tabControl1.Controls.Add(this.materiaalTab);
            this.tabControl1.Controls.Add(this.plaatsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 329);
            this.tabControl1.TabIndex = 2;
            // 
            // eventTab
            // 
            this.eventTab.BackColor = System.Drawing.SystemColors.Control;
            this.eventTab.Controls.Add(this.groupBox2);
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(781, 303);
            this.eventTab.TabIndex = 0;
            this.eventTab.Text = "Event";
            this.eventTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gebruikerTab
            // 
            this.gebruikerTab.Controls.Add(this.gbGebruikers);
            this.gebruikerTab.Location = new System.Drawing.Point(4, 22);
            this.gebruikerTab.Name = "gebruikerTab";
            this.gebruikerTab.Padding = new System.Windows.Forms.Padding(3);
            this.gebruikerTab.Size = new System.Drawing.Size(781, 303);
            this.gebruikerTab.TabIndex = 1;
            this.gebruikerTab.Text = "Gebruikers verwijderen";
            // 
            // materiaalTab
            // 
            this.materiaalTab.BackColor = System.Drawing.SystemColors.Control;
            this.materiaalTab.Controls.Add(this.label16);
            this.materiaalTab.Controls.Add(this.textBoxPrijsVoegMateriaalToe);
            this.materiaalTab.Controls.Add(this.buttonVoegMateriaalToe);
            this.materiaalTab.Controls.Add(this.label12);
            this.materiaalTab.Controls.Add(this.lbHuidigMateriaal);
            this.materiaalTab.Controls.Add(this.tbMateriaalToevoegen);
            this.materiaalTab.Controls.Add(this.label11);
            this.materiaalTab.Controls.Add(this.cbMateriaalToevoegen);
            this.materiaalTab.Controls.Add(this.label9);
            this.materiaalTab.Location = new System.Drawing.Point(4, 22);
            this.materiaalTab.Name = "materiaalTab";
            this.materiaalTab.Size = new System.Drawing.Size(781, 303);
            this.materiaalTab.TabIndex = 2;
            this.materiaalTab.Text = "Materiaal Toevoegen";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Prijs: €";
            // 
            // textBoxPrijsVoegMateriaalToe
            // 
            this.textBoxPrijsVoegMateriaalToe.Location = new System.Drawing.Point(62, 65);
            this.textBoxPrijsVoegMateriaalToe.Name = "textBoxPrijsVoegMateriaalToe";
            this.textBoxPrijsVoegMateriaalToe.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrijsVoegMateriaalToe.TabIndex = 7;
            // 
            // buttonVoegMateriaalToe
            // 
            this.buttonVoegMateriaalToe.Location = new System.Drawing.Point(62, 91);
            this.buttonVoegMateriaalToe.Name = "buttonVoegMateriaalToe";
            this.buttonVoegMateriaalToe.Size = new System.Drawing.Size(121, 23);
            this.buttonVoegMateriaalToe.TabIndex = 6;
            this.buttonVoegMateriaalToe.Text = "Voeg Toe";
            this.buttonVoegMateriaalToe.UseVisualStyleBackColor = true;
            this.buttonVoegMateriaalToe.Click += new System.EventHandler(this.buttonVoegMateriaalToe_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Huidig materiaal:";
            // 
            // lbHuidigMateriaal
            // 
            this.lbHuidigMateriaal.FormattingEnabled = true;
            this.lbHuidigMateriaal.Location = new System.Drawing.Point(280, 11);
            this.lbHuidigMateriaal.Name = "lbHuidigMateriaal";
            this.lbHuidigMateriaal.Size = new System.Drawing.Size(485, 277);
            this.lbHuidigMateriaal.TabIndex = 4;
            // 
            // tbMateriaalToevoegen
            // 
            this.tbMateriaalToevoegen.Location = new System.Drawing.Point(62, 38);
            this.tbMateriaalToevoegen.Name = "tbMateriaalToevoegen";
            this.tbMateriaalToevoegen.Size = new System.Drawing.Size(121, 20);
            this.tbMateriaalToevoegen.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Naam:";
            // 
            // cbMateriaalToevoegen
            // 
            this.cbMateriaalToevoegen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriaalToevoegen.FormattingEnabled = true;
            this.cbMateriaalToevoegen.Items.AddRange(new object[] {
            "Fotocamera",
            "Videocamera"});
            this.cbMateriaalToevoegen.Location = new System.Drawing.Point(62, 11);
            this.cbMateriaalToevoegen.Name = "cbMateriaalToevoegen";
            this.cbMateriaalToevoegen.Size = new System.Drawing.Size(121, 21);
            this.cbMateriaalToevoegen.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soort:";
            // 
            // plaatsTab
            // 
            this.plaatsTab.BackColor = System.Drawing.SystemColors.Control;
            this.plaatsTab.Controls.Add(this.tbPlaatsNr);
            this.plaatsTab.Controls.Add(this.buttonVoegPlaatsToe);
            this.plaatsTab.Controls.Add(this.label15);
            this.plaatsTab.Controls.Add(this.lbHuidigePlaatsen);
            this.plaatsTab.Controls.Add(this.nudPlaatsPersonen);
            this.plaatsTab.Controls.Add(this.label17);
            this.plaatsTab.Controls.Add(this.label14);
            this.plaatsTab.Controls.Add(this.chkPlaatsGeluidoverlast);
            this.plaatsTab.Controls.Add(this.tbPlaatsToevoegenPrijs);
            this.plaatsTab.Controls.Add(this.label13);
            this.plaatsTab.Location = new System.Drawing.Point(4, 22);
            this.plaatsTab.Name = "plaatsTab";
            this.plaatsTab.Size = new System.Drawing.Size(781, 303);
            this.plaatsTab.TabIndex = 3;
            this.plaatsTab.Text = "Plaats Toevoegen";
            // 
            // buttonVoegPlaatsToe
            // 
            this.buttonVoegPlaatsToe.Location = new System.Drawing.Point(19, 123);
            this.buttonVoegPlaatsToe.Name = "buttonVoegPlaatsToe";
            this.buttonVoegPlaatsToe.Size = new System.Drawing.Size(75, 23);
            this.buttonVoegPlaatsToe.TabIndex = 7;
            this.buttonVoegPlaatsToe.Text = "Voeg Toe";
            this.buttonVoegPlaatsToe.UseVisualStyleBackColor = true;
            this.buttonVoegPlaatsToe.Click += new System.EventHandler(this.buttonVoegPlaatsToe_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(169, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Huidige plaatsen:";
            // 
            // lbHuidigePlaatsen
            // 
            this.lbHuidigePlaatsen.FormattingEnabled = true;
            this.lbHuidigePlaatsen.Location = new System.Drawing.Point(264, 18);
            this.lbHuidigePlaatsen.Name = "lbHuidigePlaatsen";
            this.lbHuidigePlaatsen.Size = new System.Drawing.Size(499, 277);
            this.lbHuidigePlaatsen.TabIndex = 5;
            // 
            // nudPlaatsPersonen
            // 
            this.nudPlaatsPersonen.Location = new System.Drawing.Point(116, 67);
            this.nudPlaatsPersonen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlaatsPersonen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlaatsPersonen.Name = "nudPlaatsPersonen";
            this.nudPlaatsPersonen.ReadOnly = true;
            this.nudPlaatsPersonen.Size = new System.Drawing.Size(47, 20);
            this.nudPlaatsPersonen.TabIndex = 4;
            this.nudPlaatsPersonen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Aantal Personen:";
            // 
            // chkPlaatsGeluidoverlast
            // 
            this.chkPlaatsGeluidoverlast.AutoSize = true;
            this.chkPlaatsGeluidoverlast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPlaatsGeluidoverlast.Location = new System.Drawing.Point(19, 44);
            this.chkPlaatsGeluidoverlast.Name = "chkPlaatsGeluidoverlast";
            this.chkPlaatsGeluidoverlast.Size = new System.Drawing.Size(120, 17);
            this.chkPlaatsGeluidoverlast.TabIndex = 2;
            this.chkPlaatsGeluidoverlast.Text = "Veel geluidsoverlast";
            this.chkPlaatsGeluidoverlast.UseVisualStyleBackColor = true;
            // 
            // tbPlaatsToevoegenPrijs
            // 
            this.tbPlaatsToevoegenPrijs.Location = new System.Drawing.Point(62, 18);
            this.tbPlaatsToevoegenPrijs.Name = "tbPlaatsToevoegenPrijs";
            this.tbPlaatsToevoegenPrijs.Size = new System.Drawing.Size(101, 20);
            this.tbPlaatsToevoegenPrijs.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Prijs:   €";
            // 
            // tbPlaatsNr
            // 
            this.tbPlaatsNr.Location = new System.Drawing.Point(116, 93);
            this.tbPlaatsNr.MaxLength = 4;
            this.tbPlaatsNr.Name = "tbPlaatsNr";
            this.tbPlaatsNr.Size = new System.Drawing.Size(47, 20);
            this.tbPlaatsNr.TabIndex = 8;
            this.tbPlaatsNr.Text = "1234";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "PlaatsNummer";
            // 
            // EventBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 346);
            this.Controls.Add(this.tabControl1);
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
            this.materiaalTab.ResumeLayout(false);
            this.materiaalTab.PerformLayout();
            this.plaatsTab.ResumeLayout(false);
            this.plaatsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlaatsPersonen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGebruikers;
        private System.Windows.Forms.ListBox lbGebruikerinfo;
        private System.Windows.Forms.Button btnZeker;
        private System.Windows.Forms.Button btnNee;
        private System.Windows.Forms.Button btnVerwijder;
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
        private System.Windows.Forms.ComboBox cbMateriaal;
        private System.Windows.Forms.ComboBox cbPlaatsen;
        private System.Windows.Forms.ComboBox cbDeelnemersEventbeheer;
        private System.Windows.Forms.TextBox tbAdresEventbeheer;
        private System.Windows.Forms.TextBox tbPlaatsEventbeheer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEventNaam;
        private System.Windows.Forms.TextBox tbEventNaamEventbeheer;
        private System.Windows.Forms.Button btnDatabaseConnectie;
        private System.Windows.Forms.Button buttonVerwijderPlaatsen;
        private System.Windows.Forms.Button buttonVerwijderMateriaal;
        private System.Windows.Forms.TabPage materiaalTab;
        private System.Windows.Forms.Button buttonVoegMateriaalToe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbHuidigMateriaal;
        private System.Windows.Forms.TextBox tbMateriaalToevoegen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMateriaalToevoegen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage plaatsTab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPlaatsToevoegenPrijs;
        private System.Windows.Forms.CheckBox chkPlaatsGeluidoverlast;
        private System.Windows.Forms.NumericUpDown nudPlaatsPersonen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbHuidigePlaatsen;
        private System.Windows.Forms.Button buttonVoegPlaatsToe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPrijsVoegMateriaalToe;
        private System.Windows.Forms.TextBox tbPlaatsNr;
        private System.Windows.Forms.Label label17;
    }
}