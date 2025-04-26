using CompetionTaskMars.Helpers;
using CompetionTaskMars.Utilities;
using NUnit.Framework;
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
        private static readonly By languageDeleteButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");
        private static readonly By skillDeleteButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");
        private static readonly By skillsTabLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]");
        private static readonly By educationTabLocator = By.XPath("//A[@class = 'item'][text() = 'Education']");
        private static readonly By certificationsTabLocator = By.XPath("//A[@class = 'item'][text() = 'Certifications']");


        private static IWebElement languageDeleteButton;
        private static IWebElement skillDeleteButton;
        private static IWebElement languagesTab;
        private static IWebElement skillsTab;
        private static IWebElement educationTab;
        private static IWebElement certificationsTab;

        public void ProfileTabComponentsRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, languagesTabLocator, 2);
                languagesTab = driver.FindElement(languagesTabLocator);

                Wait.WaitToBeClickable(driver, skillsTabLocator, 2);
                skillsTab = driver.FindElement(skillsTabLocator);

                Wait.WaitToBeClickable(driver, educationTabLocator, 2);
                educationTab = driver.FindElement(educationTabLocator);

                Wait.WaitToBeClickable(driver, certificationsTabLocator, 2);
                certificationsTab = driver.FindElement(certificationsTabLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Profile tabs not located: " + ex.Message);
            }
        }

        public void ClickLangaugesTab()
        {
            ProfileTabComponentsRendering();
            languagesTab.Click();
        }

        public void ClickSkillsTab()
        {
            ProfileTabComponentsRendering();
            skillsTab.Click();

        }

        public void LanguageDeleteButtonRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, languageDeleteButtonLocator, 3);

                languageDeleteButton = driver.FindElement(languageDeleteButtonLocator);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No existing records");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Button Not Located");
            }
        }

        public void SkillDeleteButtonRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, skillDeleteButtonLocator, 3);

                skillDeleteButton = driver.FindElement(skillDeleteButtonLocator);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No existing records");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Button Not Located");
            }
        }
        public void RemoveAddedLanguageDetails()
        {
           

            IList<IWebElement> languageDeleteButton;
            do
            {
                LanguageDeleteButtonRendering();
                languageDeleteButton = driver.FindElements(languageDeleteButtonLocator);

                if (languageDeleteButton.Count > 0)
                {

                    Wait.WaitToBeClickable(driver, languageDeleteButtonLocator, 2);
                    try
                    {
                        languageDeleteButton[0].Click();
                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Language Delete Button not located or couldn't be clicked: " + ex.Message);
                    }
                    driver.Navigate().Refresh();                  
                    Thread.Sleep(2000);

                }
            } while (languageDeleteButton.Count > 0);
        }

        public void RemoveAddedSkillsDetails()
        {


            IList<IWebElement> skillDeleteButton;
            do
            {
                SkillDeleteButtonRendering();
                skillDeleteButton = driver.FindElements(skillDeleteButtonLocator);

                if (skillDeleteButton.Count > 0)
                {

                    Wait.WaitToBeClickable(driver, skillDeleteButtonLocator, 3);
                    try
                    {
                        skillDeleteButton[0].Click();
                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Skill Delete Button not located or couldn't be clicked: " + ex.Message);
                    }
                    driver.Navigate().Refresh();
                    ProfileTabComponentsRendering();
                    skillsTab.Click();
                    Thread.Sleep(2000);

                }
            } while (skillDeleteButton.Count > 0);
        }

    }
}
