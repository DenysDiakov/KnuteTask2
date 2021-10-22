using System;

namespace KnuteTask2._2
{
	public class UserManager
	{
		public void ShowUserInfo(Func<User, bool> condition)
		{
			var user = UserRepository.FindUser(condition);
			if (user == null)
			{
				Console.WriteLine("Такого користувача не існує!");
				return;
			}

			InfoManager.ShowModelInfo(user);			
		}
	}
}
