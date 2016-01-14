using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Resources;
using System.Windows.Forms;

namespace ScreenSaver
{
    public class ScreenSaverForm : System.Windows.Forms.Form
    {
        const int IMAGE_MAX_INDEX = 4;
        const int PICBOX_MAX_COUNT = 120;
        private System.ComponentModel.IContainer components;
        private ResourceManager rs = new ResourceManager(typeof(ScreenSaverForm));
        private PictureBox[] pics = new PictureBox[PICBOX_MAX_COUNT];
        private Point MouseXY;
        private Random random = new Random();
        private Timer timer;
        private PictureBox picBg;
        private Label lblMark;

        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void ScreenSaverForm_Load(object sender, System.EventArgs e)
        {
            Left = ScreenArea.LeftMostBound;
            Top = ScreenArea.TopMostBound;
            Width = ScreenArea.TotalWidth;
            Height = ScreenArea.TotalHeight;
            Bounds = new Rectangle(Left, Top, Width, Height);
            TopMost = true;
            //this.TransparencyKey = Color.Green;

            Bitmap bmpScreenshot = new Bitmap(Bounds.Width, Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Left, Top, 0, 0, (new Rectangle(Left, Top, Width, Height)).Size, CopyPixelOperation.SourceCopy);
            picBg.Image = bmpScreenshot;

            for (int i = 0; i < PICBOX_MAX_COUNT; i++)
            {
                PictureBox pic = new PictureBox();
                pic.SizeMode = PictureBoxSizeMode.AutoSize;
                pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
                pic.Hide();
                pics[i] = pic;
                Controls.Add(pic);
            }
           Cursor.Hide();
        }

        private void ScreenSaverForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Close();
        }

        private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!MouseXY.IsEmpty)
            {
                if (e.Clicks > 0 || Math.Abs(MouseXY.X - Control.MousePosition.X) > 10 || Math.Abs(MouseXY.Y - Control.MousePosition.Y) > 10)
                {
                    Close();
                }
            }
            MouseXY = new Point(Control.MousePosition.X, Control.MousePosition.Y);
        }

        private PictureBox GetIdlePicBox()
        {
            foreach (PictureBox pic in pics)
            {
                if (!pic.Visible)
                {
                    return pic;
                }
            }
            return null;
        }

        private int picVisitIndex = 0;
        private PictureBox GetOldestPicBox()
        {
            PictureBox pic = this.pics[picVisitIndex];
            picVisitIndex = (picVisitIndex + 1) % PICBOX_MAX_COUNT;
            return pic;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            PictureBox pic = GetIdlePicBox();
            if (pic == null)
                pic = GetOldestPicBox();

            pic.Show();
            pic.Image = (Image)rs.GetObject("Image" + random.Next(0, IMAGE_MAX_INDEX));
            pic.Left = random.Next(this.Bounds.Width - pic.Width);
            pic.Top = random.Next(this.Bounds.Height - pic.Height);
            // pic.Scale(new SizeF { Width = 0.8f, Height = 0.8f });
            pic.BringToFront();
            lblMark.BringToFront();
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblMark = new System.Windows.Forms.Label();
            this.picBg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblMark
            // 
            this.lblMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMark.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMark.Location = new System.Drawing.Point(212, 247);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(68, 17);
            this.lblMark.TabIndex = 0;
            this.lblMark.Text = "@Ò»ÃûÕ¬";
            // 
            // picBg
            // 
            this.picBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBg.Location = new System.Drawing.Point(0, 0);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(292, 273);
            this.picBg.TabIndex = 1;
            this.picBg.TabStop = false;
            this.picBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.picBg);
            this.Controls.Add(this.lblMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.Text = "ScreenSaver";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
