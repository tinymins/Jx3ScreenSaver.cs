using Jx3ScreenSaver.Forms;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Jx3ScreenSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int iHandle = 0;
            if (args.Length > 0)
            {
                string arg = args[0].ToLower(CultureInfo.InvariantCulture).Trim().Substring(0, 2);
                switch (arg)
                {
                    case "/c":  // config
                        OptionsForm optionsForm = new OptionsForm();
                        Application.Run(optionsForm);
                        return;

                    case "/p":  // preview
                        if (args.Length == 2)
                            int.TryParse(args[1], out iHandle);
                        break;

                    case "/s": // show
                    default:
                        break;
                }
            }
            Global.IsPreviewMode = iHandle != 0;

            ScreenSaverForm screenSaver = new ScreenSaverForm(iHandle);
            Application.Run(screenSaver);
        }
    }
}
