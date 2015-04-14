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
            this.plaats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewToegangAfwezig = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelToegangAanwezig = new System.Windows.Forms.Label();
            this.labelToegangAfwezig = new System.Windows.Forms.Label();
            this.comboBoxToegangEvents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.achternaam,
            this.plaats});
            this.dataGridViewToegangAanwezig.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewToegangAanwezig.Name = "dataGridViewToegangAanwezig";
            this.dataGridViewToegangAanwezig.Size = new System.Drawing.Size(443, 150);
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
            // plaats
            // 
            this.plaats.HeaderText = "Plaats";
            this.plaats.Name = "plaats";
            this.plaats.ReadOnly = true;
            // 
            // dataGridViewToegangAfwezig
            // 
            this.dataGridViewToegangAfwezig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToegangAfwezig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewToegangAfwezig.Location = new System.Drawing.Point(461, 80);
            this.dataGridViewToegangAfwezig.Name = "dataGridViewToegangAfwezig";
            this.dataGridViewToegangAfwezig.Size = new System.Drawing.Size(443, 150);
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Plaats";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // labelToegangAanwezig
            // 
            this.labelToegangAanwezig.AutoSize = true;
            this.labelToegangAanwezig.Location = new System.Drawing.Point(13, 55);
            this.labelToegangAanwezig.Name = "labelToegangAanwezig";
            this.labelToegangAanwezig.Size = new System.Drawing.Size(68, 13);
            this.labelToegangAanwezig.TabIndex = 1;
            this.labelToegangAanwezig.Text = "Aanwezigen:";
            // 
            // labelToegangAfwezig
            // 
            this.labelToegangAfwezig.AutoSize = true;
            this.labelToegangAfwezig.Location = new System.Drawing.Point(458, 55);
            this.labelToegangAfwezig.Name = "labelToegangAfwezig";
            this.labelToegangAfwezig.Size = new System.Drawing.Size(59, 13);
            this.labelToegangAfwezig.TabIndex = 1;
            this.labelToegangAfwezig.Text = "Afwezigen:";
            // 
            // comboBoxToegangEvents
            // 
            this.comboBoxToegangEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToegangEvents.FormattingEnabled = true;
            this.comboBoxToegangEvents.Location = new System.Drawing.Point(12, 31);
            this.comboBoxToegangEvents.Name = "comboBoxToegangEvents";
            this.comboBoxToegangEvents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxToegangEvents.TabIndex = 2;
            this.comboBoxToegangEvents.SelectedIndexChanged += new System.EventHandler(this.comboBoxToegangEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Huidig Event:";
            // 
            // Toegangscontroleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToegangEvents);
            this.Controls.Add(this.labelToegangAfwezig);
            this.Controls.Add(this.labelToegangAanwezig);
            this.Controls.Add(this.dataGridViewToegangAfwezig);
            this.Controls.Add(this.dataGridViewToegangAanwezig);
            this.Name = "Toegangscontroleform";
            this.Text = "Toegangscontrole";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToegangAanwezig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToegangAfwezig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToegangAanwezig;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn achternaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaats;
        private System.Windows.Forms.DataGridView dataGridViewToegangAfwezig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label labelToegangAanwezig;
        private System.Windows.Forms.Label labelToegangAfwezig;
        private System.Windows.Forms.ComboBox comboBoxToegangEvents;
        private System.Windows.Forms.Label label1;
    }
}