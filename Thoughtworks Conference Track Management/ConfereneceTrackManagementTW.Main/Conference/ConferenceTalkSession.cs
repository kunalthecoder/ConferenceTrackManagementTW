using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class ConferenceTalkSession : Slot
    {
        public List<Talk> Talks { get; set; }

        public int _duration;
        public int Duration
        {
            get { return _duration; }
            private set { _duration = (int)EndTime.Subtract(StartTime).TotalMinutes; }
        }

        public TimeSpan TimeRemaining { get; set; }

        public string Title { get; set; }
    }
}
