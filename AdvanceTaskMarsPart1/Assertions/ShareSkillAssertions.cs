using AventStack.ExtentReports;
using CompetionTaskMars.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetionTaskMars.Tests;
using CompetionTaskMars.Utilities;

namespace AdvanceTaskMarsPart1.Assertions
{
    public class ShareSkillAssertions : Hooks
    {
              
        private static readonly By ToastMessageLocator = By.XPath("//div[@class='ns-box-inner']");
        private static readonly By NewShareSkillLocator = By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]");
        private static IWebElement ToastMessage => driver.FindElement(ToastMessageLocator);
        private static IWebElement NewShareSkill => driver.FindElement(NewShareSkillLocator);
        
        private static string addedSkill;
        private static string invalidSkillShare = "Please complete the form correctly.";

        public void AddShareSkillAssertions(string title)
        {
            Wait.WaitToBeVisible(driver, NewShareSkillLocator, 5);
            addedSkill = NewShareSkill.Text;
            Assert.That(addedSkill, Is.EqualTo(title), "The added skill title does not match the expected value.");
            test.Pass("Skill shared successfully");
            Console.WriteLine("Skill shared Successfully");
        }

        public void IncompleteShareSkillAssertions()
        {
            Wait.WaitToBeVisible(driver, ToastMessageLocator, 5);
            string displayedMessage = ToastMessage.Text;
            Assert.That(displayedMessage, Is.EqualTo(invalidSkillShare), "The error message does not match the expected validation message.");
            test.Pass("Complete the share skill form correctly");
            Console.WriteLine("Skill shared Unuccessful. Complete the form.");
        }

    }
}
