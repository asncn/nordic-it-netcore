using System;
namespace HomeWork___11

{
	class Program
	{
		static void Main(string[] args)
		{
			DateTimeOffset alarmDate = default;
			string alarmMessage = null;
			ReminderItem[] reminders = new ReminderItem[2];
            reminders[0] = new ReminderItem(alarmDate, alarmMessage);
			reminders[1] = new ReminderItem(alarmDate, alarmMessage);

			for (int i = 0; i < 2; i++)
			{
				reminders[i].WriteProperties();
			}
		}
	}
}
