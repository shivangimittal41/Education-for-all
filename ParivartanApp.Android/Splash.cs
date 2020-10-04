using System;
using Android.App;
using Android.OS;
using static Android.Content.Res.Resources;

namespace ParivartanApp.Droid
{
    [Activity(Label = "Splash",
        Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class Splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(1000);
            StartActivity(typeof(MainActivity));
        }
    }
}


