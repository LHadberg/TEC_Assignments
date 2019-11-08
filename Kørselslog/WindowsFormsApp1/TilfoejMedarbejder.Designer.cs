namespace WindowsFormsApp1
{
    partial class TilfoejMedarbejder
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
            this.button1 = new System.Windows.Forms.Button();
            this.MedarbejderInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DropDownRediger = new System.Windows.Forms.ComboBox();
            this.RedigerKnap = new System.Windows.Forms.Button();
            this.DropDownSlet = new System.Windows.Forms.ComboBox();
            this.SletKnap = new System.Windows.Forms.Button();
            this.RedigerInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tilføj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MedarbejderInfo
            // 
            this.MedarbejderInfo.Location = new System.Drawing.Point(15, 37);
            this.MedarbejderInfo.Name = "MedarbejderInfo";
            this.MedarbejderInfo.Size = new System.Drawing.Size(238, 20);
            this.MedarbejderInfo.TabIndex = 0;
            this.MedarbejderInfo.TextChanged += new System.EventHandler(this.MedarbejderInfo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indtast det fulde navn:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tilbage til hovedmenuen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DropDownRediger
            // 
            this.DropDownRediger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownRediger.FormattingEnabled = true;
            this.DropDownRediger.Location = new System.Drawing.Point(15, 124);
            this.DropDownRediger.Name = "DropDownRediger";
            this.DropDownRediger.Size = new System.Drawing.Size(238, 21);
            this.DropDownRediger.TabIndex = 3;
            this.DropDownRediger.SelectedIndexChanged += new System.EventHandler(this.DropDownRediger_SelectedIndexChanged);
            // 
            // RedigerKnap
            // 
            this.RedigerKnap.Location = new System.Drawing.Point(259, 136);
            this.RedigerKnap.Name = "RedigerKnap";
            this.RedigerKnap.Size = new System.Drawing.Size(75, 23);
            this.RedigerKnap.TabIndex = 4;
            this.RedigerKnap.Text = "Rediger";
            this.RedigerKnap.UseVisualStyleBackColor = true;
            this.RedigerKnap.Click += new System.EventHandler(this.RedigerKnap_Click);
            // 
            // DropDownSlet
            // 
            this.DropDownSlet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownSlet.FormattingEnabled = true;
            this.DropDownSlet.Location = new System.Drawing.Point(15, 79);
            this.DropDownSlet.Name = "DropDownSlet";
            this.DropDownSlet.Size = new System.Drawing.Size(238, 21);
            this.DropDownSlet.TabIndex = 5;
            this.DropDownSlet.SelectedIndexChanged += new System.EventHandler(this.DropDownSlet_SelectedIndexChanged);
            // 
            // SletKnap
            // 
            this.SletKnap.Location = new System.Drawing.Point(259, 78);
            this.SletKnap.Name = "SletKnap";
            this.SletKnap.Size = new System.Drawing.Size(75, 23);
            this.SletKnap.TabIndex = 6;
            this.SletKnap.Text = "Slet";
            this.SletKnap.UseVisualStyleBackColor = true;
            this.SletKnap.Click += new System.EventHandler(this.SletKnap_Click);
            // 
            // RedigerInput
            // 
            this.RedigerInput.Location = new System.Drawing.Point(15, 151);
            this.RedigerInput.Name = "RedigerInput";
            this.RedigerInput.Size = new System.Drawing.Size(238, 20);
            this.RedigerInput.TabIndex = 7;
            this.RedigerInput.TextChanged += new System.EventHandler(this.RedigerInput_TextChanged);
            // 
            // TilfoejMedarbejder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 210);
            this.Controls.Add(this.RedigerInput);
            this.Controls.Add(this.SletKnap);
            this.Controls.Add(this.DropDownSlet);
            this.Controls.Add(this.RedigerKnap);
            this.Controls.Add(this.DropDownRediger);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedarbejderInfo);
            this.Controls.Add(this.button1);
            this.Name = "TilfoejMedarbejder";
            this.Text = "TilfoejMedarbejder";
            this.Load += new System.EventHandler(this.TilfoejMedarbejder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MedarbejderInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox DropDownRediger;
        private System.Windows.Forms.Button RedigerKnap;
        private System.Windows.Forms.ComboBox DropDownSlet;
        private System.Windows.Forms.Button SletKnap;
        private System.Windows.Forms.TextBox RedigerInput;
    }
}