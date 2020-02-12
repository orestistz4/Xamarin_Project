using ergasia.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ergasia
{
	public partial class App : Application
	{
		public static ObservableCollection<Employess> emps;
		public App()
		{
			InitializeComponent();
			//kanei observe otidhpote change ginetai sth lista
			//ama diagraftei dhladh ena item apo thn lista ginetai kateu8eian update
			emps = new ObservableCollection<Employess>
			{
				new Employess("Orestis","Tzourmpakis","Dioxarous 10","Software Engineer","6934451926"),
				new Employess("Giorgos","Akalidis","Alkaiou 30","Animator","6936729401"),
				new Employess("Nefeli","Tzourmpaki","Dioxarous 10","Doctor","6939593012"),
				new Employess("Marios","Kontolewn","Brasida 10","Banker","6909284910"),
				new Employess("John","Aliferis","Varh 5","Web Development","6959603910"),
				new Employess("George","Gaitanis","Menid 15","Delivery","6962012691")
				

			};
			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}

		
	}
}
