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
            this.lblBoekerBezoekerInfo = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lbGekozenItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVideoCamera = new System.Windows.Forms.ComboBox();
            this.cbFotoCamera = new System.Windows.Forms.ComboBox();
            this.btnVideoKies = new System.Windows.Forms.Button();
            this.btnFotoKies = new System.Windows.Forms.Button();
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
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(98, 44);
            this.btnBevestig.TabIndex = 12;
            this.btnBevestig.Text = "Bevestigen";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(826, 244);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(98, 44);
            this.btnAnnuleren.TabIndex = 11;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(826, 180);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(98, 44);
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
            this.lbGekozenItems.Name = "lbGekozenItems";
            this.lbGekozenItems.Size = new System.Drawing.Size(343, 180);
            this.lbGekozenItems.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gekozen Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbVideoCamera);
            this.groupBox1.Controls.Add(this.cbFotoCamera);
            this.groupBox1.Controls.Add(this.btnVideoKies);
            this.groupBox1.Controls.Add(this.btnFotoKies);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecteer je huuritem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Videocamera\'s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fotocamera\'s";
            // 
            // cbVideoCamera
            // 
            this.cbVideoCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoCamera.FormattingEnabled = true;
            this.cbVideoCamera.Location = new System.Drawing.Point(21, 141);
            this.cbVideoCamera.Name = "cbVideoCamera";
            this.cbVideoCamera.Size = new System.Drawing.Size(133, 24);
            this.cbVideoCamera.TabIndex = 3;
            // 
            // cbFotoCamera
            // 
            this.cbFotoCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFotoCamera.FormattingEnabled = true;
            this.cbFotoCamera.Location = new System.Drawing.Point(21, 62);
            this.cbFotoCamera.Name = "cbFotoCamera";
            this.cbFotoCamera.Size = new System.Drawing.Size(133, 24);
            this.cbFotoCamera.TabIndex = 2;
            // 
            // btnVideoKies
            // 
            this.btnVideoKies.Location = new System.Drawing.Point(261, 136);
            this.btnVideoKies.Name = "btnVideoKies";
            this.btnVideoKies.Size = new System.Drawing.Size(95, 33);
            this.btnVideoKies.TabIndex = 1;
            this.btnVideoKies.Text = "Kies";
            this.btnVideoKies.UseVisualStyleBackColor = true;
            this.btnVideoKies.Click += new System.EventHandler(this.btnVideoKies_Click);
            // 
            // btnFotoKies
            // 
            this.btnFotoKies.Location = new System.Drawing.Point(261, 57);
            this.btnFotoKies.Name = "btnFotoKies";
            this.btnFotoKies.Size = new System.Drawing.Size(95, 33);
            this.btnFotoKies.TabIndex = 0;
            this.btnFotoKies.Text = "Kies";
            this.btnFotoKies.UseVisualStyleBackColor = true;
            this.btnFotoKies.Click += new System.EventHandler(this.btnFotoKies_Click);
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
            this.Name = "MateriaalVerhuurForm";
            this.Text = "Materiaal Verhuur";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVideoCamera;
        private System.Windows.Forms.ComboBox cbFotoCamera;
        private System.Windows.Forms.Button btnVideoKies;
        private System.Windows.Forms.Button btnFotoKies;
    }
}