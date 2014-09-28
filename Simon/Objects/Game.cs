namespace Simon.Objects
{
    using Simon.Components;
    using System.Collections.Generic;
    using System.Threading;

    public class Game
    {
        private readonly IEnumerable<SimonButton> _buttons;

        public Game(params SimonButton[] buttons)
        {
            _buttons = buttons;
        }

        public void Blink() 
        {
            foreach (var button in _buttons)
            {
                button.Blink();
            }
        }
    }
}
