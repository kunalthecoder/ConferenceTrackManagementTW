using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public interface IConferenceTalksLoader
    {
        IEnumerable<Talk> Load();
    }
    
}
