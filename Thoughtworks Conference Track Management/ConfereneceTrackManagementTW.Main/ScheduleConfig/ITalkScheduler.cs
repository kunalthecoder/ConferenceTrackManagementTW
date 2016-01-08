using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.Conference;
namespace ConfereneceTrackManagementTW.Main.ScheduleConfig
{
    public interface ITalkScheduler
    {
        void Schedule(IEnumerable<Day> days, IEnumerable<Talk> talks);
    }
}
