namespace TT_DriveBook
{
    partial class UserForm_Edit
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
            this.Save_Changes_User = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NrPlade = new System.Windows.Forms.TextBox();
            this.Nr_Plade = new System.Windows.Forms.Label();
            this.DrivedKm = new System.Windows.Forms.TextBox();
            this.TotalKM = new System.Windows.Forms.Label();
            this.Navn = new System.Windows.Forms.TextBox();
            this.Navn_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_Changes_User
            // 
            this.Save_Changes_User.Location = new System.Drawing.Point(156, 197);
            this.Save_Changes_User.Name = "Save_Changes_User";
            this.Save_Changes_User.Size = new System.Drawing.Size(66, 23);
            this.Save_Changes_User.TabIndex = 17;
            this.Save_Changes_User.Text = "Ok";
            this.Save_Changes_User.UseVisualStyleBackColor = true;
            this.Save_Changes_User.Click += new System.EventHandler(this.Save_Changes_User_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(27, 197);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NrPlade
            // 
            this.NrPlade.Location = new System.Drawing.Point(134, 121);
            this.NrPlade.Name = "NrPlade";
            this.NrPlade.ReadOnly = true;
            this.NrPlade.Size = new System.Drawing.Size(100, 20);
            this.NrPlade.TabIndex = 15;
            // 
            // Nr_Plade
            // 
            this.Nr_Plade.AutoSize = true;
            this.Nr_Plade.Location = new System.Drawing.Point(25, 124);
            this.Nr_Plade.Name = "Nr_Plade";
            this.Nr_Plade.Size = new System.Drawing.Size(78, 13);
            this.Nr_Plade.TabIndex = 14;
            this.Nr_Plade.Text = "Nummer plade:";
            // 
            // DrivedKm
            // 
            this.DrivedKm.Location = new System.Drawing.Point(134, 157);
            this.DrivedKm.Name = "DrivedKm";
            this.DrivedKm.ReadOnly = true;
            this.DrivedKm.Size = new System.Drawing.Size(100, 20);
            this.DrivedKm.TabIndex = 13;
            // 
            // TotalKM
            // 
            this.TotalKM.AutoSize = true;
            this.TotalKM.Location = new System.Drawing.Point(24, 160);
            this.TotalKM.Name = "TotalKM";
            this.TotalKM.Size = new System.Drawing.Size(55, 13);
            this.TotalKM.TabIndex = 12;
            this.TotalKM.Text = "Kørte km.:";
            // 
            // Navn
            // 
            this.Navn.Location = new System.Drawing.Point(134, 87);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(100, 20);
            this.Navn.TabIndex = 11;
            // 
            // Navn_
            // 
            this.Navn_.AutoSize = true;
            this.Navn_.Location = new System.Drawing.Point(24, 90);
            this.Navn_.Name = "Navn_";
            this.Navn_.Size = new System.Drawing.Size(36, 13);
            this.Navn_.TabIndex = 10;
            this.Navn_.Text = "Navn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rediger stamdata:";
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(2, 1);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(21, 20);
            this.BID.TabIndex = 18;
            this.BID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dato:";
            // 
            // PDato
            // 
            this.PDato.Location = new System.Drawing.Point(134, 56);
            this.PDato.Name = "PDato";
            this.PDato.ReadOnly = true;
            this.PDato.Size = new System.Drawing.Size(100, 20);
            this.PDato.TabIndex = 20;
            // 
            // UserForm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 249);
            this.Controls.Add(this.PDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.Save_Changes_User);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.NrPlade);
            this.Controls.Add(this.Nr_Plade);
            this.Controls.Add(this.DrivedKm);
            this.Controls.Add(this.TotalKM);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.Navn_);
            this.Controls.Add(this.label1);
            this.Name = "UserForm_Edit";
            this.Text = "UserForm_Edit";
            this.Load += new System.EventHandler(this.UserForm_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Changes_User;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox NrPlade;
        private System.Windows.Forms.Label Nr_Plade;
        private System.Windows.Forms.TextBox DrivedKm;
        private System.Windows.Forms.Label TotalKM;
        private System.Windows.Forms.TextBox Navn;
        private System.Windows.Forms.Label Navn_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PDato;
    }
}