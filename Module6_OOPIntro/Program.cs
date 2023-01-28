﻿using System;

namespace Module6_OOPIntro
{
	class Human
	{
		// Поля класса
		public string name;
		public int age;

		// Метод класса
		public void Greetings()
		{
			Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
		}

		// Конструктор 1
		public Human()
		{
			name = "Неизвестно";
			age = 20;
		}
		// Конструктор 2
		public Human(string n)
		{
			name = n;
			age = 20;
		}
		// Конструктор 3
		public Human(string n, int a)
		{
			name = n;
			age = a;
		}
	}

	struct Animal
	{
		// Поля структуры
		public string type;
		public string name;
		public int age;

		// Метод структуры
		public void Info()
		{
			Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Human human = new Human { name = "Дмитрий", age = 23 };
			human.Greetings();

			Console.ReadLine();
		}
	}
}
