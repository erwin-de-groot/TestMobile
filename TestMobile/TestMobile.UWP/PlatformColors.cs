using Xamarin.Forms;

// The following attribute registers the PlatformColors class as the implementation
// of the IColors interface for this platform
[assembly: Dependency(typeof(TestMobile.UWP.PlatformColors))]
namespace TestMobile.UWP
{
    public class PlatformColors : IColors
    {
        public Color FalseStateColor => Color.LightGoldenrodYellow;
        public Color TrueStateColor => Color.DarkGoldenrod;
    }
}