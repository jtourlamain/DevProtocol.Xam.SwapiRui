using System;
using Xamarin.Forms;

namespace DevProtocol.Xam.SwapiRui.UI.Controls
{
	public class SwNavigationPage: NavigationPage
	{
		public SwNavigationPage(Page root):base(root)
		{
			BarBackgroundColor = Color.Black;
			BarTextColor = Color.Yellow;
		}
	}
}
