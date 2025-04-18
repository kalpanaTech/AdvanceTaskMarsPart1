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
    public class ProfileMenuTabsComponents : Driver
    {

        private static readonly By languagesTabLocator = By.XPath("//A[@class='item active'][text()='Languages']");
        private static IWebElement languagesTab;
        public void ProfileTabComponentsRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, languagesTabLocator, 2);
                languagesTab = driver.FindElement(languagesTabLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Languages tab not located: " + ex.Message);
            }
        }

        public void ClickLangaugesTab()
        {
            ProfileTabComponentsRendering();
            languagesTab.Click();
        }
    }
}
