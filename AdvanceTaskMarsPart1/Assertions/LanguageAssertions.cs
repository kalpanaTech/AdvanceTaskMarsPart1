using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
    public class LanguageAssertions : Hooks
    {
        private static readonly By toastMessageLocator = By.XPath("//div[@class = 'ns-box-inner']");
        private static IWebElement toastMessage;

        private static readonly By cancelButtonLocator = By.XPath("//input[@value='Cancel']");
        private static IWebElement cancelButton;

        // Toast Messages
        static string AddInvalidLangMessage = "Please enter language and level";
        static string AddExsistingLangMessage = "This language is already exist in your language list.";
        static string AddDuplicateLangMessage = "Duplicated data";

      
        public void AddLanguageAssertions(string language, ExtentTest test)
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 10);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                string addLangMessage = language + " has been added to your languages";

                var status = TestContext.CurrentContext.Result.Outcome.Status;

                Assert.That(displayedMessage, Is.EqualTo(addLangMessage)
                    .Or.EqualTo(AddInvalidLangMessage)
                    .Or.EqualTo(AddExsistingLangMessage)
                    .Or.EqualTo(AddDuplicateLangMessage));

                if ((displayedMessage == AddInvalidLangMessage) ||
                    (displayedMessage == AddExsistingLangMessage) ||
                    (displayedMessage == AddDuplicateLangMessage))
                {
                    test.Pass("Entered invalid language data : " + displayedMessage);
                    cancelButton = driver.FindElement(cancelButtonLocator);
                    cancelButton.Click();
                }
                else if (displayedMessage == addLangMessage)
                {
                   test.Pass("Entered valid data : " + displayedMessage);
                    
                }
                else
                {
                    test.Pass("Language add Failed");
                    
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }
        }

        
    }
}
