using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.Conference;
using ConfereneceTrackManagementTW.Main.Utilities;
using ConfereneceTrackManagementTW.Main.ScheduleConfig;
namespace ConferenceTrackManagementTW
{
    class Program
    {
        static void Main(string[] args)
        {
            Conference _technicalConference;
            TalkDuration _duration;
            ITalkScheduler _scheduler;
            List<Track> _tracks;
            List<Day> _days;

            // TEST THOUGHTWORKS TEST INPUTS
            _duration = new TalkDuration(ConferenceTalkTimeUnit.Min, 60); // Initialize  Talk Duration
            _scheduler = new Scheduler(); 

            _days = new List<Day>();

            // Initialization of Two days Track from the
            _tracks = new List<Track>();
            for (var i = 0; i < 2; i++)
            {
                _tracks.Add(InputFactory.GetNewTrack());
            }

            _days.Add(new Day(_tracks));
            _technicalConference = new Conference(_scheduler, _days);

            _technicalConference.TalksLoader = new ConferenceTalkLoader(InputFactory.GetTalksListOne());
            _technicalConference.TalksSubmission();

            _technicalConference.TalksLoader = new ConferenceTalkLoader(InputFactory.GetTalksListTwo());
            _technicalConference.TalksSubmission();

            _technicalConference.Schedule();

            Console.WriteLine("*******************Conference Tracking Management System******************");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("*********************TEST INPUTS GIVEN BY THOUGHTWORKS********************");
            Console.WriteLine("**************************************************************************");

            PrintFormatter t = new PrintFormatter();
            t.PrintFormat(_days);
            
            /// TEST MY OWN CONFERENCE TRACK INPUTS
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*********************TEST INPUTS GIVEN BY ME******************************");
            Console.WriteLine("**************************************************************************");

            // TEST THOUGHTWORKS TEST INPUTS
            _duration = new TalkDuration(ConferenceTalkTimeUnit.Min, 60); // Initialize  Talk Duration
            _scheduler = new Scheduler();

            _days = new List<Day>();

            // Initialization of Two days Track from the
            _tracks = new List<Track>();
            for (var i = 0; i < 2; i++)
            {
                _tracks.Add(InputFactory.GetNewTrack());
            }

            _days.Add(new Day(_tracks));
            _technicalConference = new Conference(_scheduler, _days);

            _technicalConference.TalksLoader = new ConferenceTalkLoader(InputFactory.GetMyTalksListOne());
            _technicalConference.TalksSubmission();

            _technicalConference.TalksLoader = new ConferenceTalkLoader(InputFactory.GetMyTalksListTwo());
            _technicalConference.TalksSubmission();

            _technicalConference.Schedule();
            t.PrintFormat(_days);
            Console.ReadLine();
        }
    }
}
