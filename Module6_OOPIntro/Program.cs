using System;

namespace Module6_OOPIntro
{
	class Triangle
    {
		public int a;
		public int b;
		public int c;

		public double GetSquare()
        {
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public double GetPerimeter()
		{
			return a + b + c;
		}

	}

	class Circle
	{
		public int radius;
		public double GetSquare()
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		public double GetPerimeter()
		{
			return 2 * Math.PI * radius;
		}
	}

	class Square
	{
		public int side;

		public double GetSquare()
		{
			return Math.Pow(side, 2);
		}

		public double GetPerimeter()
		{
			return side * 4;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var square = new Square { side = 5 };
            Console.WriteLine(square.GetPerimeter());
			Console.WriteLine(square.GetSquare());

			Console.ReadLine();
		}
	}
}
