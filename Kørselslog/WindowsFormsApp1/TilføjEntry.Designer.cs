namespace WindowsFormsApp1
{
    partial class TilføjEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tilføjkørsel = new System.Windows.Forms.Button();
            this.DropDownPlade = new System.Windows.Forms.ComboBox();
            this.DropDownNavn = new System.Windows.Forms.ComboBox();
            this.DatoVaelger = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast fuldt navn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indtast Nummerpladen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indtast antal Km kørt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Indtast dato for kørsel:";
            // 
            // KM
            // 
            this.KM.Location = new System.Drawing.Point(306, 60);
            this.KM.Name = "KM";
            this.KM.Size = new System.Drawing.Size(121, 20);
            this.KM.TabIndex = 6;
            this.KM.TextChanged += new System.EventHandler(this.KM_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tilbage til hovedmenuen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tilføjkørsel
            // 
            this.Tilføjkørsel.Location = new System.Drawing.Point(166, 100);
            this.Tilføjkørsel.Name = "Tilføjkørsel";
            this.Tilføjkørsel.Size = new System.Drawing.Size(255, 23);
            this.Tilføjkørsel.TabIndex = 8;
            this.Tilføjkørsel.Text = "Tilføj ny kørsel";
            this.Tilføjkørsel.UseVisualStyleBackColor = true;
            this.Tilføjkørsel.Click += new System.EventHandler(this.Tilføjkørsel_Click);
            // 
            // DropDownPlade
            // 
            this.DropDownPlade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownPlade.FormattingEnabled = true;
            this.DropDownPlade.Location = new System.Drawing.Point(166, 59);
            this.DropDownPlade.Name = "DropDownPlade";
            this.DropDownPlade.Size = new System.Drawing.Size(121, 21);
            this.DropDownPlade.TabIndex = 11;
            this.DropDownPlade.SelectedIndexChanged += new System.EventHandler(this.DropDownPlade_SelectedIndexChanged);
            // 
            // DropDownNavn
            // 
            this.DropDownNavn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownNavn.FormattingEnabled = true;
            this.DropDownNavn.Location = new System.Drawing.Point(26, 60);
            this.DropDownNavn.Name = "DropDownNavn";
            this.DropDownNavn.Size = new System.Drawing.Size(121, 21);
            this.DropDownNavn.TabIndex = 12;
            this.DropDownNavn.SelectedIndexChanged += new System.EventHandler(this.DropDownNavn2_SelectedIndexChanged);
            // 
            // DatoVaelger
            // 
            this.DatoVaelger.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatoVaelger.Location = new System.Drawing.Point(446, 60);
            this.DatoVaelger.Name = "DatoVaelger";
            this.DatoVaelger.Size = new System.Drawing.Size(121, 20);
            this.DatoVaelger.TabIndex = 13;
            this.DatoVaelger.ValueChanged += new System.EventHandler(this.DatoVaelger_ValueChanged);
            // 
            // TilføjEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 210);
            this.Controls.Add(this.DatoVaelger);
            this.Controls.Add(this.DropDownNavn);
            this.Controls.Add(this.DropDownPlade);
            this.Controls.Add(this.Tilføjkørsel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TilføjEntry";
            this.Text = "TilføjEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Tilføjkørsel;
        private System.Windows.Forms.ComboBox DropDownPlade;
        private System.Windows.Forms.ComboBox DropDownNavn;
        private System.Windows.Forms.DateTimePicker DatoVaelger;
    }
}