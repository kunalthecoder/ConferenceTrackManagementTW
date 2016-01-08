using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.Conference;

namespace ConfereneceTrackManagementTW.Main.Utilities
{
    public class PrintFormatter : IPrintFormatter
    {
        /// <summary>
        /// Print All the Talks on Console
        /// </summary>
        /// <param name="days"></param>
        public void PrintFormat(IEnumerable<Day> days)
        {
                var tracks = new List<Track>();
               
                foreach (var day in days)
                {
                    int dayCount = 1;
                    
                    tracks = day.Tracks.ToList();
                    foreach (var track in tracks)
                    {
                        Console.WriteLine();
                        Console.WriteLine("             Track " + dayCount + ":");
                        // Morning Session Title
                        Console.WriteLine("**************************************************************************");
                        Console.WriteLine("\n\n" + track.MorningSession.Title);
                        Console.WriteLine("**************************************************************************");
                        var currentTime = track.MorningSession.StartTime;

                        foreach (var talk in track.MorningSession.Talks)
                        {
                            Console.WriteLine(String.Format("{0}\t{1}\t{2}{3}", currentTime, talk.Topic,talk.Duration.Value,talk.Duration.Unit));
                            currentTime =
                                currentTime.Add(new TimeSpan(0, talk.Duration.Value * (int)talk.Duration.Unit, 0));
                        }

                        // Lunch Break
                        Console.WriteLine(String.Format("{0}\t{1}\t{2}", track.LunchBreak.Title, track.LunchBreak.StartTime,track.LunchBreak.EndTime));
                        Console.WriteLine("**************************************************************************");

                        // Evening Session Title
                        Console.WriteLine("**************************************************************************");
                        Console.WriteLine("\n\n" + track.EveningSession.Title);
                        Console.WriteLine("**************************************************************************");
                        currentTime = track.EveningSession.StartTime;

                        foreach (var talk in track.EveningSession.Talks)
                        {
                            Console.WriteLine(string.Format("{0}\t{1}\t{2}{3}", currentTime, talk.Topic,talk.Duration.Value,talk.Duration.Unit));
                            currentTime =
                                currentTime.Add(new TimeSpan(0, talk.Duration.Value * (int)talk.Duration.Unit, 0));
                        }


                        // Check for Networking Event
                        Console.WriteLine(string.Format("{0}\t{1}", track.Networking.Title, track.Networking.StartTime));
                        Console.WriteLine("**************************************************************************");
                        dayCount++;
                    }
                    
                }

        }
    }
}
