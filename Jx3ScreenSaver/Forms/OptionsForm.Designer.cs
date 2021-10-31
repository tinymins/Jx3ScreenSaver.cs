namespace Jx3ScreenSaver.Forms
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.lblBgMusicTip = new System.Windows.Forms.Label();
            this.numericUpDownMaxInstanceCount = new System.Windows.Forms.NumericUpDown();
            this.lblMaxInstanceCount = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.numericUpDownClosingTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCreateInterval = new System.Windows.Forms.NumericUpDown();
            this.lblClosingTime = new System.Windows.Forms.Label();
            this.lblCreateInterval = new System.Windows.Forms.Label();
            this.numericUpDownForegroundOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblForegroundOpacity = new System.Windows.Forms.Label();
            this.numericUpDownBackgroundOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblBackgroundOpacity = new System.Windows.Forms.Label();
            this.groupBoxAbout = new System.Windows.Forms.GroupBox();
            this.lblAuthour = new System.Windows.Forms.Label();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBoxSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInstanceCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClosingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForegroundOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackgroundOpacity)).BeginInit();
            this.groupBoxAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetting.Controls.Add(this.lblBgMusicTip);
            this.groupBoxSetting.Controls.Add(this.numericUpDownMaxInstanceCount);
            this.groupBoxSetting.Controls.Add(this.lblMaxInstanceCount);
            this.groupBoxSetting.Controls.Add(this.btnApply);
            this.groupBoxSetting.Controls.Add(this.numericUpDownClosingTime);
            this.groupBoxSetting.Controls.Add(this.numericUpDownCreateInterval);
            this.groupBoxSetting.Controls.Add(this.lblClosingTime);
            this.groupBoxSetting.Controls.Add(this.lblCreateInterval);
            this.groupBoxSetting.Controls.Add(this.numericUpDownForegroundOpacity);
            this.groupBoxSetting.Controls.Add(this.lblForegroundOpacity);
            this.groupBoxSetting.Controls.Add(this.numericUpDownBackgroundOpacity);
            this.groupBoxSetting.Controls.Add(this.lblBackgroundOpacity);
            this.groupBoxSetting.Location = new System.Drawing.Point(18, 18);
            this.groupBoxSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSetting.Size = new System.Drawing.Size(368, 371);
            this.groupBoxSetting.TabIndex = 0;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "设置";
            // 
            // lblBgMusicTip
            // 
            this.lblBgMusicTip.AllowDrop = true;
            this.lblBgMusicTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBgMusicTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBgMusicTip.Location = new System.Drawing.Point(26, 309);
            this.lblBgMusicTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBgMusicTip.Name = "lblBgMusicTip";
            this.lblBgMusicTip.Size = new System.Drawing.Size(330, 54);
            this.lblBgMusicTip.TabIndex = 11;
            this.lblBgMusicTip.Text = "背景音乐: 将 BackgroundMusic.wav 放入屏幕保护(.scr)文件相同目录下即可播放";
            // 
            // numericUpDownMaxInstanceCount
            // 
            this.numericUpDownMaxInstanceCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMaxInstanceCount.Location = new System.Drawing.Point(248, 198);
            this.numericUpDownMaxInstanceCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownMaxInstanceCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxInstanceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxInstanceCount.Name = "numericUpDownMaxInstanceCount";
            this.numericUpDownMaxInstanceCount.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownMaxInstanceCount.TabIndex = 10;
            this.numericUpDownMaxInstanceCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblMaxInstanceCount
            // 
            this.lblMaxInstanceCount.AutoSize = true;
            this.lblMaxInstanceCount.Location = new System.Drawing.Point(30, 202);
            this.lblMaxInstanceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxInstanceCount.Name = "lblMaxInstanceCount";
            this.lblMaxInstanceCount.Size = new System.Drawing.Size(93, 20);
            this.lblMaxInstanceCount.TabIndex = 9;
            this.lblMaxInstanceCount.Text = "最大弹框数:";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(34, 255);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(297, 35);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "确定";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // numericUpDownClosingTime
            // 
            this.numericUpDownClosingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownClosingTime.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownClosingTime.Location = new System.Drawing.Point(248, 158);
            this.numericUpDownClosingTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownClosingTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownClosingTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownClosingTime.Name = "numericUpDownClosingTime";
            this.numericUpDownClosingTime.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownClosingTime.TabIndex = 7;
            this.numericUpDownClosingTime.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDownCreateInterval
            // 
            this.numericUpDownCreateInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCreateInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCreateInterval.Location = new System.Drawing.Point(248, 118);
            this.numericUpDownCreateInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownCreateInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCreateInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCreateInterval.Name = "numericUpDownCreateInterval";
            this.numericUpDownCreateInterval.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownCreateInterval.TabIndex = 6;
            this.numericUpDownCreateInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblClosingTime
            // 
            this.lblClosingTime.AutoSize = true;
            this.lblClosingTime.Location = new System.Drawing.Point(30, 162);
            this.lblClosingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClosingTime.Name = "lblClosingTime";
            this.lblClosingTime.Size = new System.Drawing.Size(77, 20);
            this.lblClosingTime.TabIndex = 5;
            this.lblClosingTime.Text = "关闭时间:";
            // 
            // lblCreateInterval
            // 
            this.lblCreateInterval.AutoSize = true;
            this.lblCreateInterval.Location = new System.Drawing.Point(30, 122);
            this.lblCreateInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateInterval.Name = "lblCreateInterval";
            this.lblCreateInterval.Size = new System.Drawing.Size(77, 20);
            this.lblCreateInterval.TabIndex = 4;
            this.lblCreateInterval.Text = "弹窗间隔:";
            // 
            // numericUpDownForegroundOpacity
            // 
            this.numericUpDownForegroundOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownForegroundOpacity.Location = new System.Drawing.Point(248, 78);
            this.numericUpDownForegroundOpacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownForegroundOpacity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownForegroundOpacity.Name = "numericUpDownForegroundOpacity";
            this.numericUpDownForegroundOpacity.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownForegroundOpacity.TabIndex = 3;
            // 
            // lblForegroundOpacity
            // 
            this.lblForegroundOpacity.AutoSize = true;
            this.lblForegroundOpacity.Location = new System.Drawing.Point(30, 82);
            this.lblForegroundOpacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForegroundOpacity.Name = "lblForegroundOpacity";
            this.lblForegroundOpacity.Size = new System.Drawing.Size(93, 20);
            this.lblForegroundOpacity.TabIndex = 2;
            this.lblForegroundOpacity.Text = "前景透明度:";
            // 
            // numericUpDownBackgroundOpacity
            // 
            this.numericUpDownBackgroundOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBackgroundOpacity.Location = new System.Drawing.Point(248, 38);
            this.numericUpDownBackgroundOpacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownBackgroundOpacity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBackgroundOpacity.Name = "numericUpDownBackgroundOpacity";
            this.numericUpDownBackgroundOpacity.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownBackgroundOpacity.TabIndex = 1;
            // 
            // lblBackgroundOpacity
            // 
            this.lblBackgroundOpacity.AutoSize = true;
            this.lblBackgroundOpacity.Location = new System.Drawing.Point(30, 42);
            this.lblBackgroundOpacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackgroundOpacity.Name = "lblBackgroundOpacity";
            this.lblBackgroundOpacity.Size = new System.Drawing.Size(93, 20);
            this.lblBackgroundOpacity.TabIndex = 0;
            this.lblBackgroundOpacity.Text = "背景透明度:";
            // 
            // groupBoxAbout
            // 
            this.groupBoxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAbout.Controls.Add(this.lblAuthour);
            this.groupBoxAbout.Controls.Add(this.linkUpdate);
            this.groupBoxAbout.Controls.Add(this.lblVersion);
            this.groupBoxAbout.Location = new System.Drawing.Point(18, 398);
            this.groupBoxAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAbout.Name = "groupBoxAbout";
            this.groupBoxAbout.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAbout.Size = new System.Drawing.Size(368, 165);
            this.groupBoxAbout.TabIndex = 1;
            this.groupBoxAbout.TabStop = false;
            this.groupBoxAbout.Text = "关于";
            // 
            // lblAuthour
            // 
            this.lblAuthour.AutoSize = true;
            this.lblAuthour.Location = new System.Drawing.Point(28, 46);
            this.lblAuthour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthour.Name = "lblAuthour";
            this.lblAuthour.Size = new System.Drawing.Size(81, 20);
            this.lblAuthour.TabIndex = 2;
            this.lblAuthour.Text = "作者: 茗伊";
            // 
            // linkUpdate
            // 
            this.linkUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.Location = new System.Drawing.Point(276, 126);
            this.linkUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(73, 20);
            this.linkUpdate.TabIndex = 1;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "检查更新";
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdate_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(28, 86);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(81, 20);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "当前版本: ";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 582);
            this.Controls.Add(this.groupBoxAbout);
            this.Controls.Add(this.groupBoxSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置 & 关于";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInstanceCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClosingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForegroundOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackgroundOpacity)).EndInit();
            this.groupBoxAbout.ResumeLayout(false);
            this.groupBoxAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.Label lblBackgroundOpacity;
        private System.Windows.Forms.NumericUpDown numericUpDownForegroundOpacity;
        private System.Windows.Forms.Label lblForegroundOpacity;
        private System.Windows.Forms.NumericUpDown numericUpDownBackgroundOpacity;
        private System.Windows.Forms.Label lblClosingTime;
        private System.Windows.Forms.Label lblCreateInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownClosingTime;
        private System.Windows.Forms.NumericUpDown numericUpDownCreateInterval;
        private System.Windows.Forms.GroupBox groupBoxAbout;
        private System.Windows.Forms.Label lblAuthour;
        private System.Windows.Forms.LinkLabel linkUpdate;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxInstanceCount;
        private System.Windows.Forms.Label lblMaxInstanceCount;
        private System.Windows.Forms.Label lblBgMusicTip;
    }
}