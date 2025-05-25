using CompetionTaskMars.Helpers;
using CompetionTaskMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Pages
{
    public class HomePage : Driver
    {

        private static readonly By profileTabLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        private static readonly By notificationLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div");
        private static readonly By dashboardNotificationLocator = By.LinkText("Dashboard");
        private static readonly By searchSkillLocator = By.XPath("//i[@class='search link icon']");
        private static readonly By shareSkillLocator = By.XPath("//a[contains(text(),'Share Skill')]");
        private static readonly By userCheckingLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span");

        private static IWebElement notification;
        private static IWebElement dashboardNotification;
        private static IWebElement profileTab;
        private static IWebElement searchSkill;
        private static IWebElement shareSkill;
        private static IWebElement userChecking;

        public void ProfileTabComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, profileTabLocator, 3);
                profileTab = driver.FindElement(profileTabLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Profile tab not located: " + ex.Message);
            }
        }

        public void NotificationComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, notificationLocator, 3);
                notification = driver.FindElement(notificationLocator);

                Wait.WaitToBeClickable(driver, dashboardNotificationLocator, 3);
                dashboardNotification = driver.FindElement(dashboardNotificationLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Notification option not located: " + ex.Message);
            }
        }
        public void SearchSkillComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, searchSkillLocator, 3);
                searchSkill = driver.FindElement(searchSkillLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search skill option not located: " + ex.Message);
            }
        }

        public void ShareSkillComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, shareSkillLocator, 3);
                shareSkill = driver.FindElement(shareSkillLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Share skill button not located: " + ex.Message);
            }
        }
       

        public void ProfileTabClick()
        {
            ProfileTabComponentRendering();
            profileTab.Click();
        }
        public void NotificationClick()
        {
            NotificationComponentRendering();
            notification.Click();
            dashboardNotification.Click();
        }
        public void SearchSkillClick()
        {
            SearchSkillComponentRendering();
            searchSkill.Click();
        }
        public void ShareSkillClick()
        {
            ShareSkillComponentRendering();
            shareSkill.Click();
        }
        
    }
}
