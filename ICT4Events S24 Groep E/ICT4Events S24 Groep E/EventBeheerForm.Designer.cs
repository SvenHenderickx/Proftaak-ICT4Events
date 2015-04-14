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
            this.btnInfoOpvraag = new System.Windows.Forms.Button();
            this.lbGebruikerinfo = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.cbGebruiker = new System.Windows.Forms.ComboBox();
            this.btnNee = new System.Windows.Forms.Button();
            this.btnZeker = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZeker);
            this.groupBox1.Controls.Add(this.btnNee);
            this.groupBox1.Controls.Add(this.cbGebruiker);
            this.groupBox1.Controls.Add(this.btnVerwijder);
            this.groupBox1.Controls.Add(this.lbGebruikerinfo);
            this.groupBox1.Controls.Add(this.btnInfoOpvraag);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gebruikers";
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
            // lbGebruikerinfo
            // 
            this.lbGebruikerinfo.FormattingEnabled = true;
            this.lbGebruikerinfo.Location = new System.Drawing.Point(218, 19);
            this.lbGebruikerinfo.Name = "lbGebruikerinfo";
            this.lbGebruikerinfo.Size = new System.Drawing.Size(542, 199);
            this.lbGebruikerinfo.TabIndex = 1;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(6, 276);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(121, 23);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "verwijder gebruiker";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // cbGebruiker
            // 
            this.cbGebruiker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGebruiker.FormattingEnabled = true;
            this.cbGebruiker.Location = new System.Drawing.Point(134, 276);
            this.cbGebruiker.Name = "cbGebruiker";
            this.cbGebruiker.Size = new System.Drawing.Size(421, 21);
            this.cbGebruiker.TabIndex = 3;
            // 
            // btnNee
            // 
            this.btnNee.Location = new System.Drawing.Point(642, 274);
            this.btnNee.Name = "btnNee";
            this.btnNee.Size = new System.Drawing.Size(75, 23);
            this.btnNee.TabIndex = 4;
            this.btnNee.Text = "Nee";
            this.btnNee.UseVisualStyleBackColor = true;
            this.btnNee.Click += new System.EventHandler(this.btnNee_Click);
            // 
            // btnZeker
            // 
            this.btnZeker.Location = new System.Drawing.Point(561, 274);
            this.btnZeker.Name = "btnZeker";
            this.btnZeker.Size = new System.Drawing.Size(75, 23);
            this.btnZeker.TabIndex = 4;
            this.btnZeker.Text = "Zeker?";
            this.btnZeker.UseVisualStyleBackColor = true;
            this.btnZeker.Click += new System.EventHandler(this.btnZeker_Click);
            // 
            // EventBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 511);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventBeheerForm";
            this.Text = "EventBeheerForm";
            this.groupBox1.ResumeLayout(false);
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
    }
}