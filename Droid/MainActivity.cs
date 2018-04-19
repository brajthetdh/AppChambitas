﻿
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace AppChambitasV1.Droid
{
    [Activity(Label = "AppChambitasV1.Droid", 
              Icon = "@drawable/ic_launcher", 
              Theme = "@style/MyTheme", 
              MainLauncher = false, 
              ConfigurationChanges = 
              ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}
