namespace Jx3ScreenSaver
{
    partial class JX3ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JX3ClientForm));
            this.SuspendLayout();
            // 
            // JX3ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 556);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JX3ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "剑侠情缘网络版叁(无响应)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JX3ClientForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JX3ClientForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JX3ClientForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}