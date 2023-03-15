using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayControl
{
    public static class OnToggleEvent
    {
        static readonly SimpleMacro macro = new SimpleMacro();

        public static void Enable()
        {
            SwitchExtendedToClone();
        }

        public static void Disable()
        {
            SwitchCloneToExtended();
        }

        public static void SwitchExtendedToClone()
        {
            macro.WaitTime = 100;
            macro.ESC().Wait().Run("DisplaySwitch.exe").Wait(500).Enter().Wait().Up().Wait().Enter().Wait().ESC();
        }

        public static void SwitchCloneToExtended()
        {
            macro.WaitTime = 100;
            macro.ESC().Wait().Run("DisplaySwitch.exe").Wait(500).Enter().Wait().Down().Wait().Enter().Wait().ESC();
        }

    }
}
