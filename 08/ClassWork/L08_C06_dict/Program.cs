using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		var countries = new Dictionary<string, string>(5);
		countries.Add("Moscow", "Russia");
		countries.Add("London", "Great Britain");
		countries.Add("Washington", "USA");

		int index = new Random().Next(countries.Count);
		KeyValuePair<string, string> kvp = countries.ElementAt(index);

		Console.WriteLine($"Enter the capital of {kvp.Key}");
		string answer = Console.ReadLine().Trim();
		if (answer == kvp.Value)
		{
			// win
		}
		else
		{
			// loose
		}

		// нельзя добавлять элементы с уже существующими ключами
		//countries.Add(1, "Some new country");

		countries["1"] = "Россия";
		
		foreach (KeyValuePair<string, string> country in countries)
		{
			Console.WriteLine($"{country.Key} - {country.Value}");
		}

		countries.Remove("1");
		countries.Add("1", "Russia");

		foreach (KeyValuePair<string, string> country in countries)
		{
			Console.WriteLine($"{country.Key} - {country.Value}");
		}

		if(!countries.ContainsKey("1"))
			countries.Add("1", "XXX");



	}
}