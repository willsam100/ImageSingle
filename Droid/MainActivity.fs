namespace ImageSingle.Droid
open System;

open Android.App;
open Android.Content;
open Android.Content.PM;
open Android.Runtime;
open Android.Views;
open Android.Widget;
open Android.OS;

[<Activity (Label = "ImageSingle.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type MainActivity() =
    inherit Xamarin.Forms.Platform.Android.FormsApplicationActivity()
    override this.OnCreate (bundle: Bundle) =
        base.OnCreate (bundle)

        Console.WriteLine("activity is starting")

        Xamarin.Forms.Forms.Init (this, bundle)
        this.LoadApplication (new ImageSingle.App ())

