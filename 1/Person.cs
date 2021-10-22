using System;

namespace KnuteTask2
{
	public class Person
	{
		public static int Amount { get; private set; }

		public Person()
		{
			Console.WriteLine("Створено людину");
			increaseAmount();
			ShowAmount();
		}

		~Person()
		{
			Console.WriteLine("Видалено людину");
			decreaseAmount();
			ShowAmount();
		}

		public void ShowAmount()
		{
			Console.WriteLine($"Усього людей на данний момент {Amount}");
		}

		private void increaseAmount()
		{
			Amount++;
		}		

		private void decreaseAmount()
		{
			Amount--;
		}
	}
}
