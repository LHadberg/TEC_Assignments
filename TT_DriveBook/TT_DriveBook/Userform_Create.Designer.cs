namespace TT_DriveBook
{
    partial class Userform_Create
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
            this.Navn = new System.Windows.Forms.TextBox();
            this.DrivedKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NrPlade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel_New_User = new System.Windows.Forms.Button();
            this.Add_New_User = new System.Windows.Forms.Button();
            this.tttt = new System.Windows.Forms.Label();
            this.CurrDato = new System.Windows.Forms.TextBox();
            this.BID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stamdata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navn:";
            // 
            // Navn
            // 
            this.Navn.Location = new System.Drawing.Point(153, 97);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(100, 20);
            this.Navn.TabIndex = 2;
            // 
            // DrivedKm
            // 
            this.DrivedKm.Location = new System.Drawing.Point(153, 167);
            this.DrivedKm.Name = "DrivedKm";
            this.DrivedKm.ReadOnly = true;
            this.DrivedKm.Size = new System.Drawing.Size(100, 20);
            this.DrivedKm.TabIndex = 4;
            this.DrivedKm.Text = "0";
            this.DrivedKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kørte km.:";
            // 
            // NrPlade
            // 
            this.NrPlade.Location = new System.Drawing.Point(153, 131);
            this.NrPlade.Name = "NrPlade";
            this.NrPlade.Size = new System.Drawing.Size(100, 20);
            this.NrPlade.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nummer plade:";
            // 
            // Cancel_New_User
            // 
            this.Cancel_New_User.Location = new System.Drawing.Point(46, 207);
            this.Cancel_New_User.Name = "Cancel_New_User";
            this.Cancel_New_User.Size = new System.Drawing.Size(75, 23);
            this.Cancel_New_User.TabIndex = 7;
            this.Cancel_New_User.Text = "Cancel";
            this.Cancel_New_User.UseVisualStyleBackColor = true;
            this.Cancel_New_User.Click += new System.EventHandler(this.Cancel_New_User_Click);
            // 
            // Add_New_User
            // 
            this.Add_New_User.Location = new System.Drawing.Point(175, 207);
            this.Add_New_User.Name = "Add_New_User";
            this.Add_New_User.Size = new System.Drawing.Size(66, 23);
            this.Add_New_User.TabIndex = 8;
            this.Add_New_User.Text = "Ok";
            this.Add_New_User.UseVisualStyleBackColor = true;
            this.Add_New_User.Click += new System.EventHandler(this.Add_New_User_Click);
            // 
            // tttt
            // 
            this.tttt.AutoSize = true;
            this.tttt.Location = new System.Drawing.Point(46, 68);
            this.tttt.Name = "tttt";
            this.tttt.Size = new System.Drawing.Size(33, 13);
            this.tttt.TabIndex = 9;
            this.tttt.Text = "Dato:";
            // 
            // CurrDato
            // 
            this.CurrDato.Location = new System.Drawing.Point(153, 65);
            this.CurrDato.Name = "CurrDato";
            this.CurrDato.ReadOnly = true;
            this.CurrDato.Size = new System.Drawing.Size(100, 20);
            this.CurrDato.TabIndex = 10;
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(-2, 1);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(23, 20);
            this.BID.TabIndex = 11;
            this.BID.Visible = false;
            // 
            // Userform_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 255);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.CurrDato);
            this.Controls.Add(this.tttt);
            this.Controls.Add(this.Add_New_User);
            this.Controls.Add(this.Cancel_New_User);
            this.Controls.Add(this.NrPlade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DrivedKm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Userform_Create";
            this.Text = "Userform_Create";
            this.Load += new System.EventHandler(this.Userform_Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Navn;
        private System.Windows.Forms.TextBox DrivedKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NrPlade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel_New_User;
        private System.Windows.Forms.Button Add_New_User;
        private System.Windows.Forms.Label tttt;
        private System.Windows.Forms.TextBox CurrDato;
        private System.Windows.Forms.TextBox BID;
    }
}