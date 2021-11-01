using System;
using System.ComponentModel;

namespace KnuteTask2._6
{
	public class Card
	{
		[Description("Номер карти лояльності")]
		public int Number { get; private set; }

		[Description("Кількість бонусів")]
		public decimal BonusAmount { get; private set; }

		public Card(int number, decimal bonusAmount)
		{
			Number = number;
			BonusAmount = bonusAmount;
		}

		public void SpendBonus(decimal bonus) 
		{
			if (bonus > BonusAmount)
			{
				throw new Exception("Не можливо списати більше бонусів, чим є");
			}
			BonusAmount -= bonus;
		}
	}
}
