using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	[AccessLevel("Highest")]
	class Director
	{
		string attribName;
		AccessLevelAttribute level;
		Type type = typeof(Director);

		public void Show()
		{
			Console.WriteLine("This is Director");
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
