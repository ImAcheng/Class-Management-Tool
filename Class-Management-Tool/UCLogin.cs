using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Class_Management_Tool {
    public partial class UCLogin : UserControl {
        public UCLogin() {
            InitializeComponent();
        }

        private void UCLogin_Load(object sender, EventArgs e) {

        }

        #region methods 
        private void CheckLogin(string Username) {
            using (StreamReader reader = new StreamReader("UserData\\Accounts.json")) {
                JObject AccData;
                try {
                    AccData = JObject.Parse(reader.ReadToEnd());
                }
                catch {
                    MessageBox.Show("Some Errors Occurred while loading account data.");
                    return;
                }

                if (!AccData.ContainsKey(Username)) {
                    MessageBox.Show($"Account \"{Username}\" is not exist.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Account acc = new Account(Username);

                if (acc.Password != tb_Password.Text) {
                    MessageBox.Show($"Password is incorrect.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Welcome back, {acc.DisplayName}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Account.Clear();
                tb_Password.Clear();
                FormMain.instance.Login(acc);
            }
        }
        #endregion

        private void btn_Login_Click(object sender, EventArgs e) {
            CheckLogin(tb_Account.Text);
        }

        private void btn_Exit_Click(object sender, EventArgs e) {
            FormMain.instance.FormBorderStyle = FormBorderStyle.FixedSingle;
            Environment.Exit(0);
        }
    }
}
