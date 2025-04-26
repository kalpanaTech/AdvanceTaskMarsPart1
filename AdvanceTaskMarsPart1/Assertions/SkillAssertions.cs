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
    public class SkillAssertions : Hooks
    {
        private static readonly By toastMessageLocator = By.XPath("//div[@class = 'ns-box-inner']");
        private static IWebElement toastMessage;

        private static readonly By cancelButtonLocator = By.XPath("//input[@value='Cancel']");
        private static IWebElement cancelButton;

        private static string AddInvalidSkillMessage = "Please enter skill and experience level";
        private static string AddExsistingSkillMessage = "This skill is already exist in your skill list.";
        private static string EditAsExsistingSkillMessage = "This skill is already added to your skill list.";
        private static string AddDuplicateSkillMessage = "Duplicated data";
       // private static string UpdateSkillMessage = " has been updated to your skills";
        private static string UndefinedMessage = "undefined";

        public void AddSkillsAssertions(string skill, ExtentTest test)
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 10);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                string addSkillMessage = skill + " has been added to your skills";

                Assert.That(displayedMessage, Is.EqualTo(addSkillMessage)
                    .Or.EqualTo(AddInvalidSkillMessage)
                    .Or.EqualTo(AddExsistingSkillMessage)
                    .Or.EqualTo(AddDuplicateSkillMessage));

                if ((displayedMessage == AddInvalidSkillMessage) ||
                    (displayedMessage == AddExsistingSkillMessage) ||
                    (displayedMessage == AddDuplicateSkillMessage))
                {
                    test.Pass("Entered invalid skill data: " + displayedMessage);
                    cancelButton = driver.FindElement(cancelButtonLocator);
                    cancelButton.Click();
                }
                else if (displayedMessage == addSkillMessage)
                {
                    test.Pass("Skill added successfully: " + displayedMessage);
                }
                else
                {
                    test.Fail("Skill add failed or unexpected message: " + displayedMessage);
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }

        }

        public void EditSkillsAssertions(string skill, ExtentTest test)
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 10);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                string editSkillMessage = skill + " has been updated to your skills";

                Assert.That(displayedMessage, Is.EqualTo(editSkillMessage)
                    .Or.EqualTo(AddInvalidSkillMessage)
                    .Or.EqualTo(EditAsExsistingSkillMessage)
                    .Or.EqualTo(AddDuplicateSkillMessage));

                if ((displayedMessage == AddInvalidSkillMessage) ||
                    (displayedMessage == EditAsExsistingSkillMessage) ||
                    (displayedMessage == AddDuplicateSkillMessage))
                {
                    test.Pass("Entered invalid skill data: " + displayedMessage);
                    cancelButton = driver.FindElement(cancelButtonLocator);
                    cancelButton.Click();
                }
                else if (displayedMessage == editSkillMessage || displayedMessage.Contains("updated to your skills"))
                {
                    test.Pass("Skill edit successful: " + displayedMessage);
                }
                else
                {
                    test.Fail("Skill edit failed or unexpected message: " + displayedMessage);
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }
        }

        public void DeleteSkillsAssertions(string skill, ExtentTest test)
        {
            try
            {
                Wait.WaitToBeVisible(driver, toastMessageLocator, 10);
                toastMessage = driver.FindElement(toastMessageLocator);

                string displayedMessage = toastMessage.Text;
                Console.WriteLine(displayedMessage);

                string deleteSkillMessage = skill + " has been deleted";

                Assert.That(displayedMessage, Is.EqualTo(deleteSkillMessage));

                if (displayedMessage == deleteSkillMessage)
                {
                    test.Pass("Skill deleted successfully: " + displayedMessage);
                }
                else
                {
                    test.Fail("Skill delete failed or unexpected message: " + displayedMessage);
                }
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new Exception("Toast message did not appear in the expected time.", ex);
            }
        }
    }
}
