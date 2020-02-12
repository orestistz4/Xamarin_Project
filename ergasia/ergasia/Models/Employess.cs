using System;
using System.Collections.Generic;
using System.Text;

namespace ergasia.Models
{
	public class Employess
	{

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public string Speciality { get; set; }
		public string Phone { get; set; }


		public Employess(string name,string surname,string address,string speciality,string phone)
		{
			this.Name = name;
			this.Surname = surname;
			this.Address = address;
			this.Speciality = speciality;
			this.Phone = phone;
		}

	}
}
