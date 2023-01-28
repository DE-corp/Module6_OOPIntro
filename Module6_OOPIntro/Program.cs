using System;

namespace Module6_OOPIntro
{
	class Pen
	{
		public string color;
		public int cost;

		public Pen()
        {
			color = "Черный";
			cost = 100;
        }

		public Pen(string penColor, int penCost)
        {
			color = penColor;
			cost = penCost;
        }
	}

	class Program
	{
		static void Main(string[] args)
		{
			Pen pen1 = new Pen();
            Console.WriteLine($"Конструктор без параметров: {pen1.color}, {pen1.cost}");

			Pen pen2 = new Pen("Белый", 50);
			Console.WriteLine($"Конструктор с параметрами: {pen2.color}, {pen2.cost}");

			Console.ReadLine();
		}
	}
}
