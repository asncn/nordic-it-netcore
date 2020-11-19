using System;

namespace HomeWork___11
{
	class ReminderItem
	{
		public DateTimeOffset AlarmDate { get; set; }
		public string AlarmMessage { get; set; }
		public TimeSpan TimeToAlarm
		{
			get
			{
				return (AlarmDate - DateTimeOffset.Now);
			}
		}
		public bool IsOutdated
		{
			get
			{
				return TimeToAlarm > TimeSpan.Zero;
			}
		}
		public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
		{

			AlarmDate = alarmDate;
			AlarmMessage = alarmMessage;
		}
		public void WriteProperties()
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



