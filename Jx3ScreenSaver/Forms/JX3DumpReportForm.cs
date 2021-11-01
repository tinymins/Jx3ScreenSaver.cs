using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver.Forms
{
    public partial class JX3DumpReportForm : Form
    {
        private static int m_InstanceCount = 0;
        public static int InstanceCount { get { return m_InstanceCount; } set { return; } }

        private void MyInitializeComponent()
        {
            //this.InitializeDialogBaseUnit();

            this.SuspendLayout();

            /* DIALOGEX */
            this.Size = new Size(465, 419);
            this.Text = "错误报告";

            /* Top image box */
            PictureBox picProduct = new PictureBox();
            picProduct.Image = Properties.Resources.Bitmap130;
            picProduct.Location = new Point(0, 0);
            picProduct.Size = new Size(449, 78);
            picProduct.Dock = DockStyle.Top;
            picProduct.BackColor = Color.White;
            picProduct.BorderStyle = BorderStyle.None;
            picProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            picProduct.Paint += (sender, e) =>
                ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                    SystemColors.ControlLightLight, 0, ButtonBorderStyle.None,
                    SystemColors.ControlLightLight, 0, ButtonBorderStyle.None,
                    SystemColors.ControlLightLight, 0, ButtonBorderStyle.None,
                    SystemColors.ControlLightLight, 1, ButtonBorderStyle.Outset);
            picProduct.KeyDown += (sender, e) => this.Close();
            this.Controls.Add(picProduct);

            /* Text label 1 */
            Label lblMessage1 = new Label();
            lblMessage1.AutoSize = false;
            lblMessage1.Location = new Point(12, 91);
            lblMessage1.Size = new Size(426, 13);
            lblMessage1.Text = "非常抱歉！客户端程序发生了意外错误，即将终止运行。";
            lblMessage1.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(lblMessage1);

            /* Text label 2 */
            Label lblMessage2 = new Label();
            lblMessage2.AutoSize = false;
            lblMessage2.Location = new Point(12, 117);
            lblMessage2.Size = new Size(401, 13);
            lblMessage2.Text = "为了改进我们的产品，生成了一份错误报告，并希望您将报告发送给我们。";
            lblMessage2.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(lblMessage2);

            /* Text label 3 */
            Label lblMessage3 = new Label();
            lblMessage3.AutoSize = false;
            lblMessage3.Location = new Point(12, 141);
            lblMessage3.Size = new Size(228, 13);
            lblMessage3.Text = "错误报告中，不包含任何您的私人信息。";
            lblMessage3.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(lblMessage3);

            /* Label for view dump data */
            Label lblViewDump = new Label();
            lblViewDump.AutoSize = false;
            lblViewDump.BackColor = Color.White;
            lblViewDump.ForeColor = Color.Blue;
            lblViewDump.Location = new Point(270, 141);
            lblViewDump.Size = new Size(101, 13);
            lblViewDump.Text = "查看错误报告内容";
            lblViewDump.Click += (sender, e) => Global.OnExitEvent();
            lblViewDump.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(lblViewDump);

            /* Group Box for feedback Text Box */
            GroupBox grpFeedBack = new GroupBox();
            grpFeedBack.Location = new Point(5, 197);
            grpFeedBack.Size = new Size(443, 128);
            grpFeedBack.Text = "请输入反馈信息（如错误发生时您正在做的操作）";
            grpFeedBack.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(grpFeedBack);

            /* Text Box for feedback */
            TextBox txtFeedBack = new TextBox();
            txtFeedBack.Location = new Point(17, 218);
            txtFeedBack.Size = new Size(417, 99);
            txtFeedBack.Text = "";
            txtFeedBack.Multiline = true;
            txtFeedBack.ScrollBars = ScrollBars.Vertical;
            txtFeedBack.BorderStyle = BorderStyle.Fixed3D;
            txtFeedBack.KeyDown += (sender, e) => Global.OnExitEvent();
            txtFeedBack.Click += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(txtFeedBack);
            txtFeedBack.BringToFront();


            /* Restart checkbox */
            CheckBox chkRestart = new CheckBox();
            chkRestart.Location = new Point(14, 353);
            chkRestart.Size = new Size(117, 16);
            chkRestart.Text = "重新启动程序";
            chkRestart.Click += (sender, e) => Global.OnExitEvent();
            chkRestart.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(chkRestart);

            /* Send Report button */
            Button btnSendReport = new Button();
            btnSendReport.Location = new Point(270, 346);
            btnSendReport.Size = new Size(98, 23);
            btnSendReport.Text = "发送错误报告";
            btnSendReport.FlatStyle = FlatStyle.Flat;
            btnSendReport.FlatAppearance.BorderSize = 0;
            btnSendReport.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnSendReport.Paint += (sender, e) =>
                ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            btnSendReport.Click += (sender, e) => Global.OnExitEvent();
            btnSendReport.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(btnSendReport);

            /* Exit button */
            Button btnExit = new Button();
            btnExit.Location = new Point(377, 346);
            btnExit.Size = new Size(63, 23);
            btnExit.Text = "退出";
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnExit.Paint += (sender, e) =>
                ControlPaint.DrawBorder(e.Graphics, ((Control)sender).ClientRectangle,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            btnExit.Click += (sender, e) => Global.OnExitEvent();
            btnExit.KeyDown += (sender, e) => Global.OnExitEvent();
            this.Controls.Add(btnExit);
            this.ResumeLayout(false);
        }

        public JX3DumpReportForm(int closeTime)
        {
            InitializeComponent();
            this.MyInitializeComponent();

            // Set closing timer.
            ClosingTimer.Interval = closeTime;
            ClosingTimer.Enabled = true;

            // Set out of screen to avoid spark.
            Top = ScreenArea.TotalHeight;
            Left = ScreenArea.TotalWidth;

            // Increase instance counter.
            m_InstanceCount++;
        }

        private void JX3DumpReportForm_Activated(object sender, EventArgs e)
        {
            //this.ActiveControl = null;
        }

        private void JX3DumpReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void JX3DumpReportForm_MouseDown(object sender, MouseEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void JX3DumpReportForm_MouseMove(object sender, MouseEventArgs e)
        {
            Global.OnMouseMove();
        }

        private void JX3DumpReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_InstanceCount--;
        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
