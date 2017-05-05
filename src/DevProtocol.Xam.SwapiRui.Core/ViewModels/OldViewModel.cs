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

		public OldViewModel()
		{
		}

		private string userName = "";
		public string UserName
		{
			get { return userName; }
			set
			{
				if (EqualityComparer<string>.Default.Equals(userName, value))
					return;
				userName = value;
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

		private ICommand goCommand;



		public ICommand GoCommand
		{
			get { return goCommand ?? (goCommand = new Command(() => ExecuteGoCommand())); }
		}

		private void ExecuteGoCommand()
		{
			Result = UserName;
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}


	}
}
