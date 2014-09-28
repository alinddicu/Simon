namespace Simon.Components
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Timers;
    using System.Windows.Forms;

    public class SimonButton : Button
    {
        // Create a timer with a ten second interval.
        private readonly System.Timers.Timer aTimer = new System.Timers.Timer(10000);

        private readonly Color _originalColor;

        public SimonButton()
        {
            _originalColor = BackColor;
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Set the Interval to 2 seconds (2000 milliseconds).
            aTimer.Interval = 500;
        }

        void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            // Change button color
            BackColor = _originalColor;
            aTimer.Enabled = false;
        }

        public void Blink()
        {
            BackColor = Color.Beige;
            aTimer.Enabled = true;
        }
    }
}
