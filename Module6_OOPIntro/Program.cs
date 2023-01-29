using System;

namespace Module6_OOPIntro
{
	class Company
	{
		public string Type;
		public string Name;
	}

	class Department
	{
		public Company Company;
		public City City;
	}

	class City
	{
		public string Name;
	}

	class Program
	{
		static void Main(string[] args)
		{
			{
				var department = GetCurrentDepartment();

				department.City.Name = "Санкт-Петербург";
				department.Company.Type = "Банк";

				if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
				{
					Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
				}
			}

			static Department GetCurrentDepartment()
			{
                Department departament = new Department{City = new City(), Company = new Company()};
                
				departament.City.Name = "Санкт-Петербург";
				departament.Company.Type = "Банк";

				//departament.Company.Name = "Банка";

				return departament;
			}

			Console.ReadLine();
		}
	}
}
