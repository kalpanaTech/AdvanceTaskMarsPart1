using AventStack.ExtentReports;
using CompetionTaskMars.Helpers;
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
    public class UserDetailAssertions : Hooks
    {
        
        private static readonly By toastMessageLocator = By.XPath("//div[@class='ns-box-inner']");
        private static IWebElement toastMessage;

        
        private static readonly string userDetailUpdateMessage = "Availability updated";

        public void UpdateUserDetailAssertion()
        {
          
            Wait.WaitToBeVisible(driver, toastMessageLocator, 5);
            toastMessage = driver.FindElement(toastMessageLocator);

            string displayedMessage = toastMessage.Text;

            Assert.That(displayedMessage, Is.EqualTo(userDetailUpdateMessage));

            if (displayedMessage == userDetailUpdateMessage)
            {
                test.Pass("User Details Test passed Successfully");
                Console.WriteLine(displayedMessage);

            }
        }
    }
}
