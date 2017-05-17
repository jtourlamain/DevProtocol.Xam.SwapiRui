using System;
using System.Collections.Generic;
using DevProtocol.Xam.SwapiRui.Core.ViewModels;
using Xamarin.Forms;

namespace DevProtocol.Xam.SwapiRui.UI.Pages.People
{
    public partial class PersonPage : ContentPage
    {
        public PersonPage()
        {
            InitializeComponent();
			this.BindingContext = new PersonViewModel();
        }
    }
}
