using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;



namespace GruppUppgiftLastFMX
{
	[Activity (Label = "GruppUppgiftLastFMX", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		//hallööö
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//hallööö
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			//hallööö
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			//hallööö
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

	
		}
	}
}


