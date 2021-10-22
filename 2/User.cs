using System.ComponentModel;

namespace KnuteTask2
{
	public class User
	{
		[Description("Ім'я")]
		public string Name { get; private set; }

		[Description("Прізвище")]
		public string LastName { get; private set; }

		[Description("Вік")]
		public int Age { get; private set; }

		[Description("Id")]
		public int Id { get; private set; }

		public User(string name, string lastName, int age, int id) 
		{
			Name = name;
			LastName = lastName;
			Age = age;
			Id = id;
		}
	}
}
