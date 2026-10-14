using System;


namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Activity running = new Running(
                new DateTime(2022, 11, 3), 30, 4.8);

            Activity cycling = new Cycling(
                new DateTime(2022, 11, 3), 30, 12);

            Activity swimming = new Swimming(
                new DateTime(2022, 11, 3), 30, 40);

    //storing the three activities  in a list

            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

    
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}