namespace Class_Management_Tool {
    partial class UCMainPage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMainPage));
            this.panel_TopBar = new System.Windows.Forms.Panel();
            this.btn_UserInfoExtend = new System.Windows.Forms.Button();
            this.lb_DisplayName = new System.Windows.Forms.Label();
            this.lb_SchoolClassInfo = new System.Windows.Forms.Label();
            this.panel_UerInfoExtend = new System.Windows.Forms.Panel();
            this.lb_userInfo_Account = new System.Windows.Forms.Label();
            this.lb_userInfo_Name = new System.Windows.Forms.Label();
            this.lb_userInfo_AccountType = new System.Windows.Forms.Label();
            this.lb_userInfo_Role = new System.Windows.Forms.Label();
            this.llb_logout = new System.Windows.Forms.LinkLabel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_TopBar.SuspendLayout();
            this.panel_UerInfoExtend.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TopBar
            // 
            this.panel_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_TopBar.Controls.Add(this.btn_UserInfoExtend);
            this.panel_TopBar.Controls.Add(this.lb_DisplayName);
            this.panel_TopBar.Controls.Add(this.lb_SchoolClassInfo);
            this.panel_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TopBar.Name = "panel_TopBar";
            this.panel_TopBar.Size = new System.Drawing.Size(1000, 60);
            this.panel_TopBar.TabIndex = 0;
            // 
            // btn_UserInfoExtend
            // 
            this.btn_UserInfoExtend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_UserInfoExtend.FlatAppearance.BorderSize = 0;
            this.btn_UserInfoExtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserInfoExtend.Image = ((System.Drawing.Image)(resources.GetObject("btn_UserInfoExtend.Image")));
            this.btn_UserInfoExtend.Location = new System.Drawing.Point(969, 0);
            this.btn_UserInfoExtend.Name = "btn_UserInfoExtend";
            this.btn_UserInfoExtend.Size = new System.Drawing.Size(31, 60);
            this.btn_UserInfoExtend.TabIndex = 1;
            this.btn_UserInfoExtend.UseVisualStyleBackColor = true;
            this.btn_UserInfoExtend.Click += new System.EventHandler(this.btn_UserInfoExtend_Click);
            // 
            // lb_DisplayName
            // 
            this.lb_DisplayName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_DisplayName.Location = new System.Drawing.Point(802, 0);
            this.lb_DisplayName.Name = "lb_DisplayName";
            this.lb_DisplayName.Size = new System.Drawing.Size(165, 60);
            this.lb_DisplayName.TabIndex = 2;
            this.lb_DisplayName.Text = "Name";
            this.lb_DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_SchoolClassInfo
            // 
            this.lb_SchoolClassInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_SchoolClassInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_SchoolClassInfo.Location = new System.Drawing.Point(0, 0);
            this.lb_SchoolClassInfo.Name = "lb_SchoolClassInfo";
            this.lb_SchoolClassInfo.Size = new System.Drawing.Size(750, 60);
            this.lb_SchoolClassInfo.TabIndex = 0;
            this.lb_SchoolClassInfo.Text = "School Class";
            this.lb_SchoolClassInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_UerInfoExtend
            // 
            this.panel_UerInfoExtend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_UerInfoExtend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_UerInfoExtend.Controls.Add(this.llb_logout);
            this.panel_UerInfoExtend.Controls.Add(this.lb_userInfo_Role);
            this.panel_UerInfoExtend.Controls.Add(this.lb_userInfo_AccountType);
            this.panel_UerInfoExtend.Controls.Add(this.lb_userInfo_Name);
            this.panel_UerInfoExtend.Controls.Add(this.lb_userInfo_Account);
            this.panel_UerInfoExtend.Location = new System.Drawing.Point(785, 66);
            this.panel_UerInfoExtend.Name = "panel_UerInfoExtend";
            this.panel_UerInfoExtend.Size = new System.Drawing.Size(208, 158);
            this.panel_UerInfoExtend.TabIndex = 1;
            this.panel_UerInfoExtend.Visible = false;
            // 
            // lb_userInfo_Account
            // 
            this.lb_userInfo_Account.AutoSize = true;
            this.lb_userInfo_Account.Location = new System.Drawing.Point(8, 8);
            this.lb_userInfo_Account.Name = "lb_userInfo_Account";
            this.lb_userInfo_Account.Size = new System.Drawing.Size(76, 20);
            this.lb_userInfo_Account.TabIndex = 0;
            this.lb_userInfo_Account.Text = "Account:";
            // 
            // lb_userInfo_Name
            // 
            this.lb_userInfo_Name.AutoSize = true;
            this.lb_userInfo_Name.Location = new System.Drawing.Point(8, 38);
            this.lb_userInfo_Name.Name = "lb_userInfo_Name";
            this.lb_userInfo_Name.Size = new System.Drawing.Size(59, 20);
            this.lb_userInfo_Name.TabIndex = 1;
            this.lb_userInfo_Name.Text = "Name:";
            // 
            // lb_userInfo_AccountType
            // 
            this.lb_userInfo_AccountType.AutoSize = true;
            this.lb_userInfo_AccountType.Location = new System.Drawing.Point(8, 68);
            this.lb_userInfo_AccountType.Name = "lb_userInfo_AccountType";
            this.lb_userInfo_AccountType.Size = new System.Drawing.Size(116, 20);
            this.lb_userInfo_AccountType.TabIndex = 2;
            this.lb_userInfo_AccountType.Text = "Account Type:";
            // 
            // lb_userInfo_Role
            // 
            this.lb_userInfo_Role.AutoSize = true;
            this.lb_userInfo_Role.Location = new System.Drawing.Point(8, 98);
            this.lb_userInfo_Role.Name = "lb_userInfo_Role";
            this.lb_userInfo_Role.Size = new System.Drawing.Size(46, 20);
            this.lb_userInfo_Role.TabIndex = 3;
            this.lb_userInfo_Role.Text = "Role:";
            // 
            // llb_logout
            // 
            this.llb_logout.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.llb_logout.AutoSize = true;
            this.llb_logout.LinkColor = System.Drawing.Color.DarkCyan;
            this.llb_logout.Location = new System.Drawing.Point(8, 128);
            this.llb_logout.Name = "llb_logout";
            this.llb_logout.Size = new System.Drawing.Size(67, 20);
            this.llb_logout.TabIndex = 4;
            this.llb_logout.TabStop = true;
            this.llb_logout.Text = "Log out";
            this.llb_logout.VisitedLinkColor = System.Drawing.Color.DarkSlateGray;
            this.llb_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_logout_LinkClicked);
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 60);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1000, 590);
            this.panel_Main.TabIndex = 34;
            // 
            // UCMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_UerInfoExtend);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_TopBar);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCMainPage";
            this.Size = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.UCMainPage_Load);
            this.panel_TopBar.ResumeLayout(false);
            this.panel_UerInfoExtend.ResumeLayout(false);
            this.panel_UerInfoExtend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TopBar;
        private System.Windows.Forms.Label lb_SchoolClassInfo;
        private System.Windows.Forms.Label lb_DisplayName;
        private System.Windows.Forms.Button btn_UserInfoExtend;
        private System.Windows.Forms.Panel panel_UerInfoExtend;
        private System.Windows.Forms.Label lb_userInfo_Name;
        private System.Windows.Forms.Label lb_userInfo_Account;
        private System.Windows.Forms.Label lb_userInfo_Role;
        private System.Windows.Forms.Label lb_userInfo_AccountType;
        private System.Windows.Forms.LinkLabel llb_logout;
        private System.Windows.Forms.Panel panel_Main;
    }
}
