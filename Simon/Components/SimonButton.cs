namespace Simon.Components
{
    using System.Drawing;
    using System.Threading;
    using System.Timers;
    using System.Windows.Forms;

    public class SimonButton : Button
    {
        private readonly System.Timers.Timer aTimer = new System.Timers.Timer(10000);

        public SimonButton()
        {
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.Interval = 500;
        }

        public Color OriginalBackColor { get; set; }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            BackColor = OriginalBackColor;
            aTimer.Enabled = false;
        }

        public void Blink()
        {
            BackColor = Color.Plum;
            aTimer.Enabled = true;
        }
    }
}
