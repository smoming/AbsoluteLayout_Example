using Xamarin.Forms;

using System;
using System.Collections.Generic;

namespace Layout_Absolute
{
	public partial class Layout_AbsolutePage : ContentPage
	{

		//int sleepSeconds = 0;
		//int waitSecond = 5;
		public Layout_AbsolutePage()
		{
			InitializeComponent();

			//Device.StartTimer(TimeSpan.FromSeconds(1), () =>
			//{
			//	sleepSeconds++;
			//	if (sleepSeconds >= waitSecond)
			//	{
			//		xBoxView.IsVisible = false;
			//		xActivityIndicator.IsRunning = false;
			//	}

			//	return sleepSeconds < waitSecond;
			//});
		}
	}
}
