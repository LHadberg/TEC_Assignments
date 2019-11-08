namespace TT_DriveBook
{
    partial class DriverLog
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
            this.Ok_Logging = new System.Windows.Forms.Button();
            this.Cancel_Logging = new System.Windows.Forms.Button();
            this.Opgave_Logging = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KM_Logging = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dato_Logging = new System.Windows.Forms.DateTimePicker();
            this.BID_Logging = new System.Windows.Forms.TextBox();
            this.Navn_Logging = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Navn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ok_Logging
            // 
            this.Ok_Logging.Location = new System.Drawing.Point(237, 192);
            this.Ok_Logging.Name = "Ok_Logging";
            this.Ok_Logging.Size = new System.Drawing.Size(75, 23);
            this.Ok_Logging.TabIndex = 21;
            this.Ok_Logging.Text = "OK";
            this.Ok_Logging.Click += new System.EventHandler(this.Ok_Logging_Click);
            // 
            // Cancel_Logging
            // 
            this.Cancel_Logging.Location = new System.Drawing.Point(130, 192);
            this.Cancel_Logging.Name = "Cancel_Logging";
            this.Cancel_Logging.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Logging.TabIndex = 16;
            this.Cancel_Logging.Text = "Cancel";
            this.Cancel_Logging.UseVisualStyleBackColor = true;
            this.Cancel_Logging.Click += new System.EventHandler(this.Cancel_Logging_Click);
            // 
            // Opgave_Logging
            // 
            this.Opgave_Logging.Location = new System.Drawing.Point(130, 117);
            this.Opgave_Logging.Name = "Opgave_Logging";
            this.Opgave_Logging.Size = new System.Drawing.Size(200, 20);
            this.Opgave_Logging.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Opgave/formål:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dato for kørsel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kørsels log:";
            // 
            // KM_Logging
            // 
            this.KM_Logging.Location = new System.Drawing.Point(130, 154);
            this.KM_Logging.Name = "KM_Logging";
            this.KM_Logging.Size = new System.Drawing.Size(100, 20);
            this.KM_Logging.TabIndex = 19;
            this.KM_Logging.TextChanged += new System.EventHandler(this.KM_Logging_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kørte km.:";
            // 
            // Dato_Logging
            // 
            this.Dato_Logging.Location = new System.Drawing.Point(130, 80);
            this.Dato_Logging.Name = "Dato_Logging";
            this.Dato_Logging.Size = new System.Drawing.Size(200, 20);
            this.Dato_Logging.TabIndex = 20;
            this.Dato_Logging.ValueChanged += new System.EventHandler(this.Dato_Logging_ValueChanged);
            // 
            // BID_Logging
            // 
            this.BID_Logging.Location = new System.Drawing.Point(1, -5);
            this.BID_Logging.Name = "BID_Logging";
            this.BID_Logging.Size = new System.Drawing.Size(20, 20);
            this.BID_Logging.TabIndex = 22;
            this.BID_Logging.Visible = false;
            // 
            // Navn_Logging
            // 
            this.Navn_Logging.Location = new System.Drawing.Point(23, -5);
            this.Navn_Logging.Name = "Navn_Logging";
            this.Navn_Logging.Size = new System.Drawing.Size(18, 20);
            this.Navn_Logging.TabIndex = 23;
            this.Navn_Logging.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Navn:";
            // 
            // Navn
            // 
            this.Navn.Location = new System.Drawing.Point(130, 54);
            this.Navn.Name = "Navn";
            this.Navn.ReadOnly = true;
            this.Navn.Size = new System.Drawing.Size(199, 20);
            this.Navn.TabIndex = 25;
            // 
            // DriverLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 233);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Navn_Logging);
            this.Controls.Add(this.BID_Logging);
            this.Controls.Add(this.Dato_Logging);
            this.Controls.Add(this.KM_Logging);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ok_Logging);
            this.Controls.Add(this.Cancel_Logging);
            this.Controls.Add(this.Opgave_Logging);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DriverLog";
            this.Text = "DriverLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_Logging;
        private System.Windows.Forms.Button Cancel_Logging;
        private System.Windows.Forms.TextBox Opgave_Logging;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KM_Logging;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dato_Logging;
        private System.Windows.Forms.TextBox BID_Logging;
        private System.Windows.Forms.TextBox Navn_Logging;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Navn;
    }
}