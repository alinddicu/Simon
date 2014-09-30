namespace Simon.Objects
{
    using System.Linq;
    using Simon.Components;
    using System.Collections.Generic;
    using System.Threading;
    using System.Timers;

    public class Game
    {
        private readonly List<SimonButton> _buttons;
        private int _currentButtonIndex;

        private readonly System.Timers.Timer _aTimer = new System.Timers.Timer(10000);

        public Game(params SimonButton[] buttons)
        {
            _buttons = buttons.ToList();
            _aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            _aTimer.Interval = 500;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            _buttons[_currentButtonIndex++].Blink();
            if (_currentButtonIndex == _buttons.Count())
            {
                _aTimer.Enabled = false;
            }
        }

        public void Blink()
        {
            _aTimer.Enabled = true;
        }
    }
}
