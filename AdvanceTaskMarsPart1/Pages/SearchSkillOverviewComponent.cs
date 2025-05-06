using AdvanceTaskMarsPart1.Model;
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
    public class SearchSkillOverviewComponent : Driver
    {
        private static readonly By searchSkillsIconLocator = By.XPath("//i[@class='search link icon']");
        private static readonly By searchSkillsTextBoxLocator = By.XPath("//input[@placeholder='Search skills']");
        private static readonly By onlineFilterButtonLocator = By.XPath("//button[contains(text(),'Online')]");
        private static readonly By onsiteFilterButtonLocator = By.XPath("//button[contains(text(),'Onsite')]");
        private static readonly By showAllFilterButtonLocator = By.XPath("//button[contains(text(),'ShowAll')]");
        private static readonly By allCategoryLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[1]/b");
        private static readonly By categoryAutomationLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[4]");
        private static readonly By subCategorySeleniumLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[5]");
        private static readonly By subCategoryCucumberLocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[6]");
        private static readonly By subCategoryAPILocator = By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[7]");

        private static IWebElement searchSkillsIcon;
        private static IWebElement searchSkillsTextBox;
        private static IWebElement onlineFilterButton;
        private static IWebElement onsiteFilterButton;
        private static IWebElement showAllFilterButton;
        private static IWebElement allCategory;
        private static IWebElement categoryAutomation;
        private static IWebElement subCategorySelenium;
        private static IWebElement subCategoryCucumber;
        private static IWebElement subCategoryAPI;

        public void searchSkillButtonRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, searchSkillsIconLocator, 3);
                searchSkillsIcon = driver.FindElement(searchSkillsIconLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search Skills Icon not located: " + ex.Message);
            }
        }

        public void searchSkillTextBoxRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, searchSkillsTextBoxLocator, 3);
                searchSkillsTextBox = driver.FindElement(searchSkillsTextBoxLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search Skills TextBox not located: " + ex.Message);
            }
        }

        public void filterRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, onlineFilterButtonLocator, 3);
                onlineFilterButton = driver.FindElement(onlineFilterButtonLocator);

                Wait.WaitToBeClickable(driver, onsiteFilterButtonLocator, 3);
                onsiteFilterButton = driver.FindElement(onsiteFilterButtonLocator);

                Wait.WaitToBeClickable(driver, showAllFilterButtonLocator, 3);
                showAllFilterButton = driver.FindElement(showAllFilterButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Filter buttons not located: " + ex.Message);
            }
        }
        public void AllCategoryElementsRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, allCategoryLocator, 3);
                allCategory = driver.FindElement(allCategoryLocator);

                Wait.WaitToBeVisible(driver, categoryAutomationLocator, 3);
                categoryAutomation = driver.FindElement(categoryAutomationLocator);
            }
            catch (Exception ex) {
                Console.WriteLine("All Category Elements not located: " + ex.Message);
            }
        }
        public void SubCategoryElementsRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, subCategorySeleniumLocator, 3);
                subCategorySelenium = driver.FindElement(subCategorySeleniumLocator);

                Wait.WaitToBeVisible(driver, subCategoryCucumberLocator, 3);
                subCategoryCucumber = driver.FindElement(subCategoryCucumberLocator);

                Wait.WaitToBeVisible(driver, subCategoryAPILocator, 3);
                subCategoryAPI = driver.FindElement(subCategoryAPILocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SubCategory Elements not located: " + ex.Message);
            }
        }


        public void SearchSkillWithAllCategories(SearchSkillCategoryCredentials credential)
        {
            try
            {
               
               
                searchSkillTextBoxRendering();
                searchSkillsTextBox.SendKeys(credential.Category);
                searchSkillButtonRendering();
                searchSkillsIcon.Click();              
                searchSkillButtonRendering();
                searchSkillsIcon.Click();

                // click specific category : Automation
                AllCategoryElementsRendering();
                allCategory.Click();
                categoryAutomation.Click(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while searching skill with all categories: " + ex.Message);
            }
        }

        public void SearchSkillWithSubCategories(SearchSkillSubCategoryCredentials credential)
        {
            try
            {
               

                searchSkillTextBoxRendering();
                searchSkillsTextBox.SendKeys(credential.SubCategory);
                searchSkillButtonRendering();
                searchSkillsIcon.Click();
                searchSkillButtonRendering();
                searchSkillsIcon.Click();

                // click specific sub category : Selenium
                AllCategoryElementsRendering();
                allCategory.Click();
                categoryAutomation.Click();
                SubCategoryElementsRendering();
                subCategorySelenium.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while searching skill with subcategories: " + ex.Message);
            }
        }

        public void SearchSkillWithFilters(SearchSkillFilterCredentials credential)
        {
            try
            {
             
                searchSkillTextBoxRendering();
                searchSkillsTextBox.SendKeys(credential.SkillCategory);
                searchSkillButtonRendering();
                searchSkillsIcon.Click();
                searchSkillButtonRendering();
                searchSkillsIcon.Click();
               


                filterRendering();
                if (credential.SkillFilterOption == "Online")
                {
                    onlineFilterButton.Click();
                }
                else if (credential.SkillFilterOption == "On-Site")
                {
                    onsiteFilterButton.Click();
                }
                else if (credential.SkillFilterOption == "ShowAll")
                {
                    showAllFilterButton.Click();
                }
                else
                {
                    Console.WriteLine("Invalid filter selected");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while searching skill with filters: " + ex.Message);
            }
        }
    }
}
