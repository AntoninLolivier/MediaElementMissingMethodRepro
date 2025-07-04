using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MediaElementMissingMethodRepro;

[Activity(Theme = "@style/Maui.SplashTheme", ResizeableActivity = true, MainLauncher = true, LaunchMode = LaunchMode.SingleTask)]
public class MainActivity : MauiAppCompatActivity
{
}