using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Class_Management_Tool {
    public partial class FormMain : Form {

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // events
            panelTopBar.MouseDown += WindowsDrag_MouseDown;
            panelTopBar.MouseUp += WindowsDrag_MouseUp;
            panelTopBar.MouseMove += WindowsDrag_MouseMove;
            foreach (Control ctrl in panelTopBar.Controls) {
                if (ctrl.GetType() == typeof(Button)) continue;

                ctrl.MouseDown += WindowsDrag_MouseDown;
                ctrl.MouseUp += WindowsDrag_MouseUp;
                ctrl.MouseMove += WindowsDrag_MouseMove;
            }

            this.FormBorderStyle = FormBorderStyle.None;
        }

        #region Top bar
        private bool WD_isMouseLeftDown = false;
        private Point WD_StartDragginPoint;
        private void WindowsDrag_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WD_isMouseLeftDown = true;
                WD_StartDragginPoint = e.Location;
            }
        }

        private void WindowsDrag_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WD_isMouseLeftDown = false;
            }
        } 

        private void WindowsDrag_MouseMove(object sender, MouseEventArgs e) {
            if (!WD_isMouseLeftDown) return;

            this.Top += e.Location.Y - WD_StartDragginPoint.Y;
            this.Left += e.Location.X - WD_StartDragginPoint.X;
        }

        private void btn_Exit_Click(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Environment.Exit(0);
        }

        private void btn_SizeToMin_Click(object sender, EventArgs e) {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        #endregion

        #region methods
        #endregion
    }
}
