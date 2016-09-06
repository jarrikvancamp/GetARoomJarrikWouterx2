using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GetARoom.UI.Mobile
{
    [Activity(Label = "GetARoom.UI.Mobile", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // init buttons
            Button btnMainSearchARoom = FindViewById<Button>(Resource.Id.btnMainSearchARoom);
            Button btnMyRooms = FindViewById<Button>(Resource.Id.btnMyRooms);
            Button btnMainSettings = FindViewById<Button>(Resource.Id.btnMainSettings);
        }
    }
}

