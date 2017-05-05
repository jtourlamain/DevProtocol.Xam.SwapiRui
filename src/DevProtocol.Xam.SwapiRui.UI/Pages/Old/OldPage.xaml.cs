using System;
using System.Collections.Generic;
using DevProtocol.Xam.SwapiRui.Core.ViewModels;
using Xamarin.Forms;

namespace DevProtocol.Xam.SwapiRui.UI.Pages.Old
{
	public partial class OldPage : ContentPage
	{
		public OldPage()
		{
			InitializeComponent();
			BindingContext = new OldViewModel();
		}
	}
}
