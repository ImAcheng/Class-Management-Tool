using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Management_Tool {
    public class Account {
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string JoinedClass { get; set; }
        public int AccountType { get; set; } // 0: adminstor, 1: normal
        public int ClassRole { get; set; } // 0: teacher, 1: class leaders, 2: normal
        public string SchoolNameMandarin { get; set; }
        public string SchoolNameEnglish { get; set; }

        public Account(string username) {
            using (StreamReader reader = new StreamReader("UserData\\Accounts.json")) {
                JObject AccData;
                try {
                    AccData = JObject.Parse(reader.ReadToEnd());
                }
                catch {
                    MessageBox.Show("Some Errors Occurred while loading account data.");
                    return;
                }

                JObject accGet = JObject.FromObject(AccData[username]);

                int converter_temp = 0;

                Username = accGet["username"].ToString();
                Password = accGet["password"].ToString();
                DisplayName = accGet["display_name"].ToString();
                JoinedClass = accGet["joined_class"].ToString();
                AccountType = Int32.TryParse(accGet["account_type"].ToString(), out converter_temp) ? converter_temp : 1;
                ClassRole = Int32.TryParse(accGet["class_role"].ToString(), out converter_temp) ? converter_temp : 2;
                SchoolNameMandarin = accGet["school_zh_tw"].ToString();
                SchoolNameEnglish = accGet["school_en_us"].ToString();
            }
        }
    }
}
