using System;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.App;
using System;

namespace WeatherApp.Droid
{
	[Activity (Label = "Example Weather App", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.weatherBtn);

            button.Click += buttonClick;
        }
			
        private async void buttonClick(object sender, EventArgs e)
        {
            EditText zipCodeEntry = FindViewById<EditText>(Resource.Id.ZipCodeEntry);
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.getWeather(zipCodeEntry.Text);
                FindViewById<TextView>(Resource.Id.locationText).Text = weather.title;
                FindViewById<TextView>(Resource.Id.tempText).Text = weather.temperature;
                FindViewById<TextView>(Resource.Id.windText).Text = weather.wind;
                FindViewById<TextView>(Resource.Id.humidityText).Text = weather.humidity;
                FindViewById<TextView>(Resource.Id.visibilityText).Text = weather.visibility;
                FindViewById<TextView>(Resource.Id.sunriseText).Text = weather.sunrise;
                FindViewById<TextView>(Resource.Id.sunsetText).Text = weather.sunset;
            }
        }	
	}
}


