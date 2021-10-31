using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace KnuteTask2._6
{
	public class ShoppingCart
	{
		public List<Product> Items { get; private set; }

		[Description("Сумма")]
		public decimal Sum { get => Items.Sum(product => product.Price); }

		[Description("Фінальна сумма")]
		public decimal FinalSum { get; private set; }

		public ShoppingCart()
		{
			Items = new List<Product>();
		}

		public void AddToCart(Product product)
		{
			Items.Add(product);
		}

		public void RemoveFromCart(Product product)
		{
			Items.Remove(product);
		}

		public void CalculateFinalSum(int bonuses)
		{
			FinalSum = Sum - bonuses;
		}
	}
}
