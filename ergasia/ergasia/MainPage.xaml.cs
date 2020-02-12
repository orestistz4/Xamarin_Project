using ergasia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ergasia
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]

	

	public partial class MainPage : MasterDetailPage
	{
		
		protected override void OnAppearing()
		{
			base.OnAppearing();
			listview.ItemsSource = null;
			listview.ItemsSource = App.emps;
			
		}

		public   void update() {

			
			

		}


		
		public MainPage()
		{
			InitializeComponent();

			
			

			listview.ItemsSource = App.emps;
			//fortwse ena detailpage me null timh tou object
			Detail = new NavigationPage(new EmployeeDetailPage(null));
		}
		

		  private void Edit_Clicked(object sender, EventArgs e)
		{

			var menuItem = sender as MenuItem;
			var emp = menuItem.CommandParameter as Employess;

			
			Detail = new NavigationPage(new EditPage(emp));
			IsPresented = false;

		}

		private void Delete_Clicked(object sender, EventArgs e)
		{

			var menuItem = sender as MenuItem;
			var emp = menuItem.CommandParameter as Employess;
			App.emps.Remove(emp);
			//update detailpage after remove of an item
			if (emp == EmployeeDetailPage.emp)
			{
				Detail = new NavigationPage(new EmployeeDetailPage(null));
			}
			

		}

		private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
		{

			var employee = e.Item as Employess;
			Detail = new NavigationPage(new EmployeeDetailPage(employee));
			
			
			//IsPresented ennoei gia to masterpage
			IsPresented = false;

		}

		private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			listview.SelectedItem = null;
		}

		 private void Add_Clicked(object sender, EventArgs e)
		{

			Detail = new NavigationPage(new AddEmployee());
			IsPresented = false;
			


		}
	}
}
