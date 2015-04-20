namespace ICT4Events_S24_Groep_E
{
    partial class PostForm
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
            this.lblBerichtTekst = new System.Windows.Forms.Label();
            this.gbGebnaam = new System.Windows.Forms.GroupBox();
            this.lbLikes = new System.Windows.Forms.Label();
            this.lbDatum = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnPlaatsReactie = new System.Windows.Forms.Button();
            this.tbReactieTekst = new System.Windows.Forms.TextBox();
            this.lbReacties = new System.Windows.Forms.ListBox();
            this.btnRapporteer = new System.Windows.Forms.Button();
            this.btnReactieVerwijderen = new System.Windows.Forms.Button();
            this.btnBerichtVerwijderen = new System.Windows.Forms.Button();
            this.gbGebnaam.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBerichtTekst
            // 
            this.lblBerichtTekst.AutoSize = true;
            this.lblBerichtTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBerichtTekst.Location = new System.Drawing.Point(6, 16);
            this.lblBerichtTekst.Name = "lblBerichtTekst";
            this.lblBerichtTekst.Size = new System.Drawing.Size(42, 13);
            this.lblBerichtTekst.TabIndex = 1;
            this.lblBerichtTekst.Text = "<tekst>";
            // 
            // gbGebnaam
            // 
            this.gbGebnaam.Controls.Add(this.lblBerichtTekst);
            this.gbGebnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGebnaam.Location = new System.Drawing.Point(12, 12);
            this.gbGebnaam.Name = "gbGebnaam";
            this.gbGebnaam.Size = new System.Drawing.Size(297, 44);
            this.gbGebnaam.TabIndex = 2;
            this.gbGebnaam.TabStop = false;
            this.gbGebnaam.Text = "<gebnaam>";
            // 
            // lbLikes
            // 
            this.lbLikes.AutoSize = true;
            this.lbLikes.Location = new System.Drawing.Point(18, 59);
            this.lbLikes.Name = "lbLikes";
            this.lbLikes.Size = new System.Drawing.Size(40, 13);
            this.lbLikes.TabIndex = 3;
            this.lbLikes.Text = "<likes>";
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Location = new System.Drawing.Point(169, 59);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(48, 13);
            this.lbDatum.TabIndex = 4;
            this.lbDatum.Text = "<datum>";
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(13, 80);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(204, 23);
            this.btnLike.TabIndex = 5;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnPlaatsReactie
            // 
            this.btnPlaatsReactie.Location = new System.Drawing.Point(223, 109);
            this.btnPlaatsReactie.Name = "btnPlaatsReactie";
            this.btnPlaatsReactie.Size = new System.Drawing.Size(86, 23);
            this.btnPlaatsReactie.TabIndex = 6;
            this.btnPlaatsReactie.Text = "Plaats";
            this.btnPlaatsReactie.UseVisualStyleBackColor = true;
            this.btnPlaatsReactie.Click += new System.EventHandler(this.btnPlaatsReactie_Click);
            // 
            // tbReactieTekst
            // 
            this.tbReactieTekst.Location = new System.Drawing.Point(13, 109);
            this.tbReactieTekst.Multiline = true;
            this.tbReactieTekst.Name = "tbReactieTekst";
            this.tbReactieTekst.Size = new System.Drawing.Size(204, 23);
            this.tbReactieTekst.TabIndex = 7;
            // 
            // lbReacties
            // 
            this.lbReacties.FormattingEnabled = true;
            this.lbReacties.Location = new System.Drawing.Point(12, 138);
            this.lbReacties.Name = "lbReacties";
            this.lbReacties.Size = new System.Drawing.Size(296, 121);
            this.lbReacties.TabIndex = 8;
            // 
            // btnRapporteer
            // 
            this.btnRapporteer.Location = new System.Drawing.Point(223, 80);
            this.btnRapporteer.Name = "btnRapporteer";
            this.btnRapporteer.Size = new System.Drawing.Size(86, 23);
            this.btnRapporteer.TabIndex = 9;
            this.btnRapporteer.Text = "Rapporteer";
            this.btnRapporteer.UseVisualStyleBackColor = true;
            this.btnRapporteer.Click += new System.EventHandler(this.btnRapporteer_Click);
            // 
            // btnReactieVerwijderen
            // 
            this.btnReactieVerwijderen.Location = new System.Drawing.Point(12, 264);
            this.btnReactieVerwijderen.Name = "btnReactieVerwijderen";
            this.btnReactieVerwijderen.Size = new System.Drawing.Size(144, 24);
            this.btnReactieVerwijderen.TabIndex = 10;
            this.btnReactieVerwijderen.Text = "Verwijder Reactie";
            this.btnReactieVerwijderen.UseVisualStyleBackColor = true;
            this.btnReactieVerwijderen.Click += new System.EventHandler(this.btnReactieVerwijderen_Click);
            // 
            // btnBerichtVerwijderen
            // 
            this.btnBerichtVerwijderen.Location = new System.Drawing.Point(172, 264);
            this.btnBerichtVerwijderen.Name = "btnBerichtVerwijderen";
            this.btnBerichtVerwijderen.Size = new System.Drawing.Size(137, 23);
            this.btnBerichtVerwijderen.TabIndex = 11;
            this.btnBerichtVerwijderen.Text = "Verwijder Bericht";
            this.btnBerichtVerwijderen.UseVisualStyleBackColor = true;
            this.btnBerichtVerwijderen.Click += new System.EventHandler(this.btnBerichtVerwijderen_Click);
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 295);
            this.Controls.Add(this.btnBerichtVerwijderen);
            this.Controls.Add(this.btnReactieVerwijderen);
            this.Controls.Add(this.btnRapporteer);
            this.Controls.Add(this.lbReacties);
            this.Controls.Add(this.tbReactieTekst);
            this.Controls.Add(this.btnPlaatsReactie);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lbDatum);
            this.Controls.Add(this.lbLikes);
            this.Controls.Add(this.gbGebnaam);
            this.Name = "PostForm";
            this.Text = "Bericht";
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.gbGebnaam.ResumeLayout(false);
            this.gbGebnaam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBerichtTekst;
        private System.Windows.Forms.GroupBox gbGebnaam;
        private System.Windows.Forms.Label lbLikes;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnPlaatsReactie;
        private System.Windows.Forms.TextBox tbReactieTekst;
        private System.Windows.Forms.ListBox lbReacties;
        private System.Windows.Forms.Button btnRapporteer;
        private System.Windows.Forms.Button btnReactieVerwijderen;
        private System.Windows.Forms.Button btnBerichtVerwijderen;
    }
}