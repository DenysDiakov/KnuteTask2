using System.ComponentModel;

namespace KnuteTask2._4
{
	public class Person
	{
		[Description("Ім'я")]
		public string Name { get; private set; }

		[Description("Прізвище")]
		public string LastName { get; private set; }

		[Description("Вік")]
		public int Age { get; private set; }

		[Description("Id")]
		public int Id { get; private set; }

		public Person(string name)
		{
			Name = name;
		}

		public Person(string name, string lastName) : this(name)
		{
			LastName = lastName;
		}

		public Person(string name = "Денис", string lastName = "Дьяков", int age = 22, int id = 1) : this(name, lastName)
		{
			Age = age;
			Id = id; 
		}

		public void ShowInfo() 
		{
			InfoManager.ShowModelInfo(this);
		}
	}
}
