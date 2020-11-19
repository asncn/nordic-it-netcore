using System;
namespace HomeWork___11
{
	class Program
	{
		static void Main(string[] args)
		{
			
			ReminderItem[] reminders = new ReminderItem[2];
			
			for (int i = 0; i < 2; i++)
			{
				reminders[i].WriteProperties();
			}

		}
	}
}
