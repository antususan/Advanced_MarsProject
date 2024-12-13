using Advanced_ProjectMars.AssertHelper;
using Advanced_ProjectMars.Steps;
using Advanced_ProjectMars.Utilities;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Tests
{
    [TestFixture]
    public class NotificationTest : CommonDriver
    {
        NotificationSteps notificationObj =new NotificationSteps();
        AssertNotification assertNotificationObj = new AssertNotification();

        [Test, Order(1)]

        public void NotificationLoadMore()
        {
            test = extent.CreateTest("NotificationLoadMore").Info("Test 1- NotificationLoadMore Started");
            notificationObj.NotificationTabStepsLoadMore();
            assertNotificationObj.AssertNotificationLoadMore();

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-1 Passed");

        }

        [Test, Order(2)]

        public void NotificationShowLess()
        {
            test = extent.CreateTest("NotificationShowLess").Info("Test 2- NotificationShowLess Started");
            notificationObj.NotificationTabStepsShowLess();
            assertNotificationObj.AssertNotificationShowLess();

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-2 Passed");

        }
        [Test, Order(3)]
        public void SelectAll()
        {
            test = extent.CreateTest("SelectAll").Info("Test 3- SelectAll Started");
            notificationObj.NotificationTabStepsSelectAll();
            assertNotificationObj.AssertNotificationSelectAll();

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-3 Passed");
        }
        [Test, Order(4)]
        public void UnSelectAll()
        {
            test = extent.CreateTest("UnSelectAll").Info("Test 4- UnSelectAll Started");
            notificationObj.NotificationTabStepsUnSelectAll();
            assertNotificationObj.AssertNotificationUnSelectAll();

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-4 Passed");
        }
        [Test, Order(5)]
        public void MarkSelectionAsRead()
        {
            test = extent.CreateTest("MarkSelectionAsRead").Info("Test 5- MarkSelectionAsRead Started");
            notificationObj.NotificationTabStepMarkSelectionAsRead();
            assertNotificationObj.AssertNotificationMarkSelectAsRead();

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-5 Passed");
        }
        [Test, Order(6)]
        public void Delete()
        {
            test = extent.CreateTest("Delete").Info("Test 5- Delete Started");
            notificationObj.NotificationTabStepDelete();
            assertNotificationObj.AssertNotificationDelete();

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-5 Passed");
        }



    }
}
