namespace TT_DriveBook
{
    partial class Form1
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
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.dataGridView_DriveLog = new System.Windows.Forms.DataGridView();
            this.User_View = new System.Windows.Forms.Label();
            this.DriveLog_View = new System.Windows.Forms.Label();
            this.AddNewUser = new System.Windows.Forms.Button();
            this.currLogUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TT Kørselsbog";
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AllowUserToAddRows = false;
            this.dataGridView_Users.AllowUserToDeleteRows = false;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Location = new System.Drawing.Point(34, 80);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.ReadOnly = true;
            this.dataGridView_Users.Size = new System.Drawing.Size(555, 243);
            this.dataGridView_Users.TabIndex = 1;
            this.dataGridView_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellContentClick);
            this.dataGridView_Users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellDoubleClick);
            // 
            // dataGridView_DriveLog
            // 
            this.dataGridView_DriveLog.AllowUserToAddRows = false;
            this.dataGridView_DriveLog.AllowUserToDeleteRows = false;
            this.dataGridView_DriveLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DriveLog.Location = new System.Drawing.Point(629, 80);
            this.dataGridView_DriveLog.Name = "dataGridView_DriveLog";
            this.dataGridView_DriveLog.ReadOnly = true;
            this.dataGridView_DriveLog.Size = new System.Drawing.Size(339, 243);
            this.dataGridView_DriveLog.TabIndex = 2;
            //this.dataGridView_DriveLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DriveLog_CellContentClick);
            // 
            // User_View
            // 
            this.User_View.AutoSize = true;
            this.User_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_View.Location = new System.Drawing.Point(31, 50);
            this.User_View.Name = "User_View";
            this.User_View.Size = new System.Drawing.Size(111, 17);
            this.User_View.TabIndex = 5;
            this.User_View.Text = "Person oversigt:";
            // 
            // DriveLog_View
            // 
            this.DriveLog_View.AutoSize = true;
            this.DriveLog_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveLog_View.Location = new System.Drawing.Point(626, 50);
            this.DriveLog_View.Name = "DriveLog_View";
            this.DriveLog_View.Size = new System.Drawing.Size(173, 17);
            this.DriveLog_View.TabIndex = 6;
            this.DriveLog_View.Text = "Log oversigt for brugeren:";
            // 
            // AddNewUser
            // 
            this.AddNewUser.Location = new System.Drawing.Point(34, 340);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(93, 23);
            this.AddNewUser.TabIndex = 7;
            this.AddNewUser.Text = "Opret ny bruger";
            this.AddNewUser.UseVisualStyleBackColor = true;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // currLogUser
            // 
            this.currLogUser.AutoSize = true;
            this.currLogUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currLogUser.Location = new System.Drawing.Point(815, 50);
            this.currLogUser.Name = "currLogUser";
            this.currLogUser.Size = new System.Drawing.Size(0, 17);
            this.currLogUser.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 384);
            this.Controls.Add(this.currLogUser);
            this.Controls.Add(this.AddNewUser);
            this.Controls.Add(this.DriveLog_View);
            this.Controls.Add(this.User_View);
            this.Controls.Add(this.dataGridView_DriveLog);
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DriveLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.DataGridView dataGridView_DriveLog;
        private System.Windows.Forms.Label User_View;
        private System.Windows.Forms.Label DriveLog_View;
        private System.Windows.Forms.Button AddNewUser;
        private System.Windows.Forms.Label currLogUser;
    }
}

