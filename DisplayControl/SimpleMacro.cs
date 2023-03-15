using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayControl
{
    public class SimpleMacro
    {
        public int WaitTime { get; set; }

        public SimpleMacro()
        {
            WaitTime = 100;
        }

        public SimpleMacro SendWait(string key)
        {
            SendKeys.SendWait(key);
            return this;
        }

        public SimpleMacro ESC() => SendWait("{ESC}");
        public SimpleMacro Enter() => SendWait("{ENTER}");
        public SimpleMacro Up() => SendWait("{UP}");
        public SimpleMacro Down() => SendWait("{DOWN}");
        public SimpleMacro Left() => SendWait("{LEFT}");
        public SimpleMacro Right() => SendWait("{RIGHT}");

        public SimpleMacro Run(string cmd)
        {
            Process.Start(cmd);
            return this;
        }

        public SimpleMacro Wait() => Wait(WaitTime);
        public SimpleMacro Wait(int millisecondTimeout)
        {
            Thread.Sleep(millisecondTimeout);
            return this;
        }
    }
}
