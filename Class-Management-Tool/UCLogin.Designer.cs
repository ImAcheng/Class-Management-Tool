namespace Class_Management_Tool {
    partial class UCLogin {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lb_LoginTitle = new System.Windows.Forms.Label();
            this.panel_AccountTb = new System.Windows.Forms.Panel();
            this.tb_Account = new System.Windows.Forms.TextBox();
            this.lb_AccountHint = new System.Windows.Forms.Label();
            this.lb_PasswordHint = new System.Windows.Forms.Label();
            this.panel_PasswordTb = new System.Windows.Forms.Panel();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_AccountTb.SuspendLayout();
            this.panel_PasswordTb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_LoginTitle
            // 
            this.lb_LoginTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_LoginTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_LoginTitle.Location = new System.Drawing.Point(0, 78);
            this.lb_LoginTitle.Name = "lb_LoginTitle";
            this.lb_LoginTitle.Size = new System.Drawing.Size(800, 45);
            this.lb_LoginTitle.TabIndex = 0;
            this.lb_LoginTitle.Text = "Class Affairs Management Tool";
            this.lb_LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_AccountTb
            // 
            this.panel_AccountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AccountTb.Controls.Add(this.tb_Account);
            this.panel_AccountTb.ForeColor = System.Drawing.Color.Black;
            this.panel_AccountTb.Location = new System.Drawing.Point(250, 162);
            this.panel_AccountTb.Name = "panel_AccountTb";
            this.panel_AccountTb.Size = new System.Drawing.Size(300, 40);
            this.panel_AccountTb.TabIndex = 1;
            // 
            // tb_Account
            // 
            this.tb_Account.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Account.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Account.Location = new System.Drawing.Point(3, 7);
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.Size = new System.Drawing.Size(292, 25);
            this.tb_Account.TabIndex = 0;
            // 
            // lb_AccountHint
            // 
            this.lb_AccountHint.AutoSize = true;
            this.lb_AccountHint.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_AccountHint.Location = new System.Drawing.Point(246, 139);
            this.lb_AccountHint.Name = "lb_AccountHint";
            this.lb_AccountHint.Size = new System.Drawing.Size(72, 20);
            this.lb_AccountHint.TabIndex = 2;
            this.lb_AccountHint.Text = "Account";
            // 
            // lb_PasswordHint
            // 
            this.lb_PasswordHint.AutoSize = true;
            this.lb_PasswordHint.ForeColor = System.Drawing.Color.DarkCyan;
            this.lb_PasswordHint.Location = new System.Drawing.Point(246, 227);
            this.lb_PasswordHint.Name = "lb_PasswordHint";
            this.lb_PasswordHint.Size = new System.Drawing.Size(80, 20);
            this.lb_PasswordHint.TabIndex = 4;
            this.lb_PasswordHint.Text = "Password";
            // 
            // panel_PasswordTb
            // 
            this.panel_PasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PasswordTb.Controls.Add(this.tb_Password);
            this.panel_PasswordTb.ForeColor = System.Drawing.Color.Black;
            this.panel_PasswordTb.Location = new System.Drawing.Point(250, 250);
            this.panel_PasswordTb.Name = "panel_PasswordTb";
            this.panel_PasswordTb.Size = new System.Drawing.Size(300, 40);
            this.panel_PasswordTb.TabIndex = 3;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Password.Location = new System.Drawing.Point(3, 7);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(292, 25);
            this.tb_Password.TabIndex = 0;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Login.Location = new System.Drawing.Point(250, 329);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(300, 40);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btn_Exit.FlatAppearance.BorderSize = 2;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Exit.Location = new System.Drawing.Point(250, 386);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(300, 40);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lb_PasswordHint);
            this.Controls.Add(this.panel_PasswordTb);
            this.Controls.Add(this.lb_AccountHint);
            this.Controls.Add(this.panel_AccountTb);
            this.Controls.Add(this.lb_LoginTitle);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.UCLogin_Load);
            this.panel_AccountTb.ResumeLayout(false);
            this.panel_AccountTb.PerformLayout();
            this.panel_PasswordTb.ResumeLayout(false);
            this.panel_PasswordTb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LoginTitle;
        private System.Windows.Forms.Panel panel_AccountTb;
        private System.Windows.Forms.Label lb_AccountHint;
        private System.Windows.Forms.TextBox tb_Account;
        private System.Windows.Forms.Label lb_PasswordHint;
        private System.Windows.Forms.Panel panel_PasswordTb;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
    }
}
