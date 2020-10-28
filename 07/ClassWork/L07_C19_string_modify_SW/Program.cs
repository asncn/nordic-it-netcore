using System;

class Program
{
	static void Main()
	{
		string text = "   lorem    ipsum    dolor      sit   amet  ";

		// part 1:
		// split string by words
		string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

		// uppercase for the second word
		words[1] = words[1].ToUpperInvariant();

		// join words using single space char
		Console.WriteLine(string.Join(' ', words));

		// part 2: 
		// remove the spaces at the end of the line
		string textClean = text.TrimEnd();

		// looking for the position of the last space char
		int lastSpaceIndex = textClean.LastIndexOf(' ');

		// cutting string from 0 to lastSpaceIndex
		textClean = textClean.Substring(0, lastSpaceIndex);

		// clean up the tail
		textClean = textClean.TrimEnd();

		// this is it :)
		Console.WriteLine(textClean);
	}
}
