using System;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace KnuteTask2
{
	public static class InfoManager
	{
		public static void ShowModelInfo(object obj)
		{
			var sb = new StringBuilder();
			foreach (var prop in obj.GetType().GetProperties())
			{
				var attribute = prop
					.GetCustomAttributes(typeof(DescriptionAttribute), true)
					.Cast<DescriptionAttribute>()
					.FirstOrDefault();
				var name = prop.Name;
				if (attribute != null)
				{
					name = attribute.Description;
				}
				sb.AppendFormat("{0} - {1}\n", name, prop.GetValue(obj, null));
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
