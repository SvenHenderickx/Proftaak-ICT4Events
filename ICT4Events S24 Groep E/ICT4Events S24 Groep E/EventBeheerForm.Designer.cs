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
            this.btnZeker = new System.Windows.Forms.Button();
            this.btnNee = new System.Windows.Forms.Button();
            this.cbGebruiker = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbGebruikerinfo = new System.Windows.Forms.ListBox();
            this.btnInfoOpvraag = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPlaats = new System.Windows.Forms.ComboBox();
            this.btnMaakEventAan = new System.Windows.Forms.Button();
            this.btnVerwijderEvent = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.gebruikerTab = new System.Windows.Forms.TabPage();
            this.cb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPasEventAan = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnPasEventAan);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.cb);
            this.groupBox2.Controls.Add(this.btnVerwijderEvent);
            this.groupBox2.Controls.Add(this.btnMaakEventAan);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EventBeheer";
            // 
            // cbPlaats
            // 
            this.cbPlaats.FormattingEnabled = true;
            this.cbPlaats.Location = new System.Drawing.Point(5, 254);
            this.cbPlaats.Name = "cbPlaats";
            this.cbPlaats.Size = new System.Drawing.Size(121, 21);
            this.cbPlaats.TabIndex = 5;
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
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(148, 19);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(448, 21);
            this.cb.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 46);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 4, 14, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 72);
            this.dateTimePicker2.MinDate = new System.DateTime(2015, 4, 14, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start datum";
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
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPasEventAan;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}