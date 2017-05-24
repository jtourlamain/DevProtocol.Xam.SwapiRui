using System;
using DevProtocol.Xam.SwapiRui.iOS.Renderers;
using DevProtocol.Xam.SwapiRui.UI.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SwNavigationPage), typeof(SwNavigationPageRenderer))]
namespace DevProtocol.Xam.SwapiRui.iOS.Renderers
{
	public class SwNavigationPageRenderer : NavigationRenderer
	{
		
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				var att = new UITextAttributes();
				att.TextColor = Color.Yellow.ToUIColor();
				att.Font = UIFont.FromName("Star Jedi Hollow",24);
				UINavigationBar.Appearance.SetTitleTextAttributes(att);
			}
		}
	}
}
