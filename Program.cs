using System;

namespace KnuteTask2
{
	class Program
	{
		static void Main(string[] args)
		{
			writeBorder(1);
			TasksFacade.StartTask1();

			writeBorder(2);
			TasksFacade.StartTask2();

			writeBorder(3);
			TasksFacade.StartTask3();

			writeBorder(4);
			TasksFacade.StartTask4();

			Console.ReadKey();
		}

		private static void writeBorder(int taskNumber)
		{
			Console.WriteLine("\nЗавдання №{0} {1}", taskNumber, new string('-', 50));
		}
	}
}
