namespace KnuteTask2._6
{
	public class Customer
	{
		public string Name { get; private set; }

		public string LastName { get; private set; }

		public int Age { get; private set; }

		public int CardNumber { get; private set; }

		public ShoppingCart Basket { get; set; }

		public Customer(string name, string lastName, int age)
		{
			Name = name;
			LastName = lastName;
			Age = age;
			Basket = new ShoppingCart();
		}
	}
}
