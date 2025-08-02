namespace Class_Management_Tool {
    partial class FormMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btn_SizeToMin = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lb_AppTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopBar.Controls.Add(this.btn_SizeToMin);
            this.panelTopBar.Controls.Add(this.btn_Exit);
            this.panelTopBar.Controls.Add(this.lb_AppTitle);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(800, 35);
            this.panelTopBar.TabIndex = 0;
            // 
            // btn_SizeToMin
            // 
            this.btn_SizeToMin.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SizeToMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SizeToMin.FlatAppearance.BorderSize = 0;
            this.btn_SizeToMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SizeToMin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SizeToMin.ForeColor = System.Drawing.Color.Black;
            this.btn_SizeToMin.Location = new System.Drawing.Point(730, 0);
            this.btn_SizeToMin.Name = "btn_SizeToMin";
            this.btn_SizeToMin.Size = new System.Drawing.Size(34, 33);
            this.btn_SizeToMin.TabIndex = 3;
            this.btn_SizeToMin.Text = "-";
            this.btn_SizeToMin.UseVisualStyleBackColor = false;
            this.btn_SizeToMin.Click += new System.EventHandler(this.btn_SizeToMin_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(764, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(34, 33);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "×";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lb_AppTitle
            // 
            this.lb_AppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_AppTitle.Location = new System.Drawing.Point(0, 0);
            this.lb_AppTitle.Name = "lb_AppTitle";
            this.lb_AppTitle.Size = new System.Drawing.Size(503, 33);
            this.lb_AppTitle.TabIndex = 0;
            this.lb_AppTitle.Text = "Class Affairs Management Tool (Indev 1.0.0 Local Version)";
            this.lb_AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 465);
            this.panelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Class Affairs Management Tool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lb_AppTitle;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SizeToMin;
    }
}

