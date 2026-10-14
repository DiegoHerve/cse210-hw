namespace FitnessTracker
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(DateTime date, int minutes, double speed)
            : base(date, minutes)
        {
            _speed = speed;
        }

        public override string GetActivityType()
        {
            return "Cycling";
        }

        public override double GetDistance()
        {
            return (_speed / 60) * GetMinutes();
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistance();
        }
    }
}
