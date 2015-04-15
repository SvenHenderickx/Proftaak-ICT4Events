namespace ICT4Events_S24_Groep_E
{
    partial class LoginForm
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
            this.tbGebRfidLoginForm = new System.Windows.Forms.TextBox();
            this.tbWachtwoordLoginForm = new System.Windows.Forms.TextBox();
            this.btnInlogLoginForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEventsLoginForm = new System.Windows.Forms.ComboBox();
            this.btnInschrijvenInloggenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGebRfidLoginForm
            // 
            this.tbGebRfidLoginForm.Location = new System.Drawing.Point(12, 51);
            this.tbGebRfidLoginForm.Name = "tbGebRfidLoginForm";
            this.tbGebRfidLoginForm.Size = new System.Drawing.Size(222, 20);
            this.tbGebRfidLoginForm.TabIndex = 0;
            // 
            // tbWachtwoordLoginForm
            // 
            this.tbWachtwoordLoginForm.Location = new System.Drawing.Point(12, 90);
            this.tbWachtwoordLoginForm.Name = "tbWachtwoordLoginForm";
            this.tbWachtwoordLoginForm.PasswordChar = '*';
            this.tbWachtwoordLoginForm.Size = new System.Drawing.Size(221, 20);
            this.tbWachtwoordLoginForm.TabIndex = 1;
            this.tbWachtwoordLoginForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbWachtwoordLoginForm_KeyDown);
            // 
            // btnInlogLoginForm
            // 
            this.btnInlogLoginForm.Location = new System.Drawing.Point(12, 116);
            this.btnInlogLoginForm.Name = "btnInlogLoginForm";
            this.btnInlogLoginForm.Size = new System.Drawing.Size(221, 29);
            this.btnInlogLoginForm.TabIndex = 2;
            this.btnInlogLoginForm.Text = "Inloggen";
            this.btnInlogLoginForm.UseVisualStyleBackColor = true;
            this.btnInlogLoginForm.Click += new System.EventHandler(this.btnInlogLoginForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gebruikersnaam / RFID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wachtwoord";
            // 
            // cmbEventsLoginForm
            // 
            this.cmbEventsLoginForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventsLoginForm.FormattingEnabled = true;
            this.cmbEventsLoginForm.Location = new System.Drawing.Point(12, 11);
            this.cmbEventsLoginForm.Name = "cmbEventsLoginForm";
            this.cmbEventsLoginForm.Size = new System.Drawing.Size(221, 21);
            this.cmbEventsLoginForm.TabIndex = 5;
            // 
            // btnInschrijvenInloggenForm
            // 
            this.btnInschrijvenInloggenForm.Location = new System.Drawing.Point(13, 151);
            this.btnInschrijvenInloggenForm.Name = "btnInschrijvenInloggenForm";
            this.btnInschrijvenInloggenForm.Size = new System.Drawing.Size(221, 29);
            this.btnInschrijvenInloggenForm.TabIndex = 6;
            this.btnInschrijvenInloggenForm.Text = "Inschrijven";
            this.btnInschrijvenInloggenForm.UseVisualStyleBackColor = true;
            this.btnInschrijvenInloggenForm.Click += new System.EventHandler(this.btnInschrijvenInloggenForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 191);
            this.Controls.Add(this.btnInschrijvenInloggenForm);
            this.Controls.Add(this.cmbEventsLoginForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInlogLoginForm);
            this.Controls.Add(this.tbWachtwoordLoginForm);
            this.Controls.Add(this.tbGebRfidLoginForm);
            this.Name = "LoginForm";
            this.Text = "Inloggen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SluitHeleApplicatie);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGebRfidLoginForm;
        private System.Windows.Forms.TextBox tbWachtwoordLoginForm;
        private System.Windows.Forms.Button btnInlogLoginForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEventsLoginForm;
        private System.Windows.Forms.Button btnInschrijvenInloggenForm;
    }
}

