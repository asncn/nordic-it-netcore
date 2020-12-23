using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using Reminder.Storage.InMemory;
using System;

namespace Reminder.Domain.Tests
{
    [TestClass]
    public class ReminderDomainTests
    {
        [TestMethod]
        public void Awaiting_Item_Changes_Status_to_ReadyToSend_After_Checking_Period()
        {
            var storage = new InMemoryReminderStorage();
                using var domain = new ReminderDomain(
                storage,
                TimeSpan.FromMilliseconds(50));
            var item = new ReminderItem(DateTimeOffset.Now, "Hellow world", "testcontact007");

            domain.AddReminder(item);
            domain.Run();

            System.Threading.Thread.Sleep(50);

            var actualItem = storage.Get(item.Id);
            Assert.IsNotNull(actualItem);
            Assert.AreEqual(ReminderItemStatus.ReadyToSend, actualItem.Status);


               

        }
    }
}
