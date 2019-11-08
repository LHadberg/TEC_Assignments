namespace WindowsFormsApp1
{
    partial class BilInformation
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
            this.Tilføj = new System.Windows.Forms.Button();
            this.BilInfo = new System.Windows.Forms.TextBox();
            this.TilbageTilMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DropDownRediger = new System.Windows.Forms.ComboBox();
            this.DropDownSlet = new System.Windows.Forms.ComboBox();
            this.Rediger = new System.Windows.Forms.Button();
            this.Slet = new System.Windows.Forms.Button();
            this.RedigerInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tilføj
            // 
            this.Tilføj.Location = new System.Drawing.Point(259, 37);
            this.Tilføj.Name = "Tilføj";
            this.Tilføj.Size = new System.Drawing.Size(77, 20);
            this.Tilføj.TabIndex = 0;
            this.Tilføj.Text = "Tilføj";
            this.Tilføj.UseVisualStyleBackColor = true;
            this.Tilføj.Click += new System.EventHandler(this.Tilføj_Click);
            // 
            // BilInfo
            // 
            this.BilInfo.Location = new System.Drawing.Point(15, 37);
            this.BilInfo.Name = "BilInfo";
            this.BilInfo.Size = new System.Drawing.Size(238, 20);
            this.BilInfo.TabIndex = 1;
            this.BilInfo.TextChanged += new System.EventHandler(this.BilInfo_TextChanged);
            // 
            // TilbageTilMenu
            // 
            this.TilbageTilMenu.Location = new System.Drawing.Point(438, 12);
            this.TilbageTilMenu.Name = "TilbageTilMenu";
            this.TilbageTilMenu.Size = new System.Drawing.Size(134, 20);
            this.TilbageTilMenu.TabIndex = 2;
            this.TilbageTilMenu.Text = "Tilbage til hovedmenuen";
            this.TilbageTilMenu.UseVisualStyleBackColor = true;
            this.TilbageTilMenu.Click += new System.EventHandler(this.TilbageTilMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indtast bilens nummerplade:";
            // 
            // DropDownRediger
            // 
            this.DropDownRediger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownRediger.FormattingEnabled = true;
            this.DropDownRediger.Location = new System.Drawing.Point(15, 124);
            this.DropDownRediger.Name = "DropDownRediger";
            this.DropDownRediger.Size = new System.Drawing.Size(238, 21);
            this.DropDownRediger.TabIndex = 4;
            this.DropDownRediger.SelectedIndexChanged += new System.EventHandler(this.DropDownRediger_SelectedIndexChanged);
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
            // Rediger
            // 
            this.Rediger.Location = new System.Drawing.Point(259, 136);
            this.Rediger.Name = "Rediger";
            this.Rediger.Size = new System.Drawing.Size(75, 23);
            this.Rediger.TabIndex = 6;
            this.Rediger.Text = "Rediger";
            this.Rediger.UseVisualStyleBackColor = true;
            this.Rediger.Click += new System.EventHandler(this.Rediger_Click);
            // 
            // Slet
            // 
            this.Slet.Location = new System.Drawing.Point(259, 78);
            this.Slet.Name = "Slet";
            this.Slet.Size = new System.Drawing.Size(75, 23);
            this.Slet.TabIndex = 7;
            this.Slet.Text = "Slet";
            this.Slet.UseVisualStyleBackColor = true;
            this.Slet.Click += new System.EventHandler(this.Slet_Click);
            // 
            // RedigerInput
            // 
            this.RedigerInput.Location = new System.Drawing.Point(15, 151);
            this.RedigerInput.Name = "RedigerInput";
            this.RedigerInput.Size = new System.Drawing.Size(238, 20);
            this.RedigerInput.TabIndex = 8;
            this.RedigerInput.TextChanged += new System.EventHandler(this.RedigerInput_TextChanged);
            // 
            // BilInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 210);
            this.Controls.Add(this.RedigerInput);
            this.Controls.Add(this.Slet);
            this.Controls.Add(this.Rediger);
            this.Controls.Add(this.DropDownSlet);
            this.Controls.Add(this.DropDownRediger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TilbageTilMenu);
            this.Controls.Add(this.BilInfo);
            this.Controls.Add(this.Tilføj);
            this.Name = "BilInformation";
            this.Text = "BilInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tilføj;
        private System.Windows.Forms.TextBox BilInfo;
        private System.Windows.Forms.Button TilbageTilMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DropDownRediger;
        private System.Windows.Forms.ComboBox DropDownSlet;
        private System.Windows.Forms.Button Rediger;
        private System.Windows.Forms.Button Slet;
        private System.Windows.Forms.TextBox RedigerInput;
    }
}