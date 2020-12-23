using System;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;
using Reminder.Domain;

namespace Reminder.TestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var storage = new InMemoryReminderStorage();
			var domain = new ReminderDomain(storage);

			

			
			var item = new ReminderItem(
				DateTimeOffset.Now,
				"Hello world",
				"testContact007");

			//storage.Add(item);
			//var itemFromStorage = storage.Get(item.Id);
			domain.AddReminder(item);
			domain.Run();

			//Console.WriteLine(itemFromStorage.Message);
		}
	}
}
