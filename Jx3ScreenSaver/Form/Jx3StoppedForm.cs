using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver
{
    public partial class Jx3StoppedForm : Form
    {
        private static int m_InstanceCount = 0;
        public static int InstanceCount { get { return m_InstanceCount; } set { return;} }

        public Jx3StoppedForm(int closeTime)
        {
            InitializeComponent();

            // Set closing timer.
            ClosingTimer.Interval = closeTime;
            ClosingTimer.Enabled = true;

            // Set out of screen to avoid spark.
            Top = ScreenArea.TotalHeight;
            Left = ScreenArea.TotalWidth;

            // Increase instance counter.
            m_InstanceCount++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Jx3StoppedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_InstanceCount--;
        }

        private void Jx3StoppedForm_KeyDown(object sender, KeyEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void Jx3StoppedForm_MouseDown(object sender, MouseEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void Jx3StoppedForm_MouseMove(object sender, MouseEventArgs e)
        {
            Global.OnMouseMove();
        }
    }
}
