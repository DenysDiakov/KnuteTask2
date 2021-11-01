using System.Collections.Generic;
using System.Linq;

namespace KnuteTask2._6.Products
{
	public static class Shop
	{
		public static List<Customer> Customers{ get; private set; }

		static Shop() 
		{
			Customers = new List<Customer>();
		}

		public static Customer AddNewCustomer(string name, string lastName, int age)
		{
			int cardNumber = getNewCardNumber();
			var customer = new Customer(name, lastName, age, cardNumber, bonusAmount: 100);
			Customers.Add(customer);
			return customer;
		}

		private static int getNewCardNumber()
		{
			if (Customers.Any())
			{
				return Customers.Max(customer => customer.Card.Number) + 1;
			}
			return 1;
		}
	}
}
