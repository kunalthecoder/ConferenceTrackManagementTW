using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public interface IPrintFormatter
    {
        void PrintFormat(IEnumerable<Day> days);
    }
}
