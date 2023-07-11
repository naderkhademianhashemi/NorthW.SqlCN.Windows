namespace sqlCN.windows.forms
{
    partial class frmConnectToDataBase
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
            this.gbxLogIn = new System.Windows.Forms.GroupBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.gbxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogIn
            // 
            this.gbxLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLogIn.BackColor = System.Drawing.Color.Transparent;
            this.gbxLogIn.Controls.Add(this.txtDB);
            this.gbxLogIn.Controls.Add(this.label1);
            this.gbxLogIn.Controls.Add(this.label2);
            this.gbxLogIn.Controls.Add(this.txtUserName);
            this.gbxLogIn.Controls.Add(this.txtPassword);
            this.gbxLogIn.Controls.Add(this.label3);
            this.gbxLogIn.Controls.Add(this.txtServer);
            this.gbxLogIn.Controls.Add(this.lblServerName);
            this.gbxLogIn.Controls.Add(this.btnTestConnect);
            this.gbxLogIn.Location = new System.Drawing.Point(14, 2);
            this.gbxLogIn.Name = "gbxLogIn";
            this.gbxLogIn.Size = new System.Drawing.Size(569, 364);
            this.gbxLogIn.TabIndex = 25;
            this.gbxLogIn.TabStop = false;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(223, 107);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(122, 24);
            this.txtDB.TabIndex = 28;
            this.txtDB.Text = "Northwind";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "db";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "رمز عبور";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(202, 157);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 24);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(249, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(96, 24);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام كاربر";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(223, 51);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(122, 24);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = ".";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(400, 54);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerName.Size = new System.Drawing.Size(39, 17);
            this.lblServerName.TabIndex = 4;
            this.lblServerName.Text = "سرور";
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Location = new System.Drawing.Point(249, 288);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(75, 30);
            this.btnTestConnect.TabIndex = 26;
            this.btnTestConnect.Text = "اتصال";
            this.btnTestConnect.UseVisualStyleBackColor = true;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // frmConnectToDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 377);
            this.Controls.Add(this.gbxLogIn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConnectToDataBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتصال به بانك اطلاعاتي";
           
            this.gbxLogIn.ResumeLayout(false);
            this.gbxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnTestConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDB;
    }
}
