using System;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reactive;
using System.Collections.Generic;
using DevProtocol.Xam.SwapiRui.Core.Domain;
using System.Net.Http;
using Newtonsoft.Json;
using DevProtocol.Xam.SwapiRui.Core.Helpers;
using System.Threading.Tasks;

namespace DevProtocol.Xam.SwapiRui.Core.ViewModels
{
	public class PersonViewModel : ReactiveObject
	{

		public PersonViewModel()
		{
			fullName = this.WhenAnyValue(vm => vm.FirstName,
										 vm => vm.LastName,
										 (first, last) => $"{first} {last}")
						   .ToProperty(this, vm => vm.FullName, out fullName);
			SaveCommand = ReactiveCommand.CreateFromTask(async () =>
			{
				await Task.Delay(2000);
				return DateTime.UtcNow;
			});
			result = SaveCommand.Select(x => "Saved on " + x.ToString()).ToProperty(this, vm => vm.Result);
		}

		public ReactiveCommand<Unit, DateTime> SaveCommand { get; private set; }

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

		private readonly ObservableAsPropertyHelper<string> result;
		public string Result
		{
			get { return result.Value; }

		}




		}
	}
