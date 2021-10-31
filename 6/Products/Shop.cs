using System.Collections.Generic;

namespace KnuteTask2._6.Products
{
	public static class Shop
	{
		public static List<Customer> Customers{ get; private set; }

		public static void AddNewCustomer(Customer customer)
		{
			Customers.Add(customer);
		}
	}
}
