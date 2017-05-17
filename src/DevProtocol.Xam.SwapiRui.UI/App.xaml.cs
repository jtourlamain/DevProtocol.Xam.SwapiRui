
using DevProtocol.Xam.SwapiRui.UI.Pages.Old;
using DevProtocol.Xam.SwapiRui.UI.Pages.People;
using Xamarin.Forms;

namespace DevProtocol.Xam.SwapiRui.UI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new OldPage();
			MainPage = new PersonPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
