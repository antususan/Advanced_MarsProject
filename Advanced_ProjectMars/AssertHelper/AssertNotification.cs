using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using Advanced_ProjectMars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.AssertHelper
{
    public class AssertNotification:CommonDriver
    {
        NotificationComponent notificationComponentObj =new NotificationComponent();
        public void AssertNotificationLoadMore()
        {
            string loadmore =notificationComponentObj.AssertLoadMore();
            Assert.That(loadmore == "...Show Less", " LoadMore action is Unsucessfull");
        }
        public void AssertNotificationShowLess()
        {
            string showLess = notificationComponentObj.AssertShowLess();
            Assert.That(showLess == "Load More...", " ShowLess action is Unsucessfull");
        }
        public void AssertNotificationSelectAll()
        {
            bool allchecked = notificationComponentObj.AssertSelectAll();
            Assert.That(allchecked, Is.True , " all checkboxes are Not checked");
        }

        public void AssertNotificationUnSelectAll()
        {
            bool allnotchecked = notificationComponentObj.AssertUnSelectAll();
            Assert.That(allnotchecked, Is.True, " all checkboxes are  checked");
        }
        //public void AssertNotificationSelectAll()
        //{

        //    IList<IWebElement> checkboxes = driver.FindElements(By.CssSelector("input[type='checkbox']"));

        //    // Assert all checkboxes are checked
        //    foreach (IWebElement checkbox in checkboxes)
        //    {
        //        if (!checkbox.Selected)
        //        {
        //            Console.WriteLine("Checkbox is not checked.");
        //        }
        //    }

        //}
        //public void AssertNotificationUnSelectAll()
        //{

        //    IList<IWebElement> checkboxes = driver.FindElements(By.CssSelector("input[type='checkbox']"));

        //    // Assert all checkboxes are checked
        //    foreach (IWebElement checkbox in checkboxes)
        //    {
        //        if (checkbox.Selected)
        //        {
        //            Console.WriteLine("Checkbox is still checked.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Checkbox is unchecked.");
        //        }
        //    }

        //}
        public void AssertNotificationMarkSelectAsRead()
        {
            string newpopupmessage =notificationComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == "Notification updated", "Notification MarkSelectAsRead is Unsucessfull");
        }
        public void AssertNotificationDelete()
        {
            string newpopupmessage = notificationComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == "Notification updated", "Notification Delete is Unsucessfull");
        }
        




    }
}
