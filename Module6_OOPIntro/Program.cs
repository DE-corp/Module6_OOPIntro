using System;

namespace Module6_OOPIntro
{
	class Rectangle
    {
		public int a;
		public int b;

		public Rectangle()
        {
			a = 6;
			b = 4;
        }

		public Rectangle(int a, int b)
        {
			this.a = a;
			this.b = b;
		}

		public Rectangle(int a)
		{
			this.a = a;
			b = a;
		}

		public double Square() => a * b;

	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine($"Площадь прямоугольника = {rectangle.Square()}");

			Console.ReadLine();
		}
	}
}
