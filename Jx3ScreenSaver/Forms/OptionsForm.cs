using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            numericUpDownClosingTime.Value       = Settings.ClosingTime;
            numericUpDownCreateInterval.Value    = Settings.CreateInterval;
            numericUpDownMaxInstanceCount.Value  = Settings.MaxInstanceCount;
            numericUpDownBackgroundOpacity.Value = (decimal)((1 - Settings.BackgroundOpacity) * 255);
            numericUpDownForegroundOpacity.Value = (decimal)((1 - Settings.ForegroundOpacity) * 255);
            lblVersion.Text += Application.ProductVersion.ToString();
        }

        private void linkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://zhaiyiming.com/index.php/jx3-screen-saver/?ver=" + Application.ProductVersion.ToString());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Settings.ClosingTime = (int)numericUpDownClosingTime.Value;
            Settings.CreateInterval = (int)numericUpDownCreateInterval.Value;
            Settings.MaxInstanceCount = (int)numericUpDownMaxInstanceCount.Value;
            Settings.BackgroundOpacity = 1 - ((double)numericUpDownBackgroundOpacity.Value / 255);
            Settings.ForegroundOpacity = 1 - ((double)numericUpDownForegroundOpacity.Value / 255);
            Close();
        }
    }
}
