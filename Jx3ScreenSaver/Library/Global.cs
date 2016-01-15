using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jx3ScreenSaver
{
    static class Global
    {
        // Set or get is preview mode
        public static bool IsPreviewMode { set; get; }

        // Remember last mouse location
        private static Point m_mouseLocation;

        // Common on mouse move event handler
        public static void OnMouseMove()
        {
            if (!IsPreviewMode
                && !m_mouseLocation.IsEmpty
                && (Math.Abs(m_mouseLocation.X - Control.MousePosition.X) > 10 || Math.Abs(m_mouseLocation.Y - Control.MousePosition.Y) > 10)
                )
            {
                Exit();
            }
            m_mouseLocation = Control.MousePosition;
        }

        // Common exit event handler
        public static void OnExitEvent()
        {
            if (!IsPreviewMode)
                Exit();
        }

        // Exit application
        public static void Exit()
        {
            Application.Exit();
        }
    }
}
