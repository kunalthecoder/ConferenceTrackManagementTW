using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class ConferenceSingleTalkLoader : IConferenceTalksLoader
    {
        private Talk _talk;

        public ConferenceSingleTalkLoader(Talk talk)
        {
            _talk = talk;
        }

        public IEnumerable<Talk> Load()
        {
            return new List<Talk>(){
                _talk
            };
        }
    }
}
