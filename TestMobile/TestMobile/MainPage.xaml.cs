using ButtonGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestMobile
{
    public partial class MainPage : ContentPage
    {
        private Game Game;

        public MainPage()
        {
            InitializeComponent();

            int size = 5;

            Game = new Game(size, size);
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    var cell = new CellView() { Cell = Game.Cells[x, y] };
                    Grid.SetRow(cell, y);
                    Grid.SetColumn(cell, x);
                    CellGrid.Children.Add(cell);
                }
            }
        }
    }
}
