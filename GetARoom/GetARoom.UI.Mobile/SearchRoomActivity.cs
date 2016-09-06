using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GetARoom.UI.Mobile
{
    [Activity(Label = "SearchRoomActivity",Theme = "@style/MyTheme")]
    public class SearchRoomActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SearchHotel);
            
        }
    }
}