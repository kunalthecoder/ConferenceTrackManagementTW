using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class Day
    {
        public IEnumerable<Track> Tracks { get; private set; }

        public Day(IEnumerable<Track> tracks)
        {
            Tracks = tracks;
        }
    }
}
