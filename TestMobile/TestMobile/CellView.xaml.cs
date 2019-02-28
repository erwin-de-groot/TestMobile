using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ButtonGame;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CellView : ContentView
	{
        public static readonly BindableProperty CellProperty =
            BindableProperty.Create(nameof(Cell), typeof(ButtonGame.Cell), typeof(CellView));

        public ButtonGame.Cell Cell
        {
            get { return GetValue(CellProperty) as ButtonGame.Cell; }
            set { SetValue(CellProperty, value); }
        }

        public CellView ()
		{
			InitializeComponent ();
            BindingContext = this;
		}

        private void CellButton_Pressed(object sender, EventArgs e)
        {
            Cell?.Press();
        }
    }
}