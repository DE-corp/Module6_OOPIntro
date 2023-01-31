using System;

namespace Module6_OOPIntro
{
	class TrafficLight
    {
		private string Color;

		public TrafficLight(string Color)
        {
			this.Color = Color;
        }

		private void ChangeColor(string color)
        {

        }

		public string GetColor()
        {
			return Color;
        }
	}

	class Program
	{
		static void Main(string[] args)
		{
			var Trafficlight = new TrafficLight("Red");
            Console.WriteLine(Trafficlight.GetColor());
            

			Console.ReadLine();
		}
	}
}
