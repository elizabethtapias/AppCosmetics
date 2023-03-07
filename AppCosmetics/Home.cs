using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toolbar = Android.Widget.Toolbar;

namespace AppCosmetics
{
    [Activity(Label = "Home")]
    public class Home : Activity
    {
        Toolbar toolbarmenu;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);
            toolbarmenu = FindViewById<Toolbar>(Resource.Id.toolbarMenu);

            SetActionBar(toolbarmenu);
            ActionBar.Title = "Menu";

        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.services:
                    //Intent i = new Intent(this, typeof(Services));
                    //StartActivity(i);
                    SetContentView(Resource.Layout.Services);
                    break;
                case Resource.Id.Portfolio:
                    //Intent form = new Intent(this, typeof(Portfolio));
                    //StartActivity(form);
                    SetContentView(Resource.Layout.Portfolio);
                    break;
                case Resource.Id.Contact:
                    //Intent encu = new Intent(this, typeof(Contact));
                    //StartActivity(encu);
                    SetContentView(Resource.Layout.Contact);
                    break;
                default:
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}


