using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

// The following attribute marks the TestMobile.iOS.ButtonRenderer as the renderer of buttons
// instead of the default Xamarin.Forms.Platform.iOS.ButtonRenderer.
// The renderer is responsible for filling the Control property (platform specific UI element) 
// based on the Element property (Xamarin forms UI element).
// In this case the new renderer inherits from the default renderer, 
// so that most functionality is retained. The newly created Control is only adjusted a bit.
[assembly: ExportRenderer(typeof(Button), typeof(TestMobile.iOS.ButtonRenderer))]
namespace TestMobile.iOS
{
    public class ButtonRenderer : Xamarin.Forms.Platform.iOS.ButtonRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Layer.CornerRadius = 30f;
            }
        }
    }
}