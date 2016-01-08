using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.Conference;
namespace ConfereneceTrackManagementTW.Main.Utilities
{
    public static class InputFactory
    {
        /// <summary>
        /// First List of Talks which Will be arranged on Day 1
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTalksListOne()
        {
            return new List<string>()
            {
                "Accounting-Driven Development 45min",
                "Woah 30min",
                "Sit Down and Write 30min",
                "Pair Programming vs Noise 45min",
                "Rails Magic 60min",
                "Ruby on Rails: Why We Should Move On 60min",
                "Writing Fast Tests Against Enterprise Rails 60min",
                "Clojure Ate Scala (on my project) 45min",
                "Programming in the Boondocks of Seattle 30min",
                "Ruby vs. Clojure for Back-End Development 30min",
                "Ruby on Rails Legacy App Maintenance 60min",
                "A World Without HackerNews 30min",
                "User Interface CSS in Rails Apps 30min"
            };

        }

        /// <summary>
        /// Second List of Talks which will be arranged on 2nd day.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTalksListTwo()
        {
            return new List<string>()
            {
                "Overdoing it in Python 45min",
                "Lua for the Masses 30min",
                "Ruby Errors from Mismatched Gem Versions 45min",
                "Common Ruby Errors 45min",
                "Rails for Python Developers 30min",
                "Communicating Over Distance 60min"
            };
        }


        /// <summary>
        /// First List of Talks which Will be arranged on Day 1
        /// </summary>
        /// <returns></returns>
        public static List<string> GetMyTalksListOne()
        {
            return new List<string>()
            {
                "Singing for Python Developers 30min",
                "Personality Development 45min",
                "Happy Hours 30min",
                ".NET Errors from Mismatched Gem Versions 45min",
                "For Ruby Champions 45min",
                "Communicating Over Distance 60min",
                "Writing Fast Tests Against Enterprise Rails 60min",
                "Clojure Ate Scala (on my project) 45min",
                "Programming in the Boondocks of Seattle 30min",
                "Ruby on Rails Legacy App Maintenance 60min",
                "A World Without HackerNews 30min",
                "User Interface CSS in Rails Apps 30min",
                "Ruby vs. Clojure for Back-End Development 30min"
            };

        }

        /// <summary>
        /// Second List of Talks which will be arranged on 2nd day.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetMyTalksListTwo()
        {
            return new List<string>()
            {
                "Sit Down and Write 30min",
                "Pair Programming vs Noise 45min",
                "Rails Magic 60min",
                "Ruby on Rails: Why We Should Move On 60min",
                "Overdoing it in Python 45min",
                "Lua for the Masses 30min"
                
            };
        }


        /// <summary>
        /// There will be Multiple Tracks on Day 1.
        /// Morning Evening
        /// </summary>
        /// <returns></returns>
        public static Track GetNewTrack()
        {
            return new Track()
            {
                MorningSession = new ConferenceTalkSession()
                {
                    Title = "Morning Session",
                    StartTime = new TimeSpan(09, 00, 00),
                    EndTime = new TimeSpan(12, 00, 00)
                },
                EveningSession = new ConferenceTalkSession()
                {
                    Title = "Evening Session",
                    StartTime = new TimeSpan(01, 00, 00),
                    EndTime = new TimeSpan(5, 00, 00)
                },
                Networking = new ConferenceNetworkingEvent()
                {
                    Title = "Networking Event",
                    StartTimeFrom = new TimeSpan(04, 00, 00),
                    StartTimeTo = new TimeSpan(05, 00, 00)
                },
                LunchBreak = new ConferenceBreakEvent()
                {
                    Title = "Lunch Break",
                    StartTime = new TimeSpan(12, 00, 00),
                    EndTime = new TimeSpan(1, 00, 00)
                }
            };
        }

    }
}
