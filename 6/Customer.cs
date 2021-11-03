using System;
using System.ComponentModel;

namespace KnuteTask2._6
{
	public class Customer
	{
		[Description("Ім'я")]
		public string Name { get; private set; }

		[Description("Прізвище")]
		public string LastName { get; private set; }

		[Description("Вік")]
		public int Age { get; private set; }

		[DrillDown]
		public Card Card { get; private set; }

		[DrillDown]
		public ShoppingCart ShoppingCart { get; private set; }

		public Customer(string name, string lastName, int age, int cardNumber, int bonusAmount = 0)
		{
			Name = name;
			LastName = lastName;
			Age = age;
			Card = new Card(cardNumber, bonusAmount);
			ShoppingCart = new ShoppingCart();
		}

		public void AddToCart(Product product)
		{
			if (product == null)
			{
				throw new ArgumentNullException(nameof(product));
			}
			ShoppingCart.AddToCart(product);
		}

		public void RemoveFromCart(Product product)
		{
			if (product == null)
			{
				throw new ArgumentNullException(nameof(product));
			}
			ShoppingCart.RemoveFromCart(product);
		}

		public void ApplyDiscount(decimal bonusAmount = 0)
		{
			decimal bonusToSpend = bonusAmount == 0 || bonusAmount > Card.BonusAmount ? Card.BonusAmount : bonusAmount;			
			Card.SpendBonus(bonusToSpend);
			ShoppingCart.CalculateFinalSum(bonusToSpend);
		}

		public void ShowInfo()
		{
			InfoManager.ShowModelInfo(this);
		}
	}	
}