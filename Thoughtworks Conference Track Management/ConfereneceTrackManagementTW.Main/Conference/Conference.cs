using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfereneceTrackManagementTW.Main.ScheduleConfig;
namespace ConfereneceTrackManagementTW.Main.Conference
{
    public class Conference
    {
        public List<Talk> SelectedTalks { get; private set; }
        public IConferenceTalksLoader TalksLoader { get; set; }
        public ITalkScheduler Scheduler { get; private set; }
        public IPrintFormatter ResultFormatter { get; set; }
        public List<Day> Days { get; private set; }

        public int TotalTalks
        {
            get
            {
                return SelectedTalks.Count;
            }
        }

        private int _remainingTime;

        public Conference(ITalkScheduler scheduler, IEnumerable<Day> days)
        {
            Days = new List<Day>();
            SelectedTalks = new List<Talk>();

            Days = days.ToList();
            Scheduler = scheduler;
            CalculateRemainingTime();
        }

        public void Schedule()
        {
            Scheduler.Schedule(Days, SelectedTalks);
        }

        public void GetSchedule()
        {
            ResultFormatter.PrintFormat(Days);
        }

        public void TalksSubmission()
        {
            try
            {
                var newTalks = TalksLoader.Load();

                if (CannotBeRegistered(newTalks))
                    throw new ArgumentException("Time Limit Not Match");
                SelectedTalks.InsertRange(SelectedTalks.Count, newTalks);
            }
            catch (ArgumentException e)
            {
                throw;
            }

        }

        public Talk GetTalkByName(string topic)
        {
            return SelectedTalks.FirstOrDefault(talk => string.Equals(talk.Topic, topic, StringComparison.OrdinalIgnoreCase));
        }

        private bool CannotBeRegistered(IEnumerable<Talk> newTalks)
        {
            var timeTaken = newTalks.Sum(newTalk => newTalk.Duration.Value * (int)newTalk.Duration.Unit);
            if (timeTaken > _remainingTime)
                return true;
            _remainingTime = _remainingTime - timeTaken;
            return false;
        }
        /// <summary>
        /// Time Calculator for the Remaining tracks and events
        /// </summary>
        private void CalculateRemainingTime()
        {
            foreach (var day in Days)
            {
                foreach (var track in day.Tracks)
                {
                    _remainingTime +=
                        (int)track.MorningSession.EndTime.Subtract(track.MorningSession.StartTime).TotalMinutes;
                    _remainingTime +=
                        (int)track.EveningSession.EndTime.Subtract(track.EveningSession.StartTime).TotalMinutes;
                }
            }
        }
    }
}
