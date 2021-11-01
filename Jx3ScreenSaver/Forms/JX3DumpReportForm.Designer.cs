
namespace Jx3ScreenSaver.Forms
{
    partial class JX3DumpReportForm
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
            this.components = new System.ComponentModel.Container();
            this.ClosingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ClosingTimer
            // 
            this.ClosingTimer.Enabled = true;
            this.ClosingTimer.Tick += new System.EventHandler(this.ClosingTimer_Tick);
            // 
            // JX3DumpReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 195);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JX3DumpReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "JX3DumpReportForm";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.JX3DumpReportForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JX3DumpReportForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JX3DumpReportForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JX3DumpReportForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JX3DumpReportForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ClosingTimer;
    }
}