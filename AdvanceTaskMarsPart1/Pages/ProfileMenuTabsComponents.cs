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
        private static IWebElement languagesTab;

        private static readonly By deleteButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i");
        private static IWebElement deleteButton;
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

        public void DeleteButtonRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, deleteButtonLocator, 3);

                deleteButton = driver.FindElement(deleteButtonLocator);
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
           

            IList<IWebElement> deleteButton;
            do
            {
                DeleteButtonRendering();
                deleteButton = driver.FindElements(deleteButtonLocator);

                if (deleteButton.Count > 0)
                {

                    Wait.WaitToBeClickable(driver, deleteButtonLocator, 2);
                    try
                    {
                        deleteButton[0].Click();
                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Delete Button not located or couldn't be clicked: " + ex.Message);
                    }
                    driver.Navigate().Refresh();
                    Thread.Sleep(2000);

                }
            } while (deleteButton.Count > 0);
        }

    }
}
