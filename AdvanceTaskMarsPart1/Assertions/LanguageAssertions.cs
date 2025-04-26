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
        private static string AddInvalidLangMessage = "Please enter language and level";
        private static string AddExsistingLangMessage = "This language is already exist in your language list.";
        private static string EditAsExsistingLangMessage = "This language is already added to your language list.";
        private static string UpdateLangMessage = "has been updated to your languages";
        private static string AddDuplicateLangMessage = "Duplicated data";
        private static string UndefinedMessage = "undefined";


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
                   test.Pass("Language added successfully : " + displayedMessage);
                    
                }
                else
                {
                    test.Fail("Language add Failed");
                    
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }
        }

        public void EditLanguageAssertions(string language, ExtentTest test)
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 10);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                string editLangMessage = language + " has been updated to your languages";

                Assert.That(displayedMessage, Is.EqualTo(editLangMessage)
                    .Or.EqualTo(UpdateLangMessage)
                    .Or.EqualTo(AddInvalidLangMessage)
                    .Or.EqualTo(EditAsExsistingLangMessage)
                    .Or.EqualTo(AddDuplicateLangMessage));

                if ((displayedMessage == AddInvalidLangMessage) ||
                    (displayedMessage == EditAsExsistingLangMessage) ||
                    (displayedMessage == AddDuplicateLangMessage))
                {
                    test.Info("Entered invalid language data: " + displayedMessage);
                    cancelButton = driver.FindElement(cancelButtonLocator);
                    cancelButton.Click();
                }
                else if (displayedMessage == editLangMessage || displayedMessage.Contains("updated to your languages"))
                {
                    test.Pass("Language edited successfully: " + displayedMessage);
                }
                else
                {
                    test.Fail("Language edit failed or unexpected message: " + displayedMessage);
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }
        }

        public void DeleteLanguageAssertions(string language, ExtentTest test)
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 10);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                string deleteLangMessage = language + " has been deleted from your languages";

                Assert.That(displayedMessage, Is.EqualTo(deleteLangMessage));

                if (displayedMessage == deleteLangMessage)
                {
                    test.Pass("Language deleted successfully: " + displayedMessage);
                }
                else
                {
                    test.Fail("Language delete failed or unexpected message: " + displayedMessage);
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }
        }
    }
}
