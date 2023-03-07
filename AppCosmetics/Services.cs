using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCosmetics
{
    [Activity(Label = "Services")]
    public class Services : Activity
    {
        EditText txtConsulting;
        EditText txtCapillary;
        EditText txtEasy;
        EditText txtProducts;
        Button btnHome;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Services);
            txtConsulting = FindViewById<EditText>(Resource.Id.txt);
            txtCapillary = FindViewById<EditText>(Resource.Id.txtPassword);
            txtEasy = FindViewById<EditText>(Resource.Id.);
            txtProducts = FindViewById<EditText>(Resource.Id.);
            btnHome = FindViewById<Button>(Resource.Id.txt);
            

            // Create your application here
        }
    }
}