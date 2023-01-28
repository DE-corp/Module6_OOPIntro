using System;

namespace Module6_OOPIntro
{
	class ExternalClass
	{
		public class ClassInternalClass
		{
		}

		struct ClassInternalStruct
		{
		}
	}

	class ExternalStruct
	{
		class StructInternalClass
		{
		}

		public struct StructInternalStruct
		{
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			ExternalClass.ClassInternalClass newClass;
			ExternalStruct.StructInternalStruct newStruct;

			Console.ReadLine();
        }
    }
}
