using System;
using System.Text;

class Program
{
	static void Main()
	{
		string text = "   lorem    ipsum    dolor      sit   amet  ";

		StringBuilder sb1 = new StringBuilder();

		int wordIndex = 0;
		foreach (char c in text)
		{
			// for the first result we should remove all the spaces at the beginning.
			// other words, we will copy the first letter only if it is not a space.
			if (sb1.Length == 0 && c != ' ')
			{
				sb1.Append(c); // just copy char to sb1
				wordIndex = 1;
			}
			// else if it is not the first symbol
			else if (sb1.Length > 0)
			{
				// if it is not a space
				if (c != ' ')
				{
					// add to sb1 just c or char.ToUpper(c)
					sb1.Append(wordIndex == 2 ? char.ToUpper(c) : c);
				}

				// if (current char is a space and at the same time
				// the last copied char to sb1 wasn't a space)
				if (c == ' ' && sb1[sb1.Length - 1] != ' ')
				{
					wordIndex++; // increase the actual word number
					sb1.Append(c); // add this space
				}
			}
		}

		// after we finish the cycling,
		// at the end of sb1 we can receive the space,
		// so let's check whether last char is a space
		if (sb1[sb1.Length - 1] == ' ')
		{
			// remove it if it's true
			sb1.Remove(sb1.Length - 1, 1);
		}

		Console.WriteLine(sb1.ToString());
	}
}
