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
    public class ProfileLanguageOverviewComponent : Driver
    {
        private static readonly By addNewLanguageButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        private static readonly By languageTextboxLocator = By.XPath("//input[@type='text'][@placeholder='Add Language']");
        private static readonly By selectLanguageLevelOptionLocator = By.Name("level");
        private static readonly By addLanguageButtonLocator = By.XPath("//input[@value='Add']");
        
        private static IWebElement addNewLanguageButton;
        private static IWebElement languageTextbox;
        private static IWebElement selectLanguageLevelOption;
        private static IWebElement addLanguageButton;
        
        
        public void LanguageButtonsRendering()
        {
            Wait.WaitToBeClickable(driver, addNewLanguageButtonLocator, 2);
            addNewLanguageButton = driver.FindElement(addNewLanguageButtonLocator);
        }

        public void AddLanguageComponentsRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, languageTextboxLocator, 2);
                languageTextbox = driver.FindElement(languageTextboxLocator);

                Wait.WaitToBeVisible(driver, selectLanguageLevelOptionLocator, 2);
                selectLanguageLevelOption = driver.FindElement(selectLanguageLevelOptionLocator);

                Wait.WaitToBeClickable(driver, addLanguageButtonLocator, 2);
                addLanguageButton = driver.FindElement(addLanguageButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add language components not located: " + ex.Message);
            }
        }

       

        public void AddLanguageActions(string language, string languageLevel)
        {
            LanguageButtonsRendering();
            addNewLanguageButton.Click();

            AddLanguageComponentsRendering();
            languageTextbox.SendKeys(language);
            selectLanguageLevelOption.Click();
            selectLanguageLevelOption.SendKeys(languageLevel);
            addLanguageButton.Click();
        }

       
    }
}
