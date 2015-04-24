namespace ICT4Events_S24_Groep_E
{
    partial class Toegangscontroleform
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
            this.dataGridViewToegangAanwezig = new System.Windows.Forms.DataGridView();
            this.rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achternaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewToegangAfwezig = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelToegangAanwezig = new System.Windows.Forms.Label();
            this.labelToegangAfwezig = new System.Windows.Forms.Label();
            this.textBoxToegangRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToegangCheckInUit = new System.Windows.Forms.Button();
            this.labelRFID = new System.Windows.Forms.Label();
            this.labelCheckInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToegangAanwezig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToegangAfwezig)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewToegangAanwezig
            // 
            this.dataGridViewToegangAanwezig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToegangAanwezig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rfid,
            this.naam,
            this.achternaam});
            this.dataGridViewToegangAanwezig.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewToegangAanwezig.Name = "dataGridViewToegangAanwezig";
            this.dataGridViewToegangAanwezig.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewToegangAanwezig.TabIndex = 0;
            // 
            // rfid
            // 
            this.rfid.HeaderText = "RFID";
            this.rfid.Name = "rfid";
            this.rfid.ReadOnly = true;
            // 
            // naam
            // 
            this.naam.HeaderText = "Naam";
            this.naam.Name = "naam";
            this.naam.ReadOnly = true;
            // 
            // achternaam
            // 
            this.achternaam.HeaderText = "Achternaam";
            this.achternaam.Name = "achternaam";
            this.achternaam.ReadOnly = true;
            // 
            // dataGridViewToegangAfwezig
            // 
            this.dataGridViewToegangAfwezig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToegangAfwezig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewToegangAfwezig.Location = new System.Drawing.Point(361, 38);
            this.dataGridViewToegangAfwezig.Name = "dataGridViewToegangAfwezig";
            this.dataGridViewToegangAfwezig.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewToegangAfwezig.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "RFID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Achternaam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // labelToegangAanwezig
            // 
            this.labelToegangAanwezig.AutoSize = true;
            this.labelToegangAanwezig.Location = new System.Drawing.Point(13, 13);
            this.labelToegangAanwezig.Name = "labelToegangAanwezig";
            this.labelToegangAanwezig.Size = new System.Drawing.Size(68, 13);
            this.labelToegangAanwezig.TabIndex = 1;
            this.labelToegangAanwezig.Text = "Aanwezigen:";
            // 
            // labelToegangAfwezig
            // 
            this.labelToegangAfwezig.AutoSize = true;
            this.labelToegangAfwezig.Location = new System.Drawing.Point(358, 13);
            this.labelToegangAfwezig.Name = "labelToegangAfwezig";
            this.labelToegangAfwezig.Size = new System.Drawing.Size(59, 13);
            this.labelToegangAfwezig.TabIndex = 1;
            this.labelToegangAfwezig.Text = "Afwezigen:";
            // 
            // textBoxToegangRFID
            // 
            this.textBoxToegangRFID.Location = new System.Drawing.Point(602, 200);
            this.textBoxToegangRFID.Name = "textBoxToegangRFID";
            this.textBoxToegangRFID.Size = new System.Drawing.Size(100, 20);
            this.textBoxToegangRFID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFID:";
            // 
            // buttonToegangCheckInUit
            // 
            this.buttonToegangCheckInUit.Location = new System.Drawing.Point(629, 227);
            this.buttonToegangCheckInUit.Name = "buttonToegangCheckInUit";
            this.buttonToegangCheckInUit.Size = new System.Drawing.Size(75, 23);
            this.buttonToegangCheckInUit.TabIndex = 4;
            this.buttonToegangCheckInUit.Text = "Check in/uit";
            this.buttonToegangCheckInUit.UseVisualStyleBackColor = true;
            this.buttonToegangCheckInUit.Click += new System.EventHandler(this.buttonToegangCheckInUit_Click);
            // 
            // labelRFID
            // 
            this.labelRFID.AutoSize = true;
            this.labelRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRFID.Location = new System.Drawing.Point(13, 203);
            this.labelRFID.Name = "labelRFID";
            this.labelRFID.Size = new System.Drawing.Size(53, 13);
            this.labelRFID.TabIndex = 5;
            this.labelRFID.Text = "RFID Info";
            // 
            // labelCheckInfo
            // 
            this.labelCheckInfo.AutoSize = true;
            this.labelCheckInfo.Location = new System.Drawing.Point(13, 232);
            this.labelCheckInfo.Name = "labelCheckInfo";
            this.labelCheckInfo.Size = new System.Drawing.Size(95, 13);
            this.labelCheckInfo.TabIndex = 6;
            this.labelCheckInfo.Text = "Info over RFID tag";
            // 
            // Toegangscontroleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 261);
            this.Controls.Add(this.labelCheckInfo);
            this.Controls.Add(this.labelRFID);
            this.Controls.Add(this.buttonToegangCheckInUit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxToegangRFID);
            this.Controls.Add(this.labelToegangAfwezig);
            this.Controls.Add(this.labelToegangAanwezig);
            this.Controls.Add(this.dataGridViewToegangAfwezig);
            this.Controls.Add(this.dataGridViewToegangAanwezig);
            this.Name = "Toegangscontroleform";
            this.Text = "Toegangscontrole";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerugNaarLogin);
            this.Load += new System.EventHandler(this.Toegangscontroleform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToegangAanwezig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToegangAfwezig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToegangAanwezig;
        private System.Windows.Forms.DataGridView dataGridViewToegangAfwezig;
        private System.Windows.Forms.Label labelToegangAanwezig;
        private System.Windows.Forms.Label labelToegangAfwezig;
        private System.Windows.Forms.TextBox textBoxToegangRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToegangCheckInUit;
        private System.Windows.Forms.Label labelRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn achternaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label labelCheckInfo;
    }
}