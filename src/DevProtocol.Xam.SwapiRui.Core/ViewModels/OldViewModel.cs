using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace DevProtocol.Xam.SwapiRui.Core.ViewModels
{
	public class OldViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		private string firstName = "";
		public string FirstName
		{
			get { return firstName; }
			set
			{
				if (EqualityComparer<string>.Default.Equals(firstName, value))
					return;
				firstName = value;
				OnPropertyChanged();
			}
		}

		private string lastName = "";
		public string LastName
		{
			get { return lastName; }
			set
			{
				if (EqualityComparer<string>.Default.Equals(lastName, value))
					return;
				lastName = value;
				OnPropertyChanged();
			}
		}

		private string result = "";
		public string Result
		{
			get { return result; }
			set
			{
				if (EqualityComparer<string>.Default.Equals(result, value))
					return;
				result = value;
				OnPropertyChanged();
			}
		}

		private ICommand saveCommand;
		public ICommand SaveCommand
		{
			get { return saveCommand ?? (saveCommand = new Command(() => ExecuteSaveCommand())); }
		}

		private void ExecuteSaveCommand()
		{
			Result = $"Saved {FirstName} {LastName}";
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}


	}
}
