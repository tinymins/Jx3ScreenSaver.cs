using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            numericUpDownClosingTime.Value = Properties.Settings.Default.ClosingTime;
            numericUpDownCreateInterval.Value = Properties.Settings.Default.CreateInterval;
            numericUpDownMaxInstanceCount.Value = Properties.Settings.Default.MaxInstanceCount;
            numericUpDownBackgroundOpacity.Value = (decimal)((1 - Properties.Settings.Default.BackgroundOpacity) * 255);
            numericUpDownForegroundOpacity.Value = (decimal)((1 - Properties.Settings.Default.ForegroundOpacity) * 255);
            lblVersion.Text += Application.ProductVersion.ToString();
        }

        private void linkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://zhaiyiming.com/index.php/jx3-screen-saver/?ver=" + Application.ProductVersion.ToString());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClosingTime = (int)numericUpDownClosingTime.Value;
            Properties.Settings.Default.CreateInterval = (int)numericUpDownCreateInterval.Value;
            Properties.Settings.Default.MaxInstanceCount = (int)numericUpDownMaxInstanceCount.Value;
            Properties.Settings.Default.BackgroundOpacity = 1 - ((double)numericUpDownBackgroundOpacity.Value / 255);
            Properties.Settings.Default.ForegroundOpacity = 1 - ((double)numericUpDownForegroundOpacity.Value / 255);
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
