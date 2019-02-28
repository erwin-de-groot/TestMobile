using System;
using System.ComponentModel;

namespace ButtonGame
{
    public class Cell: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int X { get; }
        public int Y { get; }
        public bool State { get; private set; } = false;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Press()
        {
            OnPressed?.Invoke(this, EventArgs.Empty);
        }

        internal event EventHandler OnPressed;

        internal void Switch()
        {
            State = !State;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(State)));
        }
    }
}
