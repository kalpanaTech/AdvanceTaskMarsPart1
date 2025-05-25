using AdvanceTaskMarsPart1.Steps;
using CompetionTaskMars.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Tests
{
    [TestFixture]
    public class NotificationTests : Hooks
    {
        HomePageSteps homePageStepsObj = new HomePageSteps();
        NotificationSteps notificationStepsObj = new NotificationSteps();

        [Test, Order(1), Description("Test select all notification")]
        public void TestSelectAllNotification()
        {
            homePageStepsObj.ClickOnNotificationPanel();
            notificationStepsObj.SelectAllNotificationSteps();
        }
        [Test, Order(2), Description("Test unselect all notification")]
        public void TestUnSelectAllNotification()
        {
            homePageStepsObj.ClickOnNotificationPanel();
            notificationStepsObj.UnSelectAllNotificationSteps();
        }
        [Test, Order(3), Description("Test Load more notification")]
        public void TestLoadMoreNotification()
        {
            homePageStepsObj.ClickOnNotificationPanel();
            notificationStepsObj.LoadMoreNotificationSteps();
        }
        [Test, Order(4), Description("Test show less notification")]
        public void TestShowLessNotification()
        {
            homePageStepsObj.ClickOnNotificationPanel();
            notificationStepsObj.ShowLessNotificationSteps();
        }
        [Test, Order(5), Description("Test mark as read notification")]
        public void TestMarkAsReadNotification()
        {
            homePageStepsObj.ClickOnNotificationPanel();
            notificationStepsObj.MarkAsReadSteps();
        }
        [Test, Order(6), Description("Test delete notification")]
        public void TestDeleteNotification()
        {
            homePageStepsObj.ClickOnNotificationPanel();
            notificationStepsObj.DeleteNotificationSteps();
        }
    }
}
