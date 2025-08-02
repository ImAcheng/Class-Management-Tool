using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Management_Tool {
    public partial class UCMainPage : UserControl {
        public UCMainPage() {
            InitializeComponent();
        }

        // Objects
        public static UCMainPage instance;

        // User Controls
        public static UserControl ucMainFn_PageMain = new UCMainFn_PageMain();

        private void UCMainPage_Load(object sender, EventArgs e) {
            instance = this;

            // uc
            ucMainFn_PageMain.Parent = panel_Main;
            ChangePanelUC(ucMainFn_PageMain);
        }

        #region method
        public void UpdateDisplayData() {
            lb_SchoolClassInfo.Text = $"{FormMain.CurrentAccount.SchoolNameEnglish} {FormMain.CurrentAccount.JoinedClass}";
            lb_DisplayName.Text = FormMain.CurrentAccount.DisplayName;

            lb_userInfo_Account.Text = "Account: " + FormMain.CurrentAccount.Username;
            lb_userInfo_Name.Text = "Name: " + FormMain.CurrentAccount.DisplayName;
            lb_userInfo_AccountType.Text = "Account Type: " + (FormMain.CurrentAccount.AccountType == 0 ? "Admin" : "Normal");
            lb_userInfo_Role.Text = "Role: " + (FormMain.CurrentAccount.ClassRole == 0 ? "Teacher" : (FormMain.CurrentAccount.ClassRole == 1 ? "Leader" : "Student"));
        }

        public void ChangePanelUC(UserControl target) {
            foreach (Control ctrl in panel_Main.Controls) {
                ctrl.Visible = ctrl == target;
            }
        }
        #endregion

        private void btn_UserInfoExtend_Click(object sender, EventArgs e) {
            if (panel_UerInfoExtend.Visible) {
                btn_UserInfoExtend.Image = Image.FromFile("ProgramData\\Resources\\img_btn_extend_open.png");
            }
            else {
                btn_UserInfoExtend.Image = Image.FromFile("ProgramData\\Resources\\img_btn_extend_close.png");
            }

            panel_UerInfoExtend.Visible = !panel_UerInfoExtend.Visible;
        }

        private void llb_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            panel_UerInfoExtend.Visible = false;
            btn_UserInfoExtend.Image = Image.FromFile("ProgramData\\Resources\\img_btn_extend_open.png");
            FormMain.instance.Logout();
        }
    }
}
