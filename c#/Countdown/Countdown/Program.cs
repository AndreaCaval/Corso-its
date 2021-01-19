using System;
using System.Timers;

public class Example
{
    private static Timer aTimer;

    public static void Main()
    {

        Console.WriteLine("Enter countdown");
        int countdown = int.Parse(Console.ReadLine());

        for (int i = countdown; 0 < i; i--)
        {
            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
            
        }
        Console.WriteLine("Press the Enter key to exit the program at any time... ");
        Console.ReadLine();
    }

    private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("ciao");
    }
}