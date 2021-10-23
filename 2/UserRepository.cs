using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuteTask2._2
{
	public static class UserRepository
	{
		public static List<User> Users { get; private set; }

		static UserRepository()
		{
			Users = new List<User>(); 
		}

		public static User FindUser(Func<User, bool> condition) 
		{
			if (condition == null)
			{
				throw new ArgumentNullException(nameof(condition));
			}
			return Users.FirstOrDefault(condition);			
		}

		public static void AddUser(User user)
		{
			if (user == null)
			{
				throw new ArgumentNullException(nameof(user));
			}
			Users.Add(user);
		}
	}
}
