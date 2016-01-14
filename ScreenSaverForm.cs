using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class ScreenSaverForm : System.Windows.Forms.Form
	{
        const int IMAGE_MAX_INDEX = 2;
        const int PICBOX_MAX_COUNT = 120;
        private System.ComponentModel.IContainer components;
        private ResourceManager rs = new ResourceManager(typeof(ScreenSaverForm));
        private PictureBox[] pics;
        private Point MouseXY;
        private Random random;
        private Timer timer1;
        private Label lblMark;
		private int ScreenNumber;

		public ScreenSaverForm(int scrn)
		{
			InitializeComponent();
			ScreenNumber = scrn;
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void ScreenSaverForm_Load(object sender, System.EventArgs e)
		{
            this.TransparencyKey = Color.Green;
            this.Bounds = Screen.AllScreens[ScreenNumber].Bounds;
            this.random = new Random();
            this.pics = new PictureBox[PICBOX_MAX_COUNT];
            for (int i = 0; i < PICBOX_MAX_COUNT; i++)
            {
                PictureBox pic = new PictureBox();
                pic.SizeMode = PictureBoxSizeMode.AutoSize;
                pic.Hide();
                this.pics[i] = pic;
                this.Controls.Add(pic);
            }
			Cursor.Hide();
			TopMost = true;
		}

		private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!MouseXY.IsEmpty)
			{
				if (MouseXY != new Point(e.X, e.Y))
					Close();
				if (e.Clicks > 0)
					Close();
			}
			MouseXY = new Point(e.X, e.Y);
		}
		
		private void ScreenSaverForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			Close();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.lblMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMark.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMark.Location = new System.Drawing.Point(212, 247);
            this.lblMark.Name = "label1";
            this.lblMark.Size = new System.Drawing.Size(68, 17);
            this.lblMark.TabIndex = 0;
            this.lblMark.Text = "@Ò»ÃûÕ¬";
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lblMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.Text = "ScreenSaver";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

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

        private void timer1_Tick(object sender, EventArgs e)
        {

            PictureBox pic = GetIdlePicBox();
            if (pic == null)
                pic = GetOldestPicBox();
            
            pic.Show();
            pic.Image = (System.Drawing.Image)rs.GetObject("Image" + random.Next(0, IMAGE_MAX_INDEX));
            pic.Left = random.Next(this.Bounds.Width - pic.Width);
            pic.Top = random.Next(this.Bounds.Height - pic.Height);
            // pic.Scale(new SizeF { Width = 0.8f, Height = 0.8f });
            pic.BringToFront();
            lblMark.BringToFront();
        }
	}
}
