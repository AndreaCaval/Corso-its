using System;

namespace Timer
{
    class Program
    {

        static System.Timers.Timer aTimer;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter interval");
            try
            {
                int interval = Convert.ToInt32(Console.ReadLine());
                SetTimer(interval);
            }
            catch
            {
                SetTimer();
            }

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss:fff}", DateTime.Now);
            Console.ReadLine();

            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }

        static void SetTimer()
        {
            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        static void SetTimer(int interval)
        {
            aTimer = new System.Timers.Timer(interval);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss:fff}", e.SignalTime);
        }
    }
}
