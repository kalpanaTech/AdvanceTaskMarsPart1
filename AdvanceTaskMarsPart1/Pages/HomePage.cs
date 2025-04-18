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
    public class HomePage : Driver
    {

        private static readonly By profileTabLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        private static IWebElement profileTab;

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

        public void ProfileTabClick()
        {
            ProfileTabComponentRendering();
            profileTab.Click();
        }
    }
}
