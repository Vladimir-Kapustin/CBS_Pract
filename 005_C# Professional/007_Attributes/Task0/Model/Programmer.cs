using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	[AccessLevel("Lowest")]
	class Programmer
	{
		string attribName;
		AccessLevelAttribute level;
		Type type = typeof(Programmer);

		public void Show()
		{
			Console.WriteLine("This is Programmer");
		}

		public void TryAccess(SecuredSection secured)
		{

			object[] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute), false);
			foreach (var attribute in attributes)
			{
				level = attribute as AccessLevelAttribute;
				attribName = level.Level;
			}

			secured.Access(attribName);
		}
	}
}
