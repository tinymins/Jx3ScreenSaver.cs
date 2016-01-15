﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        Graphics m_graphics;                    // Graphics drawing area
        private IntPtr m_parentWindowHandle;    // Handle to preview window, if applicable
        private Random m_random = new Random(); // Random object
        private Point m_mouseLocation;          // Keep track of the location of the mouse
        private string BG_MUSIC = Application.StartupPath + "\\BackgroundMusic.wav";

        public ScreenSaverForm(int parentWindowHandle)
        {
            m_parentWindowHandle = new IntPtr(parentWindowHandle);

            InitializeComponent();
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            // Use double buffering to improve drawing performance
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            if (m_parentWindowHandle == IntPtr.Zero)
            {
                // Screen saver is in full screen mode (i.e., not the preview window) - make form span all available system screens
                Left = ScreenArea.LeftMostBound;
                Top = ScreenArea.TopMostBound;
                Width = ScreenArea.TotalWidth;
                Height = ScreenArea.TotalHeight;
                TopMost = true;

                // Capture the mouse
                Capture = true;

                // Hide the mouse
                Cursor.Hide();
            }
            else
            {
                // Screen saver is in the preview window, set the new parent window
                WinAPI.SetParent(Handle, m_parentWindowHandle);

                // Make this a child window
                WinAPI.SetWindowLong(Handle, WinAPI.GWL_STYLE,
                    WinAPI.GetWindowLong(Handle, WinAPI.GWL_STYLE) | WinAPI.WS_CHILD);

                // Get the parent window size
                Rectangle rect;
                WinAPI.GetClientRect(m_parentWindowHandle, out rect);
                Size = rect.Size;
                Location = new Point(0, 0);
            }

            // Draw background from screen shot
            Bitmap bmpScreenshot = new Bitmap(ScreenArea.TotalWidth, ScreenArea.TotalHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(ScreenArea.LeftMostBound, ScreenArea.TopMostBound, 0, 0, ScreenArea.RectangleMostBound.Size, CopyPixelOperation.SourceCopy);
            BackgroundImage = bmpScreenshot;

            // Codes only run when not in preview mode
            if (!Global.IsPreviewMode)
            {
                // Set opacity
                Opacity = Properties.Settings.Default.BackgroundOpacity;

                // Try to play background music if exist
                if (System.IO.File.Exists(BG_MUSIC))
                    try
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = BG_MUSIC;
                        player.PlayLooping();
                    }
                    catch (Exception) { }

                // Create JX3 Form
                for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++)
                {
                    int index = i;
                    (new System.Threading.Thread(delegate() { System.Windows.Forms.Application.Run(new JX3ClientForm(index)); })).Start();
                }
            }

            // Record current mouse position
            m_mouseLocation = Control.MousePosition;

            // Set Timer
            DrawingTimer.Interval = Properties.Settings.Default.CreateInterval;
            DrawingTimer.Enabled = !Global.IsPreviewMode;
        }

        private void ScreenSaverForm_MouseDown(object sender, MouseEventArgs e)
        {
            Global.OnExitEvent();
        }

        public void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            Global.OnMouseMove();
        }

        private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            Global.OnExitEvent();
        }

        private void DrawingTimer_Tick(object sender, EventArgs e)
        {
            if (Jx3StoppedForm.InstanceCount >= Properties.Settings.Default.MaxInstanceCount)
                return;

            Jx3StoppedForm msgbox = new Jx3StoppedForm(Properties.Settings.Default.ClosingTime);
            msgbox.Show();
            msgbox.BringToFront();
            msgbox.Opacity = Properties.Settings.Default.ForegroundOpacity;
            msgbox.Top = Top + m_random.Next(0, Math.Max(Height - msgbox.Height, 0));
            msgbox.Left = Left + m_random.Next(0, Math.Max(Width - msgbox.Width, 0));
        }
    }
}
