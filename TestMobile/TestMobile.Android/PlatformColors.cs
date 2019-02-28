using Xamarin.Forms;

// The following attribute registers the PlatformColors class as the implementation
// of the IColors interface for this platform
[assembly: Dependency(typeof(TestMobile.Droid.PlatformColors))]
namespace TestMobile.Droid
{
    public class PlatformColors : IColors
    {
        public Color FalseStateColor => Color.LightGreen;
        public Color TrueStateColor => Color.DarkGreen;
    }
}