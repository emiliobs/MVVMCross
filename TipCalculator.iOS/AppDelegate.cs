using Foundation;
using MvvmCross.Platforms.Ios.Core;
using TipCalculator.Core;
using UIKit;

namespace TipCalculator.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }

}


