using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paster
{
    class Manager
    {
        internal static string getTimeNow()
        {
            string x = System.DateTime.Now.ToShortTimeString() + "    " + DateTime.Now.ToShortDateString();

            try
            {
                x = x.Replace("ص", "am");
                x = x.Replace("م", "pm");
                return x;
            }
            catch {
                return x;
            }
        }

        internal static void RunOnstartup(bool p)
        {
            global::Paster.Properties.Settings.Default.RunOnStartup=p;
            global::Paster.Properties.Settings.Default.Save();
        }

        internal static bool StartupStatue()
        {
            return global::Paster.Properties.Settings.Default.RunOnStartup;
        }
    }
}
