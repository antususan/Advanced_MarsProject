using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Steps
{
    public class NotificationSteps
    {
        NotificationComponent notificationComponentObj= new NotificationComponent();
        public void NotificationTabStepsLoadMore()
        {
            notificationComponentObj.GotoNotificationTab();
            notificationComponentObj.LoadMore();
        }

        public void NotificationTabStepsShowLess()
        {
            notificationComponentObj.GotoNotificationTab();
            notificationComponentObj.LoadMore();
            notificationComponentObj.ShowLess();
        }
        public void NotificationTabStepsSelectAll()
        {
            notificationComponentObj.GotoNotificationTab();
            notificationComponentObj.LoadMore();
            notificationComponentObj.SelectAll();
          
        }
        public void NotificationTabStepsUnSelectAll()
        {
            notificationComponentObj.GotoNotificationTab();
            notificationComponentObj.LoadMore();
            notificationComponentObj.SelectAll();
            notificationComponentObj.UnSelectAll();

        }
        public void NotificationTabStepMarkSelectionAsRead()
        {
            notificationComponentObj.GotoNotificationTab();
            notificationComponentObj.LoadMore();
            notificationComponentObj.SelectAll();
            notificationComponentObj.MarkSelectAsRead();

        }
        public void NotificationTabStepDelete()
        {
            notificationComponentObj.GotoNotificationTab();
            notificationComponentObj.LoadMore();
            notificationComponentObj.SelectAll();
            notificationComponentObj.Delete();

        }
        



    }
}
