using System;
using System.Collections.Generic;
using HomeWork_11;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset dateTime;
            string message, phoneNumber, chatName, accountName;
            Console.Write("Введите количество напоминаний:");
            long amountOfReminders = long.Parse(Console.ReadLine());
            ReminderItem reminder;
            List<ReminderItem> reminders = new List<ReminderItem>();
            byte reminderType = 0;

            for (int i = 0; i < amountOfReminders; i++)
            {
                Console.WriteLine($"Введите номер типа напоминания №:  {i + 1} " +
                    "\n1 - обычное напоминание;" +
                    "\n2 - напоминание для чата;" +
                    "\n3 - напоминание для телефона");
                try
                {
                    reminderType = byte.Parse(Console.ReadLine());
                    switch (reminderType)
                    {
                        case 1:
                        case 2:
                        case 3:
                            break;
                        default:
                            throw new Exception("Выбран несуществующий тип напоминания!");
                    }
                    Console.Write($"Введите время напоминания №{i + 1}: ");
                    dateTime = DateTimeOffset.Parse(Console.ReadLine());
                    Console.Write($"Введите сообщение напоминания №{i + 1}: ");
                    message = Console.ReadLine();
                    switch (reminderType)
                    {
                        case 1:
                            reminder = new ReminderItem(message, dateTime);
                            reminders.Add(reminder);
                            break;
                        case 2:
                            Console.Write("Введите название чата: ");
                            chatName = Console.ReadLine();
                            Console.Write("Введите название аккаунта: ");
                            accountName = Console.ReadLine();

                            reminder = new ChatReminderItem(message, dateTime, chatName, accountName);
                            reminders.Add(reminder);
                            break;
                        case 3:
                            Console.Write("Введите номер телефона: ");
                            phoneNumber = Console.ReadLine();

                            reminder = new PhoneReminderItem(message, dateTime, phoneNumber);
                            reminders.Add(reminder);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка {e.Message}, попробуйте еще раз!");
                    i--;
                    continue;
                }
            }
            for (int i = 0; i < amountOfReminders; i++)
            {
                Console.WriteLine($"Напоминание №{i + 1}:");
                reminders[i].WriteProperties();
            }
        }
    }
}
