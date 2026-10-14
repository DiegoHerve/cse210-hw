using System;

namespace FitnessTracker
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public int GetMinutes()
        {
            return _minutes;
        }

        public abstract string GetActivityType();
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")}"+
                   $"{GetActivityType()} ({_minutes} min): " +
                   $"Distance: {GetDistance():F1} km, " +
                   $"Speed: {GetSpeed():F1} kph, " +
                   $"Pace: {GetPace():F2} min per km";
        }
    }
}
