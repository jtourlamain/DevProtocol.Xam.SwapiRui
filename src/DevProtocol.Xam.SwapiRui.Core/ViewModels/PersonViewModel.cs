using System;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reactive;

namespace DevProtocol.Xam.SwapiRui.Core.ViewModels
{
	public class PersonViewModel : ReactiveObject
	{

		public PersonViewModel()
		{
			fullName = this.WhenAnyValue(vm => vm.FirstName,
										 vm => vm.LastName,	
			                             (first, last) => $"{first} {last}")
			               .ToProperty(this, vm => vm.FullName);
		}

		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { this.RaiseAndSetIfChanged(ref firstName, value); }
		}

		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { this.RaiseAndSetIfChanged(ref lastName, value); }
		}

		private readonly ObservableAsPropertyHelper<string> fullName;
		public string FullName
		{
			get { return fullName.Value; }
		}


	}
}
