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
	public partial class EmployeeDetailPage : ContentPage
	{
		//to kanw static gia na mporesw na dw apo allh class xwris na dhmiourghsw new instance ths class auths
		//na dw an einai null h oxi ama einai null shmainei oti exw diagrapsei ton employee auton!
		public static Employess emp;

		

		public EmployeeDetailPage(Employess employee)
		{


			InitializeComponent();
			if (employee == null)
			{
				this.Title = "Employee not found!";
			}
			emp = employee;
			BindingContext = emp; 
			
		}
	}
}