using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace KnuteTask2
{
	public static class InfoManager
	{
		public static void ShowModelInfo(object obj, bool onlyPropertiesWithAttributes = true)
		{
			var sb = new StringBuilder();
			var properties = obj.GetType().GetProperties(BindingFlags.Public
													  | BindingFlags.Instance
													  | BindingFlags.DeclaredOnly);
			var disctriptionType = typeof(DescriptionAttribute);
			var drillDownType = typeof(DrillDownAttribute);
			if (onlyPropertiesWithAttributes)
			{
				properties = properties.Where(prop => 
				attributeDefined(prop, disctriptionType) ||	attributeDefined(prop, drillDownType)).ToArray();
			}
			foreach (var prop in properties)
			{
				// Вивести інформацію про властивості моделі поміченої атрибутом DrillDown
				if (attributeDefined(prop, drillDownType))
				{
					var value = prop.GetValue(obj, null);
					ShowModelInfo(value, onlyPropertiesWithAttributes);
					continue;
				}
				var attribute = prop
					.GetCustomAttributes(disctriptionType, true)
					.Cast<DescriptionAttribute>()
					.FirstOrDefault();
				string name = prop.Name;
				if (attribute != null)
				{
					name = attribute.Description;
				}
				sb.AppendFormat("{0} - {1}\n", name, prop.GetValue(obj, null));
			}
			Console.WriteLine(sb.ToString());

			bool attributeDefined(MemberInfo property, Type attributeType)
			{
				return Attribute.IsDefined(property, attributeType);
			}
		}
	}

	public class DrillDownAttribute : Attribute
	{ }
}