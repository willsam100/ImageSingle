using Android.App;
using Android.Widget;
using Android.OS;

namespace ImageSingle.DroidCSharp
{
    [Activity(Label = "ImageSingle.DroidCSharp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            this.LoadApplication(new ImageSingle.App());
        }
    }
}

