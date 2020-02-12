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
	public partial class EditPage : ContentPage
	{

		public Employess emp1;
		public Employess emp2;

		public EditPage(Employess emp)
		{
			emp1 = emp;
			//make a reference to the object
			emp2 = referenceObject(emp);
			//add the object as bindingcontext
			BindingContext =emp2 ;
			InitializeComponent();
			
		}

		async private void Button_Clicked(object sender, EventArgs e)
		{
			//validate values
			
			if (string.IsNullOrWhiteSpace((firstName).Text) || string.IsNullOrWhiteSpace((lastName).Text))
			{
				DisplayAlert("Error", "Please put a valid name and a surname", "OK");
			}

			else if (!checkPhone(phoneNumber.Text))
			{
				DisplayAlert("Error", "Please put a valid phone number!!", "OK");
			}
			else
			{
				updateObject();
				
				App.Current.MainPage = new MainPage { Detail = new NavigationPage(new EmployeeDetailPage(emp1)), IsPresented = false };
			}
			
			
			
			
			
		}
		//validate phone entry
		private bool checkPhone(string phone) {

			
			if (phone.Length < 10)
			{
				return false;
			}
			else if(!Int64.TryParse(phone,out Int64 x))
			{
				return false;
			}
			return true;
		
		}

		private void Entry_Completed(object sender, EventArgs e)
		{

			

		}
		private Employess referenceObject(Employess empl)
		{
			Employess employee = new Employess(empl.Name,empl.Surname,empl.Address,empl.Speciality,empl.Phone);
			return employee;
		}

		//pass the values of the reference object
		//to our employee object
		private void updateObject()
		{
			emp1.Name = emp2.Name;
			emp1.Surname = emp2.Surname;
			emp1.Address = emp2.Address;
			emp1.Speciality = emp2.Speciality;
			emp1.Phone = emp2.Phone;

		}
		
	}
}