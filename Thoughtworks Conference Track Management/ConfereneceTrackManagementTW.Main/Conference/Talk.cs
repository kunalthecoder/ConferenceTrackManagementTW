using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ConfereneceTrackManagementTW.Main.Conference;

namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class Talk
    {
        public string Topic { get; private set; }

        public TalkDuration Duration { get; private set; }

        public Talk(string topic, TalkDuration duration)
        {
            try
            {

                Duration = duration;
                if (IsInValidTitle(topic))
                    throw new ArgumentException("Title Cannot contain Numeric values");
                Topic = topic;
            }
            catch (ArgumentException e)
            {
                throw;
            }

        }

        private bool IsInValidTitle(string title)
        {
            return Regex.IsMatch(title, @"[0-9]+$");
        }
    }
}
