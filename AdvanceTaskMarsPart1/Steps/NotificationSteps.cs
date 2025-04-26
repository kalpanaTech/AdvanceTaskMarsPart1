using AdvanceTaskMarsPart1.Assertions;
using AdvanceTaskMarsPart1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Steps
{
    public class NotificationSteps
    {
        NotificationOverviewComponent notificationOverviewComponentObj = new NotificationOverviewComponent();
        NotificationAssertions notificationAssertionsObj = new NotificationAssertions();
           
        public void SelectAllNotificationSteps()
        {
            bool selectAllNotification = notificationOverviewComponentObj.SelectAllNotification();
            notificationAssertionsObj.SelectAllNotificationAssertion(selectAllNotification);
        }
        public void UnSelectAllNotificationSteps()
        {
            bool unSelectAllNotification = notificationOverviewComponentObj.UnSelectAllNotification();
            notificationAssertionsObj.UnSelectAllNotificationAssertion(unSelectAllNotification);
        }
        
        public void LoadMoreNotificationSteps()
        {
            bool loadMoreNotification = notificationOverviewComponentObj.LoadMoreNotification();
            notificationAssertionsObj.LoadMoreNotificationAssertion(loadMoreNotification);
        }
        public void ShowLessNotificationSteps()
        {
            bool showLessNotification = notificationOverviewComponentObj.ShowLessNotification();
            notificationAssertionsObj.ShowLessNotificationAssertion(showLessNotification);
        }
        public void MarkAsReadSteps()
        {
            notificationOverviewComponentObj.MarkAsReadNotification();
            notificationAssertionsObj.NotificationIndicationAssertion();
        }
        public void DeleteNotificationSteps()
        {
            notificationOverviewComponentObj.NotificationDeletion();
            notificationAssertionsObj.NotificationIndicationAssertion();
        }
    }
}
