using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	class AccessLevelAttribute : System.Attribute
	{
		private string level;

		public string Level
		{
			get { return level; }
			set { level = value; }
		}
		
		public AccessLevelAttribute(string level)
		{
			this.level = level;
		}

		public int Number { get; set; }
	}
}
