namespace ICT4Events_S24_Groep_E
{
    partial class SysteemKiezerForm
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
            this.btnEventBeheerSysteemKiezerForm = new System.Windows.Forms.Button();
            this.btnToegangsControleSysteemKiezerForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMediaSharingSysteemKiezerForm = new System.Windows.Forms.Button();
            this.lblEventSysteemKiezerForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEventBeheerSysteemKiezerForm
            // 
            this.btnEventBeheerSysteemKiezerForm.Location = new System.Drawing.Point(13, 39);
            this.btnEventBeheerSysteemKiezerForm.Name = "btnEventBeheerSysteemKiezerForm";
            this.btnEventBeheerSysteemKiezerForm.Size = new System.Drawing.Size(202, 23);
            this.btnEventBeheerSysteemKiezerForm.TabIndex = 0;
            this.btnEventBeheerSysteemKiezerForm.Text = "Event Beheer";
            this.btnEventBeheerSysteemKiezerForm.UseVisualStyleBackColor = true;
            this.btnEventBeheerSysteemKiezerForm.Click += new System.EventHandler(this.btnEventBeheerSysteemKiezerForm_Click);
            // 
            // btnToegangsControleSysteemKiezerForm
            // 
            this.btnToegangsControleSysteemKiezerForm.Location = new System.Drawing.Point(13, 68);
            this.btnToegangsControleSysteemKiezerForm.Name = "btnToegangsControleSysteemKiezerForm";
            this.btnToegangsControleSysteemKiezerForm.Size = new System.Drawing.Size(202, 23);
            this.btnToegangsControleSysteemKiezerForm.TabIndex = 1;
            this.btnToegangsControleSysteemKiezerForm.Text = "Toegangs Controle";
            this.btnToegangsControleSysteemKiezerForm.UseVisualStyleBackColor = true;
            this.btnToegangsControleSysteemKiezerForm.Click += new System.EventHandler(this.btnToegangsControleSysteemKiezerForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inschrijving";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMediaSharingSysteemKiezerForm
            // 
            this.btnMediaSharingSysteemKiezerForm.Location = new System.Drawing.Point(13, 126);
            this.btnMediaSharingSysteemKiezerForm.Name = "btnMediaSharingSysteemKiezerForm";
            this.btnMediaSharingSysteemKiezerForm.Size = new System.Drawing.Size(202, 23);
            this.btnMediaSharingSysteemKiezerForm.TabIndex = 3;
            this.btnMediaSharingSysteemKiezerForm.Text = "Media Sharing";
            this.btnMediaSharingSysteemKiezerForm.UseVisualStyleBackColor = true;
            this.btnMediaSharingSysteemKiezerForm.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblEventSysteemKiezerForm
            // 
            this.lblEventSysteemKiezerForm.AutoSize = true;
            this.lblEventSysteemKiezerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventSysteemKiezerForm.Location = new System.Drawing.Point(12, 19);
            this.lblEventSysteemKiezerForm.Name = "lblEventSysteemKiezerForm";
            this.lblEventSysteemKiezerForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEventSysteemKiezerForm.Size = new System.Drawing.Size(43, 17);
            this.lblEventSysteemKiezerForm.TabIndex = 4;
            this.lblEventSysteemKiezerForm.Text = "event";
            // 
            // SysteemKiezerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.lblEventSysteemKiezerForm);
            this.Controls.Add(this.btnMediaSharingSysteemKiezerForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnToegangsControleSysteemKiezerForm);
            this.Controls.Add(this.btnEventBeheerSysteemKiezerForm);
            this.Name = "SysteemKiezerForm";
            this.Text = "Kies Systeem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerugNaarLogin);
            this.Load += new System.EventHandler(this.SysteemKiezerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventBeheerSysteemKiezerForm;
        private System.Windows.Forms.Button btnToegangsControleSysteemKiezerForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMediaSharingSysteemKiezerForm;
        private System.Windows.Forms.Label lblEventSysteemKiezerForm;
    }
}