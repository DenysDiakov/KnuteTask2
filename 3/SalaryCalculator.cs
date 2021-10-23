namespace KnuteTask2._3
{
	public class SalaryCalculator
	{
		public decimal Calculate(Employee employee)
		{
			// Кількість днів після яких починається виплата премії
			const int amountOfWorkingDays = 90;

			decimal amountToPay = employee > amountOfWorkingDays;
			return amountToPay;
		}
	}
}