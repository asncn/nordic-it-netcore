using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
//using System.Timers;
using System.Threading;

namespace Reminder.Domain
{
    public class ReminderDomain : IDisposable
    {
        private readonly IReminderStorage _storage;
        private readonly TimeSpan _awaitingRemindersCheckingPeriod;
        private readonly TimeSpan _readyReminderSendTimer;

        private Timer _awaitingRemindersCheckTimer;
        private Timer _readyRemindersSendTimer;


        public ReminderDomain(IReminderStorage storage) : this(storage, TimeSpan.FromMinutes(1)) { }
        public ReminderDomain(IReminderStorage storage, TimeSpan awaitingRemindersCheckingPeriod) {
            _storage = storage;
            _awaitingRemindersCheckingPeriod = awaitingRemindersCheckingPeriod;
        }

        private Timer _awaitingRemindersChecktimer;
        // public ReminderDomain(IReminderStorage storage)
        // {
        //    _storage = storage;
        // }
        public void AddReminder(ReminderItem Item)
        {
            _storage.Add(Item);

        }

        public void Run()
        {
            _awaitingRemindersChecktimer = new Timer(

                CheckAwatingReminders,
                null,
                TimeSpan.Zero,
                TimeSpan.FromMinutes(1));
        }

        private void CheckAwatingReminders(object _) //not used
        {
            // List<ReminderItemStatus> statuses = new List<ReminderItemStatus>()
            // {
            //     var items = _storage.GetList(statuses);
            // };

            var readyItems = _storage.GetList(new[] { ReminderItemStatus.Awaiting }); //list.where i :=> i.IsTimeToSend;

            foreach (var readyItem in readyItems)
            {
                readyItem.Status = ReminderItemStatus.ReadyToSend;
                _storage.Update(readyItem);
            }

        }
           // var readyItems = _storage.GetList(new[] { ReminderItemStatus.Awaiting });

          //foreach (var readyItem in readyItems)
          //  {
          //      readyItem.Status = ReminderItemStatus.ReadyToSend;
        //        _storage.Update(readyItem);
         //   }


    public void Dispose()
        {
            _awaitingRemindersChecktimer?.Dispose();
        }
    }
}
