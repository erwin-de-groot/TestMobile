using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

// The following attribute marks the TestMobile.UWP.ButtonRenderer as the renderer of buttons
// instead of the default Xamarin.Forms.Platform.UWP.ButtonRenderer.
// The renderer is responsible for filling the Control property (platform specific UI element) 
// based on the Element property (Xamarin forms UI element).
// In this case the new renderer inherits from the default renderer, 
// so that most functionality is retained. The newly created Control is only adjusted a bit.
[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(TestMobile.UWP.ButtonRenderer))]
namespace TestMobile.UWP
{
    public class ButtonRenderer : Xamarin.Forms.Platform.UWP.ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Thickness(5.0);
                Control.Style = (Style)Resources["ButtonRevealStyle"];
            }
        }
    }
}
