namespace ICT4Events_S24_Groep_E
{
    partial class MateriaalVerhuurForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaalVerhuurForm));
            this.lblBoekerBezoekerInfo = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbGekozenItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHuurItems = new System.Windows.Forms.ComboBox();
            this.btnHuurItemKies = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBoekerBezoekerInfo
            // 
            this.lblBoekerBezoekerInfo.AutoSize = true;
            this.lblBoekerBezoekerInfo.Location = new System.Drawing.Point(449, 270);
            this.lblBoekerBezoekerInfo.Name = "lblBoekerBezoekerInfo";
            this.lblBoekerBezoekerInfo.Size = new System.Drawing.Size(46, 17);
            this.lblBoekerBezoekerInfo.TabIndex = 13;
            this.lblBoekerBezoekerInfo.Text = "label4";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(12, 244);
            this.btnBevestig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(99, 44);
            this.btnBevestig.TabIndex = 12;
            this.btnBevestig.Text = "Bevestigen";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(827, 244);
            this.btnAnnuleren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(99, 44);
            this.btnAnnuleren.TabIndex = 11;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(827, 180);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(99, 44);
            this.btnVerwijder.TabIndex = 10;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lbGekozenItems
            // 
            this.lbGekozenItems.FormattingEnabled = true;
            this.lbGekozenItems.ItemHeight = 16;
            this.lbGekozenItems.Location = new System.Drawing.Point(468, 44);
            this.lbGekozenItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbGekozenItems.Name = "lbGekozenItems";
            this.lbGekozenItems.Size = new System.Drawing.Size(343, 180);
            this.lbGekozenItems.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gekozen Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbHuurItems);
            this.groupBox1.Controls.Add(this.btnHuurItemKies);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(397, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecteer je huuritem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Huuritems";
            // 
            // cbHuurItems
            // 
            this.cbHuurItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHuurItems.FormattingEnabled = true;
            this.cbHuurItems.Location = new System.Drawing.Point(17, 96);
            this.cbHuurItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHuurItems.Name = "cbHuurItems";
            this.cbHuurItems.Size = new System.Drawing.Size(133, 24);
            this.cbHuurItems.TabIndex = 3;
            // 
            // btnHuurItemKies
            // 
            this.btnHuurItemKies.Location = new System.Drawing.Point(257, 89);
            this.btnHuurItemKies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuurItemKies.Name = "btnHuurItemKies";
            this.btnHuurItemKies.Size = new System.Drawing.Size(95, 33);
            this.btnHuurItemKies.TabIndex = 1;
            this.btnHuurItemKies.Text = "Kies";
            this.btnHuurItemKies.UseVisualStyleBackColor = true;
            this.btnHuurItemKies.Click += new System.EventHandler(this.btnVideoKies_Click);
            // 
            // MateriaalVerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 314);
            this.Controls.Add(this.lblBoekerBezoekerInfo);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lbGekozenItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MateriaalVerhuurForm";
            this.Text = "Materiaal Verhuur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MateriaalVerhuurForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoekerBezoekerInfo;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ListBox lbGekozenItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHuurItems;
        private System.Windows.Forms.Button btnHuurItemKies;
    }
}