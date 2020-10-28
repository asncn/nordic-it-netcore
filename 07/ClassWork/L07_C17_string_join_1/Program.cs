using System;

class Program
{
	static void Main()
	{
		var test = "my tESt string";

		string[] words = test.Split(' ');
		Console.WriteLine(string.Join(" & ", words));
		// my & test & string

		// Create from string Pascal-casing and Camel-casing variable names
		string[] pascalCasingName = new string[words.Length];
		string[] camelCasingName = new string[words.Length];

		for (int i = 0; i < words.Length; i++)
		{
			pascalCasingName[i] = char.ToUpper(words[i][0])
				+ words[i].Substring(1).ToLower();

			camelCasingName[i] = i == 0
				? words[i].ToLower()
				: char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
		}

		Console.WriteLine(string.Join(null, pascalCasingName));
		Console.WriteLine(string.Join(null, camelCasingName));
		
	}
}