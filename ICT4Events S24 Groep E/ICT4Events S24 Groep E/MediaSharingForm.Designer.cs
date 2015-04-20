namespace ICT4Events_S24_Groep_E
{
    partial class MediaSharingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMuziek = new System.Windows.Forms.RadioButton();
            this.rbVideos = new System.Windows.Forms.RadioButton();
            this.rbFotos = new System.Windows.Forms.RadioButton();
            this.rbBerichten = new System.Windows.Forms.RadioButton();
            this.rbAlles = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPostPlaatsenMediaSharingForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPostTekstMediaSharingForm = new System.Windows.Forms.TextBox();
            this.gbZoeken = new System.Windows.Forms.GroupBox();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.tbZoeken = new System.Windows.Forms.TextBox();
            this.lbBerichtenMediaSharingForm = new System.Windows.Forms.ListBox();
            this.btnLikeMediaSharing = new System.Windows.Forms.Button();
            this.btnMeerMediaSharingForm = new System.Windows.Forms.Button();
            this.btnVerwijderBericht = new System.Windows.Forms.Button();
            this.btnGerapporteerdeBerichten = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbZoeken.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMuziek);
            this.groupBox1.Controls.Add(this.rbVideos);
            this.groupBox1.Controls.Add(this.rbFotos);
            this.groupBox1.Controls.Add(this.rbBerichten);
            this.groupBox1.Controls.Add(this.rbAlles);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // rbMuziek
            // 
            this.rbMuziek.AutoSize = true;
            this.rbMuziek.Location = new System.Drawing.Point(259, 19);
            this.rbMuziek.Name = "rbMuziek";
            this.rbMuziek.Size = new System.Drawing.Size(59, 17);
            this.rbMuziek.TabIndex = 2;
            this.rbMuziek.TabStop = true;
            this.rbMuziek.Text = "Muziek";
            this.rbMuziek.UseVisualStyleBackColor = true;
            // 
            // rbVideos
            // 
            this.rbVideos.AutoSize = true;
            this.rbVideos.Location = new System.Drawing.Point(194, 19);
            this.rbVideos.Name = "rbVideos";
            this.rbVideos.Size = new System.Drawing.Size(59, 17);
            this.rbVideos.TabIndex = 2;
            this.rbVideos.TabStop = true;
            this.rbVideos.Text = "Video\'s";
            this.rbVideos.UseVisualStyleBackColor = true;
            // 
            // rbFotos
            // 
            this.rbFotos.AutoSize = true;
            this.rbFotos.Location = new System.Drawing.Point(135, 19);
            this.rbFotos.Name = "rbFotos";
            this.rbFotos.Size = new System.Drawing.Size(53, 17);
            this.rbFotos.TabIndex = 2;
            this.rbFotos.TabStop = true;
            this.rbFotos.Text = "Foto\'s";
            this.rbFotos.UseVisualStyleBackColor = true;
            this.rbFotos.CheckedChanged += new System.EventHandler(this.rbFotos_CheckedChanged);
            // 
            // rbBerichten
            // 
            this.rbBerichten.AutoSize = true;
            this.rbBerichten.Location = new System.Drawing.Point(59, 19);
            this.rbBerichten.Name = "rbBerichten";
            this.rbBerichten.Size = new System.Drawing.Size(70, 17);
            this.rbBerichten.TabIndex = 1;
            this.rbBerichten.TabStop = true;
            this.rbBerichten.Text = "Berichten";
            this.rbBerichten.UseVisualStyleBackColor = true;
            this.rbBerichten.CheckedChanged += new System.EventHandler(this.rbBerichten_CheckedChanged);
            // 
            // rbAlles
            // 
            this.rbAlles.AutoSize = true;
            this.rbAlles.Location = new System.Drawing.Point(6, 19);
            this.rbAlles.Name = "rbAlles";
            this.rbAlles.Size = new System.Drawing.Size(47, 17);
            this.rbAlles.TabIndex = 0;
            this.rbAlles.TabStop = true;
            this.rbAlles.Text = "Alles";
            this.rbAlles.UseVisualStyleBackColor = true;
            this.rbAlles.CheckedChanged += new System.EventHandler(this.rbAlles_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPostPlaatsenMediaSharingForm);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbPostTekstMediaSharingForm);
            this.groupBox2.Location = new System.Drawing.Point(355, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nieuwe Post";
            // 
            // btnPostPlaatsenMediaSharingForm
            // 
            this.btnPostPlaatsenMediaSharingForm.Location = new System.Drawing.Point(7, 104);
            this.btnPostPlaatsenMediaSharingForm.Name = "btnPostPlaatsenMediaSharingForm";
            this.btnPostPlaatsenMediaSharingForm.Size = new System.Drawing.Size(208, 23);
            this.btnPostPlaatsenMediaSharingForm.TabIndex = 2;
            this.btnPostPlaatsenMediaSharingForm.Text = "Plaats post";
            this.btnPostPlaatsenMediaSharingForm.UseVisualStyleBackColor = true;
            this.btnPostPlaatsenMediaSharingForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload Bestand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPostTekstMediaSharingForm
            // 
            this.tbPostTekstMediaSharingForm.Location = new System.Drawing.Point(7, 20);
            this.tbPostTekstMediaSharingForm.Multiline = true;
            this.tbPostTekstMediaSharingForm.Name = "tbPostTekstMediaSharingForm";
            this.tbPostTekstMediaSharingForm.Size = new System.Drawing.Size(208, 53);
            this.tbPostTekstMediaSharingForm.TabIndex = 0;
            // 
            // gbZoeken
            // 
            this.gbZoeken.Controls.Add(this.btnZoeken);
            this.gbZoeken.Controls.Add(this.tbZoeken);
            this.gbZoeken.Location = new System.Drawing.Point(355, 153);
            this.gbZoeken.Name = "gbZoeken";
            this.gbZoeken.Size = new System.Drawing.Size(221, 78);
            this.gbZoeken.TabIndex = 2;
            this.gbZoeken.TabStop = false;
            this.gbZoeken.Text = "Zoeken";
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(7, 47);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(208, 23);
            this.btnZoeken.TabIndex = 1;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbZoeken
            // 
            this.tbZoeken.Location = new System.Drawing.Point(7, 20);
            this.tbZoeken.Name = "tbZoeken";
            this.tbZoeken.Size = new System.Drawing.Size(208, 20);
            this.tbZoeken.TabIndex = 0;
            this.tbZoeken.TextChanged += new System.EventHandler(this.LiveUpdate);
            // 
            // lbBerichtenMediaSharingForm
            // 
            this.lbBerichtenMediaSharingForm.FormattingEnabled = true;
            this.lbBerichtenMediaSharingForm.Location = new System.Drawing.Point(12, 69);
            this.lbBerichtenMediaSharingForm.Name = "lbBerichtenMediaSharingForm";
            this.lbBerichtenMediaSharingForm.Size = new System.Drawing.Size(336, 212);
            this.lbBerichtenMediaSharingForm.TabIndex = 3;
            // 
            // btnLikeMediaSharing
            // 
            this.btnLikeMediaSharing.Location = new System.Drawing.Point(12, 287);
            this.btnLikeMediaSharing.Name = "btnLikeMediaSharing";
            this.btnLikeMediaSharing.Size = new System.Drawing.Size(170, 30);
            this.btnLikeMediaSharing.TabIndex = 4;
            this.btnLikeMediaSharing.Text = "Like";
            this.btnLikeMediaSharing.UseVisualStyleBackColor = true;
            this.btnLikeMediaSharing.Click += new System.EventHandler(this.btnLikeMediaSharing_Click);
            // 
            // btnMeerMediaSharingForm
            // 
            this.btnMeerMediaSharingForm.Location = new System.Drawing.Point(188, 287);
            this.btnMeerMediaSharingForm.Name = "btnMeerMediaSharingForm";
            this.btnMeerMediaSharingForm.Size = new System.Drawing.Size(160, 30);
            this.btnMeerMediaSharingForm.TabIndex = 5;
            this.btnMeerMediaSharingForm.Text = "Reageer en meer";
            this.btnMeerMediaSharingForm.UseVisualStyleBackColor = true;
            this.btnMeerMediaSharingForm.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVerwijderBericht
            // 
            this.btnVerwijderBericht.Location = new System.Drawing.Point(355, 238);
            this.btnVerwijderBericht.Name = "btnVerwijderBericht";
            this.btnVerwijderBericht.Size = new System.Drawing.Size(221, 23);
            this.btnVerwijderBericht.TabIndex = 6;
            this.btnVerwijderBericht.Text = "Verwijder Bericht";
            this.btnVerwijderBericht.UseVisualStyleBackColor = true;
            this.btnVerwijderBericht.Click += new System.EventHandler(this.btnVerwijderBericht_Click);
            // 
            // btnGerapporteerdeBerichten
            // 
            this.btnGerapporteerdeBerichten.Location = new System.Drawing.Point(355, 267);
            this.btnGerapporteerdeBerichten.Name = "btnGerapporteerdeBerichten";
            this.btnGerapporteerdeBerichten.Size = new System.Drawing.Size(221, 23);
            this.btnGerapporteerdeBerichten.TabIndex = 7;
            this.btnGerapporteerdeBerichten.Text = "Gerapporteerde Berichten";
            this.btnGerapporteerdeBerichten.UseVisualStyleBackColor = true;
            this.btnGerapporteerdeBerichten.Click += new System.EventHandler(this.btnGerapporteerdeBerichten_Click);
            // 
            // MediaSharingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 329);
            this.Controls.Add(this.btnGerapporteerdeBerichten);
            this.Controls.Add(this.btnVerwijderBericht);
            this.Controls.Add(this.btnMeerMediaSharingForm);
            this.Controls.Add(this.btnLikeMediaSharing);
            this.Controls.Add(this.lbBerichtenMediaSharingForm);
            this.Controls.Add(this.gbZoeken);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MediaSharingForm";
            this.Text = "MediaSharing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MediaSharingAfsluiten);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbZoeken.ResumeLayout(false);
            this.gbZoeken.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMuziek;
        private System.Windows.Forms.RadioButton rbVideos;
        private System.Windows.Forms.RadioButton rbFotos;
        private System.Windows.Forms.RadioButton rbBerichten;
        private System.Windows.Forms.RadioButton rbAlles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPostPlaatsenMediaSharingForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPostTekstMediaSharingForm;
        private System.Windows.Forms.GroupBox gbZoeken;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox tbZoeken;
        private System.Windows.Forms.ListBox lbBerichtenMediaSharingForm;
        private System.Windows.Forms.Button btnLikeMediaSharing;
        private System.Windows.Forms.Button btnMeerMediaSharingForm;
        private System.Windows.Forms.Button btnVerwijderBericht;
        private System.Windows.Forms.Button btnGerapporteerdeBerichten;
    }
}