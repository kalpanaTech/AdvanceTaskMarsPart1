using AventStack.ExtentReports;
using CompetionTaskMars.Tests;
using CompetionTaskMars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Assertions
{
    public class NotificationAssertions : Hooks
    {
    
        private static readonly By toastMessageLocator = By.XPath("//div[@class='ns-box-inner']");
        private static IWebElement toastMessage;

        static string notificationUpdateMessage = "Notification updated";
        public void NotificationIndicationAssertion()
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 3);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                Assert.That(displayedMessage, Is.EqualTo(notificationUpdateMessage));

                if (displayedMessage == notificationUpdateMessage)
                {
                    test.Pass("Notification indication test passed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Toast message not found or assertion failed: " + ex.Message);
            }
        }
        public void SelectAllNotificationAssertion(bool clicked)
        {
            Assert.That(clicked, Is.True);
            test.Pass("SelectAll test passed");
        }
        public void UnSelectAllNotificationAssertion(bool clicked)
        {
            Assert.That(clicked, Is.True);
            test.Pass("UnSelect All test passed");
        }
        public void LoadMoreNotificationAssertion(bool clicked)
        {
            Assert.That(clicked, Is.True);
            test.Pass("Load More test passed");
        }
        public void ShowLessNotificationAssertion(bool clicked)
        {
            Assert.That(clicked, Is.True);
            test.Pass("Show Less test passed");
        }
    }
}
