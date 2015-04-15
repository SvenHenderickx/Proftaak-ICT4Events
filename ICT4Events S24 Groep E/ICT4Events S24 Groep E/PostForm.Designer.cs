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
            this.lblGebNaam = new System.Windows.Forms.Label();
            this.lblBerichtTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGebNaam
            // 
            this.lblGebNaam.AutoSize = true;
            this.lblGebNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebNaam.Location = new System.Drawing.Point(13, 13);
            this.lblGebNaam.Name = "lblGebNaam";
            this.lblGebNaam.Size = new System.Drawing.Size(74, 13);
            this.lblGebNaam.TabIndex = 0;
            this.lblGebNaam.Text = "<gebNaam>";
            // 
            // lblBerichtTekst
            // 
            this.lblBerichtTekst.AutoSize = true;
            this.lblBerichtTekst.Location = new System.Drawing.Point(16, 30);
            this.lblBerichtTekst.Name = "lblBerichtTekst";
            this.lblBerichtTekst.Size = new System.Drawing.Size(42, 13);
            this.lblBerichtTekst.TabIndex = 1;
            this.lblBerichtTekst.Text = "<tekst>";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 154);
            this.Controls.Add(this.lblBerichtTekst);
            this.Controls.Add(this.lblGebNaam);
            this.Name = "PostForm";
            this.Text = "Bericht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGebNaam;
        private System.Windows.Forms.Label lblBerichtTekst;
    }
}