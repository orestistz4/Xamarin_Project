using ergasia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ergasia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddEmployee : ContentPage
	{
		public AddEmployee()
		{
			InitializeComponent();
		}

		private void Add_Clicked(object sender, EventArgs e)
		{
			//validate values
			if (validateValues())
			{
				//vale to new obbject sthn lista!
				Employess emp = new Employess(firstName.Text,lastName.Text,address.Text,speciality.Text,phoneNumber.Text);
				App.emps.Add(emp);
				App.Current.MainPage = new MainPage { Detail = new NavigationPage(new EmployeeDetailPage(emp)), IsPresented = false };

			}
		}

		private bool validateValues()
		{
			if (string.IsNullOrWhiteSpace((firstName).Text) || string.IsNullOrWhiteSpace((lastName).Text))
			{
				DisplayAlert("Error", "Please put a valid name and a surname", "OK");
				return false;
			}

			else if (!checkPhone(phoneNumber.Text))
			{
				DisplayAlert("Error", "Please put a valid phone number!!", "OK");
				return false;
			}
			else
			{


				return true;
				//await Navigation.PushAsync(new EmployeeDetailPage(emp1));
				//App.Current.MainPage = new MainPage { Detail = new NavigationPage(new EmployeeDetailPage(emp1)), IsPresented = false };
			}
		}
		private bool checkPhone(string phone)
		{


			if (phone.Length < 10)
			{
				return false;
			}
			else if (!Int64.TryParse(phone, out Int64 x))
			{
				return false;
			}
			return true;

		}
	}
}