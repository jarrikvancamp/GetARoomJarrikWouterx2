using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GetARoom.UI.Mobile
{
    [Activity(Label = "GetARoom.UI.Mobile", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
<<<<<<< HEAD
          
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
=======

            // init buttons
            Button btnMainSearchARoom = FindViewById<Button>(Resource.Id.btnMainSearchARoom);
            Button btnMyRooms = FindViewById<Button>(Resource.Id.btnMyRooms);
            Button btnMainSettings = FindViewById<Button>(Resource.Id.btnMainSettings);
>>>>>>> 99779effaa2a2d031e5dee04b0f3a6162b478980
        }
    }
}

