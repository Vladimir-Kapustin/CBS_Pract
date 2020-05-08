using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());

			classRoom.Study();
			Console.WriteLine(new string('-', 50));
			classRoom.Read();
			Console.WriteLine(new string('-', 50));
			classRoom.Write();
			Console.WriteLine(new string('-', 50));
			classRoom.Relax();
		}
	}
}
