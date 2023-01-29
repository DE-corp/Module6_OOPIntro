using System;

namespace Module6_OOPIntro
{
	class Bus
	{
		public int? Load;

		public void PrintStatus()
		{
			if (Load.HasValue)
			{
				Console.WriteLine($"В автобусе {Load.Value} пассажиров");
			}
			else
			{
				Console.WriteLine("Автобус пуст!");
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
            var Bus = new Bus { Load = 20 };
            //var Bus = new Bus();

			Bus.PrintStatus();

			Console.ReadLine();
		}
	}
}
