using System;
using Android.Graphics;
using Android.Support.V7.App;
using DevProtocol.Xam.SwapiRui.Droid.Renderers;
using DevProtocol.Xam.SwapiRui.UI.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(SwNavigationPage), typeof(SwNavigationPageRenderer))]
namespace DevProtocol.Xam.SwapiRui.Droid.Renderers
{
	public class SwNavigationPageRenderer: NavigationPageRenderer 
	{
		private Android.Support.V7.Widget.Toolbar toolbar;

			//protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<NavigationPage> e)
			//{
			//	base.OnElementChanged(e);
			//	if (e.NewElement != null)
			//	{
			//		var v = "";
				
			//	}
			//	if (e.OldElement != null)
			//	{
			//		if (toolbar != null)
			//		{
			//			toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
			//		}
			//	}
			//}

		public override void OnViewAdded(Android.Views.View child)
		{
			base.OnViewAdded(child);
			if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
			{
				toolbar = (Android.Support.V7.Widget.Toolbar)child;
				toolbar.ChildViewAdded += Toolbar_ChildViewAdded;
			}
		}

		void Toolbar_ChildViewAdded(object sender, ChildViewAddedEventArgs e)
		{
			var view = e.Child.GetType();
			if (e.Child.GetType() == typeof(Android.Support.V7.Widget.AppCompatTextView))
			{
				var textView = (Android.Support.V7.Widget.AppCompatTextView)e.Child;
				var swFont = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "Starjhol.ttf");
				textView.Typeface = swFont;
				toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
			}
		}
	}
}
