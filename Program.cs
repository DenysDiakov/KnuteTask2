using System;
using System.Collections.Generic;
using static KnuteTask2.TasksFacade;

namespace KnuteTask2
{
	class Program
	{
		static void Main(string[] args)
		{
			var tasks = new List<Action>
			{
				StartTask1,
				StartTask2,
				StartTask3,
				StartTask4And5,
				StartTask6 
			};
			tasks.ForEach(task => task.Invoke());

			Console.ReadKey();
		}		
	}
}