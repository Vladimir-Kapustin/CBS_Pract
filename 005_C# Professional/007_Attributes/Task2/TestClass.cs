using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class TestClass
	{
		[Obsolete("Try to use new version instead!")]
		public void OldMethod()
		{
			Console.WriteLine("This is an Old Method!");
		}

		public void NewMethod()
		{
			Console.WriteLine("This is a New Method!");
		}

		[Obsolete("Unable to use that old method", false)]
		public void OldMedhodWithError()
		{
			Console.WriteLine("This text can be not shown - if there 'true' value in 2-nd argument exists");
		}

		public void EnotherNewMethod()
		{
			Console.WriteLine("This is Another New Method");
		}
	}
}
