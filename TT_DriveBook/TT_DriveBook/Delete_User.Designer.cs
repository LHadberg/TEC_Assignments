namespace TT_DriveBook
{
    partial class Delete_User
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
            this.Cancel_delete_User = new System.Windows.Forms.Button();
            this.Ok_Delete_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.BID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel_delete_User
            // 
            this.Cancel_delete_User.Location = new System.Drawing.Point(68, 157);
            this.Cancel_delete_User.Name = "Cancel_delete_User";
            this.Cancel_delete_User.Size = new System.Drawing.Size(75, 23);
            this.Cancel_delete_User.TabIndex = 0;
            this.Cancel_delete_User.Text = "Cancel";
            this.Cancel_delete_User.UseVisualStyleBackColor = true;
            this.Cancel_delete_User.Click += new System.EventHandler(this.Cancel_delete_User_Click);
            // 
            // Ok_Delete_user
            // 
            this.Ok_Delete_user.Location = new System.Drawing.Point(170, 157);
            this.Ok_Delete_user.Name = "Ok_Delete_user";
            this.Ok_Delete_user.Size = new System.Drawing.Size(75, 23);
            this.Ok_Delete_user.TabIndex = 1;
            this.Ok_Delete_user.Text = "Ok";
            this.Ok_Delete_user.UseVisualStyleBackColor = true;
            this.Ok_Delete_user.Click += new System.EventHandler(this.Ok_Delete_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slet bruger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Navn:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(122, 93);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(160, 20);
            this.Username.TabIndex = 4;
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(0, 2);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(12, 20);
            this.BID.TabIndex = 5;
            this.BID.Visible = false;
            // 
            // Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 201);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok_Delete_user);
            this.Controls.Add(this.Cancel_delete_User);
            this.Name = "Delete_User";
            this.Text = "Delete_User";
            this.Load += new System.EventHandler(this.Delete_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_delete_User;
        private System.Windows.Forms.Button Ok_Delete_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox BID;
    }
}