using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.Utilities;
namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class TalkDuration
    {
        public int Value { get; private set; }

        public ConferenceTalkTimeUnit Unit { get; private set; }

        public TalkDuration(ConferenceTalkTimeUnit unit, int duration)
        {
            try
            {
                if (IsInvalidDuration(duration))
                    throw new ArgumentException("Invalid Time Value");
                Value = duration;
                Unit = unit;
            }
            catch (ArgumentException e)
            {
                throw;
            }

        }

        private bool IsInvalidDuration(int duration)
        {
            return duration < 0;

        }
    }
}
