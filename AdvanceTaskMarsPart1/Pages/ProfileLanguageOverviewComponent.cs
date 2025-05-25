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

        private static readonly By editNewLanguageButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        private static readonly By editLanguageTextboxLocator = By.XPath("//input[@placeholder='Add Language']");
        private static readonly By editSelectLanguageLevelOptionLocator = By.Name("level");
        private static readonly By updateLanguageButtonLocator = By.XPath("//input[@value='Update']");

        private static readonly By deleteLanguageButtonLocator = By.XPath("//i[@class='remove icon']");
        private static readonly By messageWindowLocator = By.XPath("//div[@class='ns-box-inner']");
        private static readonly By messageCloseIconLocator = By.XPath("//*[@class='ns-close']");


        private static IWebElement addNewLanguageButton;
        private static IWebElement languageTextbox;
        private static IWebElement selectLanguageLevelOption;
        private static IWebElement addLanguageButton;
        private static IWebElement editNewLanguageButton;
        private static IWebElement editLanguageTextbox;
        private static IWebElement editSelectLanguageLevelOption;
        private static IWebElement updateLanguageButton;
        private static IWebElement deleteLanguageButton;
        private static IWebElement messageWindow;
        private static IWebElement messageCloseIcon;




        public void LanguageButtonsRendering()
        {
            Wait.WaitToBeClickable(driver, addNewLanguageButtonLocator, 3);
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
        public void EditIconComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, editNewLanguageButtonLocator, 2);
                editNewLanguageButton = driver.FindElement(editNewLanguageButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Edit new language button not located: " + ex.Message);
            }
        }

        public void EditLangComponentsRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, editLanguageTextboxLocator, 2);
                editLanguageTextbox = driver.FindElement(editLanguageTextboxLocator);

                Wait.WaitToBeVisible(driver, editSelectLanguageLevelOptionLocator, 2);
                editSelectLanguageLevelOption = driver.FindElement(editSelectLanguageLevelOptionLocator);

                Wait.WaitToBeClickable(driver, updateLanguageButtonLocator, 2);
                updateLanguageButton = driver.FindElement(updateLanguageButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Edit language components not located: " + ex.Message);
            }
        }

        public void DeleteIconComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, deleteLanguageButtonLocator, 2);
                deleteLanguageButton = driver.FindElement(deleteLanguageButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete language button not located: " + ex.Message);
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

        public string EditLanguageActions(string language, string languageLevel)
        {
            EditIconComponentRendering();
            editNewLanguageButton.Click();

            EditLangComponentsRendering();
            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys(language);
            editSelectLanguageLevelOption.Click();
            editSelectLanguageLevelOption.SendKeys(languageLevel);
            updateLanguageButton.Click();

            return language;
        }

        public void DeleteLanguageActions(string language, string languageLevel)
        {
            DeleteIconComponentRendering();
            deleteLanguageButton.Click();
        }
    }
}
