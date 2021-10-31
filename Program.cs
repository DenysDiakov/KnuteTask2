using System;

namespace KnuteTask2
{
	class Program
	{
		static void Main(string[] args)
		{
			writeTaskNumber(1);
			TasksFacade.StartTask1();

			writeTaskNumber(2);
			TasksFacade.StartTask2();

			writeTaskNumber(3);
			TasksFacade.StartTask3();

			writeTaskNumber(4, 5);
			TasksFacade.StartTask4And5();

			writeTaskNumber(6);
			TasksFacade.StartTask6();

			Console.ReadKey();
		}

		private static void writeTaskNumber(params int[] taskNumbers)
		{
			Console.WriteLine("\nЗавдання №{0} {1}", string.Join(",", taskNumbers), new string('-', 50));
		}
	}
}