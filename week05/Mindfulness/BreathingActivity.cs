using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(breatheIn ? "Breathe in..." : "Breathe out...");

            int remaining = Math.Min(5, Math.Max(0, (int)(endTime - DateTime.Now).TotalSeconds));
            if (remaining > 0)
            {
                ShowCountdown(remaining);
            }

            breatheIn = !breatheIn;
        }

        EndActivity();
    }
}
