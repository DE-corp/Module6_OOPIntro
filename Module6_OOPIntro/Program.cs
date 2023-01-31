using System;

namespace Module6_OOPIntro
{
	class User
	{
		private int age;
		private string login;
		private string email;

		public string Login
        {
            get
            {
				return login;
            }

            set
            {
				if (value.Length > 3){
					login = value;
                }
                else
                {
                    Console.WriteLine("Длина логина должна быть не менее 3 символов!");
                }

            }
        }

		public string Email
		{
			get
			{
				return email;
			}

			set
			{
				if (value.Contains("@"))
				{
					email = value;
				}
				else
				{
					Console.WriteLine("Почта должна содержать знак @!");
				}

			}
		}

		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var user = new User();
            Console.Write("Введите ваш возраст: ");
			user.Age = int.Parse(Console.ReadLine());

			Console.Write("Введите ваш логин: ");
			user.Login = Console.ReadLine();

			Console.Write("Введите вашу почту: ");
			user.Email = Console.ReadLine();

            Console.WriteLine($"\nВозраст: {user.Age}\nЛогин: {user.Login}\nПочта: {user.Email}");

			Console.ReadLine();
		}
	}
}
