using CompetionTaskMars.Helpers;
using CompetionTaskMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Pages
{
    public class ProfileUserDetailOverviewComponent : Driver
    {
      
        private static readonly By availableTimeEditIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
        private static readonly By availableHoursEditIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i");
        private static readonly By earnTargetEditIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i");

        private static readonly By availableTimeLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select");
        private static readonly By availableHoursLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select");
        private static readonly By earnTargetLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select");

        
        private IWebElement availableTimeEditIcon;
        private IWebElement availableHoursEditIcon;
        private IWebElement earnTargetEditIcon;
        private IWebElement availableTime;
        private IWebElement availableHours;
        private IWebElement earnTarget;

        public void AvailableTimeRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, availableTimeLocator, 5);
                availableTime = driver.FindElement(availableTimeLocator);
            }
            catch (Exception)
            {
                Console.WriteLine("Available time not located");
            }
        }

        public void AvailableHoursRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, availableHoursLocator, 5);
                availableHours = driver.FindElement(availableHoursLocator);
            }
            catch (Exception)
            {
                Console.WriteLine("Available hours not located");
            }
        }

        public void EarnTargetRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, earnTargetLocator, 5);
                earnTarget = driver.FindElement(earnTargetLocator);
            }
            catch (Exception)
            {
                Console.WriteLine("Earn target not located");
            }
        }
        public void UseDetailEditIconsRendering()
        {
            Wait.WaitToBeClickable(driver, availableTimeEditIconLocator, 5);
            availableTimeEditIcon = driver.FindElement(availableTimeEditIconLocator);
            availableHoursEditIcon = driver.FindElement(availableHoursEditIconLocator);
            earnTargetEditIcon = driver.FindElement(earnTargetEditIconLocator);
        }

        

        public void UpdateAvailableTime(string userAvailableTime)
        {
            UseDetailEditIconsRendering();
            availableTimeEditIcon.Click();

            AvailableTimeRendering();
            availableTime.Click();
            availableTime.SendKeys(userAvailableTime);

            AvailableTimeRendering(); 
            Wait.WaitToBeClickable(driver, availableTimeLocator, 5);
            availableTime.Click();
        }

        public void UpdateAvailableHours(string userAvailableHours)
        {
            UseDetailEditIconsRendering();
            availableHoursEditIcon.Click();

            AvailableHoursRendering();
            availableHours.Click();
            availableHours.SendKeys(userAvailableHours);

            AvailableHoursRendering();
            Wait.WaitToBeClickable(driver, availableHoursLocator, 5);
            availableHours.Click();
        }

        public void UpdateEarnTarget(string userEarnTarget)
        {
            UseDetailEditIconsRendering();
            earnTargetEditIcon.Click();

            EarnTargetRendering();
            earnTarget.Click();
            earnTarget.SendKeys(userEarnTarget);

            EarnTargetRendering();
            Wait.WaitToBeClickable(driver, earnTargetLocator, 5);
            earnTarget.Click();
        }
    }
}
