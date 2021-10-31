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
		public Card Card { get; set; }

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

		public void ApplyDiscount(int bonusesAmount = 0)
		{
			if (bonusesAmount > Card.BonusAmount)
			{
				throw new Exception("Не можливо списати більше бонусів, чим є");
			}
			ShoppingCart.CalculateFinalSum(bonusesAmount == 0 ? Card.BonusAmount : bonusesAmount);
		}

		public void ShowInfo()
		{
			InfoManager.ShowModelInfo(this);
		}
	}

	public class Card
	{
		[Description("Номер карти лояльності")]
		public int Number { get; set; }

		[Description("Кількість бонусів")]
		public int BonusAmount { get; set; }

		public Card(int number, int bonusAmount) 
		{
			Number = number;
			BonusAmount = bonusAmount;
		}
	}
}
