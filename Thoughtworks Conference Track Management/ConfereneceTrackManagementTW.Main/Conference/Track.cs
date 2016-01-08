using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.Conference;
namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class Track
    {
        public string Title { get; private set; }

        public ConferenceTalkSession MorningSession { get; set; }

        public ConferenceBreakEvent LunchBreak { get; set; }

        public ConferenceTalkSession EveningSession { get; set; }

        public ConferenceNetworkingEvent Networking { get; set; }
    }
}
