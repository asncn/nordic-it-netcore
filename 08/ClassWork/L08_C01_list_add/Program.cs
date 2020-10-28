using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> intList = new List<int>
		{
			10, 20, 30, 40
		};

		intList.RemoveAt(1); // 10, 30, 40
		intList.Insert(1, 21);

		int[] intArray = new[]
		{
			50, 60
		};

		intList.AddRange(intArray);

		string output = string.Join(", ", intList);

		intList.Clear();
		if(intList.Count == 0)
			Console.WriteLine("Список intList пуст!");

		Console.WriteLine(output);
		// 10, 21, 30, 40

		List<string> strList = new List<string>();
		strList.Add("one");
		strList.Add("two");
		strList.Add("three");
		strList.Add("four");
		strList.Add("four");
		strList.Add(null);
		strList.Add(null);

		Console.WriteLine(string.Join(", ", strList));
		// one, two, three, four, four, ,
	}
}