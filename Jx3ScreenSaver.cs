using System;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class DotNETScreenSaver
	{
		[STAThread]
		static void Main(string[] args) 
		{
			if (args.Length > 0)
			{
				if (args[0].ToLower().Trim().Substring(0,2) == "/c")
				{
					MessageBox.Show("你获得[茗伊@梦江南] x 1。", "考试过了吗?情缘有了吗?橙武做了吗?都没有瞎点啥?", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (args[0].ToLower() == "/s")
				{
					for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++) 
						System.Windows.Forms.Application.Run(new ScreenSaverForm(i));				
				}
			}
			else
			{
				for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++) 
					System.Windows.Forms.Application.Run(new ScreenSaverForm(i));				
			}
		}
	}
}
