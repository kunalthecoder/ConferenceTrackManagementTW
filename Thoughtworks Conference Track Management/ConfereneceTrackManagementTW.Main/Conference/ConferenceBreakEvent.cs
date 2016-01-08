using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class ConferenceBreakEvent : Slot
    {
        public TimeSpan StartTimeFrom { get; set; }

        public TimeSpan StartTimeTo { get; set; }
    }
}
