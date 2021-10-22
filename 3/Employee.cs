using System;

namespace KnuteTask2._3
{
	// Завдання:
	// Через перевантаження операторів реалізувати суму зарплати та премії
	public class Employee
	{
		public string Name { get; private set; }

		public DateTime HiringDate { get; set; }

		public decimal Salary { get; private set; }

		public Employee(string name, DateTime hiringDate, decimal salary)
		{
			Name = name;
			HiringDate = hiringDate;
			Salary = salary;
		}

		public static decimal operator >(Employee employee, int days)
		{
			decimal salary = employee.Salary;
			return getTheNumberOfDaysWorked(employee.HiringDate) > days ? sumOfSalaryAndPremium(salary) : salary;
		}

		public static decimal operator <(Employee employee, int days)
		{
			decimal salary = employee.Salary;
			return getTheNumberOfDaysWorked(employee.HiringDate) < days ? salary : sumOfSalaryAndPremium(salary);
		}

		private static int getTheNumberOfDaysWorked(DateTime hiringDate)
		{
			return (DateTime.Now - hiringDate).Days;
		}

		private static decimal sumOfSalaryAndPremium(decimal salary)
		{
			decimal premium = (salary / 3);
			return salary + premium;
		}
	}
}
