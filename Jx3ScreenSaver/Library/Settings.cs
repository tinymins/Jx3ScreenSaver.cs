using Microsoft.Win32;

namespace Jx3ScreenSaver
{
    public class Settings
    {
        // Set setting value by key and value
        private static void Set(string key, string value)
        {
            Registry.CurrentUser.CreateSubKey("SOFTWARE\\TmsJx3ScreenSaver").SetValue(key, value);
        }

        // Get setting value by key and default value
        private static string Get(string key, string defaultVal)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\TmsJx3ScreenSaver");
            if (rk == null)
                return defaultVal;
            else
                return (string)rk.GetValue(key);
        }

        // Setting values
        public static int    ClosingTime       { get { return    int.Parse(Get("ClosingTime"      , "10000")); } set { Set("ClosingTime"      , value.ToString()); } }
        public static int    CreateInterval    { get { return    int.Parse(Get("CreateInterval"   , "300"  )); } set { Set("CreateInterval"   , value.ToString()); } }
        public static double BackgroundOpacity { get { return double.Parse(Get("BackgroundOpacity", "0"    )); } set { Set("BackgroundOpacity", value.ToString()); } }
        public static double ForegroundOpacity { get { return double.Parse(Get("ForegroundOpacity", "1"    )); } set { Set("ForegroundOpacity", value.ToString()); } }
        public static int    MaxInstanceCount  { get { return    int.Parse(Get("MaxInstanceCount" , "50"   )); } set { Set("MaxInstanceCount" , value.ToString()); } }
    }
}