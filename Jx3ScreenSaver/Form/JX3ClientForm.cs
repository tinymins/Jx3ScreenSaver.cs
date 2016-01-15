using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver
{
    public partial class JX3ClientForm : Form
    {
        int m_screenIndex;

        public JX3ClientForm(int screenIndex)
        {
            m_screenIndex = screenIndex;
            InitializeComponent();

            Rectangle Bounds = Screen.AllScreens[screenIndex].Bounds;
            Top = Bounds.Top;
            Left = Bounds.Left;
            WindowState = FormWindowState.Maximized;
        }

        private void JX3ClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void JX3ClientForm_MouseDown(object sender, MouseEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void JX3ClientForm_MouseMove(object sender, MouseEventArgs e)
        {
            Global.OnMouseMove();
        }
    }
}
