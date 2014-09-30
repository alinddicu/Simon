namespace Simon.Objects
{
    using System.Linq;
    using Simon.Components;
    using System.Collections.Generic;
    using System.Threading;
    using System.Timers;
    using System.Drawing;

    public class Turn
    {
        private readonly List<SimonButton> _buttons;
        private List<Color> _playColors;
        private int _currentPlayColorIndex;

        private readonly System.Timers.Timer _aTimer = new System.Timers.Timer(10000);

        public Turn(IEnumerable<SimonButton> buttons, params Color[] playColors)
        {
            _buttons = buttons.ToList();
            _playColors = playColors.ToList();
            _aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            _aTimer.Interval = 1500;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (_currentPlayColorIndex < _playColors.Count())
            {
                _buttons.First(b => b.OriginalBackColor == _playColors[_currentPlayColorIndex]).Blink();
                _currentPlayColorIndex++;
            }
            else
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
