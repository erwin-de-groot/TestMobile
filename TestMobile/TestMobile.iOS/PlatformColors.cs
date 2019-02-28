using Xamarin.Forms;

// The following attribute registers the PlatformColors class as the implementation
// of the IColors interface for this platform
[assembly: Dependency(typeof(TestMobile.iOS.PlatformColors))]
namespace TestMobile.iOS
{
    public class PlatformColors : IColors
    {
        public Color FalseStateColor => Color.LightBlue;
        public Color TrueStateColor => Color.DarkBlue;
    }
}