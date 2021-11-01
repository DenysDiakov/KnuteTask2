using KnuteTask2._2;
using KnuteTask2._3;
using KnuteTask2._6;
using KnuteTask2._6.Products;
using System;
using System.Collections.Generic;
using System.Threading;

namespace KnuteTask2
{
	public static class TasksFacade
	{
		#region Завдання 1
		public static void StartTask1()
		{
			writeTaskNumberAndBorder(1);

			initializePersons();
			GC.Collect();
			Thread.Sleep(1000);

			void initializePersons()
			{
				new List<Person> { new Person(), new Person(), new Person(), new Person() };
			}
		}
		#endregion

		#region Завдання 2
		public static void StartTask2()
		{
			writeTaskNumberAndBorder(2);

			var usersToAdd = new User[]
			{
				new User("Денис", "Дьяков", 22, 1),
				new User("Иван", "Иванов", 30, 2)
			};
			foreach (var user in usersToAdd)
			{
				UserRepository.AddUser(user);
			}

			var manager = new UserManager();
			manager.ShowUserInfo(user => user.Name == "Алексей" && user.Id == 99);
			manager.ShowUserInfo(user => user.Name == "Денис" && user.LastName == "Дьяков");
		}
		#endregion

		#region Завдання 3
		public static void StartTask3()
		{
			writeTaskNumberAndBorder(3);

			var juniorDeveloper = new Employee("Алексей", new DateTime(2021, 8, 10), 500);
			var middleDeveloper = new Employee("Денис", new DateTime(2020, 7, 19), 2000);

			var salaryCalculator = new SalaryCalculator();
			decimal juniorFinalSalary = salaryCalculator.Calculate(juniorDeveloper);
			showMessage(juniorDeveloper.Name, juniorFinalSalary);

			decimal middleFinalSalary = salaryCalculator.Calculate(middleDeveloper);
			showMessage(middleDeveloper.Name, middleFinalSalary);

			void showMessage(string name, decimal salary)
			{
				Console.WriteLine("Ім'я - {0}\nПотрібно виплатити - {1:C}", name, salary);
			}
		}
		#endregion

		#region Завдання 4-5
		public static void StartTask4And5()
		{
			writeTaskNumberAndBorder(4, 5);

			var persons = new List<_4.Person>
			{ 
				new _4.Person(),
				new _4.Person("Максим"),
				new _4.Person("Казимир", "Казимирович")
			};
			persons.ForEach(person => person.ShowInfo());
		}
		#endregion

		#region Завдання 6
		public static void StartTask6()
		{
			writeTaskNumberAndBorder(6);

			var customerOne = Shop.AddNewCustomer("Владислав", "Гриченко", age: 33);
			var firstCustomerProductsToBuy = new List<Product> { new Laptop(), new Smartphone(), new Laptop() };
			firstCustomerProductsToBuy.ForEach(customerOne.AddToCart);

			customerOne.ApplyDiscount(100);
			customerOne.ShowInfo();

			Console.WriteLine();

			var customerTwo = Shop.AddNewCustomer("Михайло", "Загородній", age: 14);
			var secondCustomerProductsToBuy = new List<Product> { new TV(), new Smartphone() };
			secondCustomerProductsToBuy.ForEach(customerTwo.AddToCart);

			customerTwo.ApplyDiscount(71.75m);
			customerTwo.ShowInfo();
		}
		#endregion

		private static void writeTaskNumberAndBorder(params int[] taskNumbers)
		{
			Console.WriteLine("\nЗавдання №{0} {1}", string.Join(",", taskNumbers), new string('-', 50));
		}
	}
}