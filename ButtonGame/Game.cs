using System;

namespace ButtonGame
{
    public class Game
    {
        public int Width { get; }
        public int Height { get; }
        public Cell[,] Cells { get; }

        public Game(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new Cell[width, height];
            Initialize();
        }

        public void Press(int x, int y)
        {
            if (x < 0 || x >= Width)
                throw new ArgumentOutOfRangeException(nameof(x));
            if (y < 0 || y >= Height)
                throw new ArgumentOutOfRangeException(nameof(y));
            Cells[x, y].Switch();
            if (x > 0)
                Cells[x - 1, y].Switch();
            if (y > 0)
                Cells[x, y - 1].Switch();
            if (x < Width - 1)
                Cells[x + 1, y].Switch();
            if (y < Height - 1)
                Cells[x, y + 1].Switch();
        }

        private void Initialize()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Cells[x, y] = new Cell(x, y);
                    Cells[x, y].OnPressed += Cell_OnPressed;
                }
            }
        }

        private void Cell_OnPressed(object sender, EventArgs e)
        {
            var cell = sender as Cell;
            Press(cell.X, cell.Y);
        }
    }
}
