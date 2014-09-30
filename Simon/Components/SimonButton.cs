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

        private bool Equals(SimonButton other)
        {
            return Equals(OriginalBackColor, other.OriginalBackColor);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == this.GetType() && this.Equals((SimonButton)obj);
        }

        public override int GetHashCode()
        {
            return OriginalBackColor.GetHashCode();
        }

        public static bool operator ==(SimonButton left, SimonButton right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SimonButton left, SimonButton right)
        {
            return !Equals(left, right);
        }
    }
}
