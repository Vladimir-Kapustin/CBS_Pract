using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp.UserServices
{
	class UserService
	{
		List<User> _users;

		public UserService()
		{
			_users = UserInitializer.GetSmpleUserData();
		}

		public IEnumerable<User> GetAllUsers()
		{
			return _users.OrderByDescending
		}

		internal void SaveScore(User user)
		{
			if (user.Name == Null)
			{

			}
		}
	}
}
