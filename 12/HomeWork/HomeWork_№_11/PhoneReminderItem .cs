using System;
namespace HomeWork_11
{
    class PhoneReminderItem : ReminderItem
    {
		public string PhoneNumber { get; set; }
		public PhoneReminderItem(string alarmMessage, DateTimeOffset alarmDate, string phoneNumber) : base(alarmMessage, alarmDate)
		{
			PhoneNumber = phoneNumber;
		}
		public override void WriteProperties()
		{
			string outDated = IsOutdated
				? "будильник не просрочен"
				: "будильник просрочен";
			Console.WriteLine($"Дата и время будильника: {AlarmDate}, " +
				$" текст будильника: {AlarmMessage}, " +
				$"\nвремя до срабатывания будильника: {TimeToAlarm}, {outDated}");
		}

	}
}
