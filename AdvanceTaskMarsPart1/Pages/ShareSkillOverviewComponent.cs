using AdvanceTaskMarsPart1.Model;
using CompetionTaskMars.Helpers;
using CompetionTaskMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Pages
{
    public class ShareSkillOverviewComponent : Driver
    {
        private static readonly By shareSkillLocator = By.XPath("//a[contains(text(),'Share Skill')]");
        private static readonly By titleLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
        private static readonly By descriptionLocator = By.Name("description");
        private static readonly By categoryLocator = By.Name("categoryId");
        private static readonly By subcategoryLocator = By.Name("subcategoryId");
        private static readonly By tagLocator = By.CssSelector("input[placeholder='Add new tag']");

        private static readonly By calandarLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div/div[1]/ul[1]/li[4]/a/span[3]");
        private static readonly By startDateLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div/div[1]/ul[1]/li[1]/a");     
        private static readonly By skillExchangeLocator = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input");     
        private static readonly By saveButtonLocator = By.XPath("//input[@value='Save']");

        private static IWebElement shareSkill;
        private static IWebElement title;
        private static IWebElement description;
        private static IWebElement category;
        private static IWebElement subcategory;
        private static IWebElement tag;
        private static IReadOnlyList<IWebElement> serviceType;
        private static IReadOnlyList<IWebElement> locationType;
        private static IWebElement calandar;
        private static IWebElement startDate;
        private static IReadOnlyList<IWebElement> skillTrade;
        private static IWebElement skillExchange;
        private static IWebElement credit;
        private static IReadOnlyList<IWebElement> active;
        private static IWebElement saveButton;

        string serviceTypeHourly = "Hourly basis service";
        string serviceTypeOneOff = "One - off service";
        string locationOnSite = "On-site";
        string skillExchangeTrade = "Skill-exchange";
        string creditTrade = "Credit";
        string activeStatusActive = "Active";

        public void AddShareSkills(ShareSkillCredentials credentials)
        {
            ShareSkillComponentRendering();
            shareSkill.Click();

            TitleRendering();
            title.SendKeys(credentials.Title);
            DescriptionRendering();
            description.SendKeys(credentials.Description);

            CategoryComponentRendering();
            category.Click();
            category.SendKeys(credentials.Category);
            category.Click();

            SubCategoryComponentRendering();
            subcategory.Click();
            subcategory.SendKeys(credentials.SubCategory);

            TagComponentRendering();
            tag.Click();
            tag.SendKeys(credentials.Tags);
            tag.SendKeys("\n");
            

            ServiceTypeRendering();

            if (credentials.ServiceType == serviceTypeHourly)
            {
                serviceType.ElementAt(0).Click();
            }
            else
            {
                serviceType.ElementAt(1).Click();
            }


            LocationTypeRendering();
            if (credentials.LocationType == locationOnSite)
            {
                locationType.ElementAt(0).Click();
            }
            else
            {
                locationType.ElementAt(1).Click();
            }

            CalandarRendering();
            calandar.Click();
            startDate.Click();
            

            SkillTradeRendering();
            if (credentials.SkillTrade == skillExchangeTrade)
            {
                skillTrade.ElementAt(0).Click();
                SkillExchangeComponentRendering();
                skillExchange.Click();
                skillExchange.SendKeys(credentials.SkillExchange);
                skillExchange.SendKeys("\n");
            }
            else if (credentials.SkillTrade == creditTrade)
            {
                skillTrade.ElementAt(1).Click();
                SkillTradeCreditComponentRendering();
                credit.Click();
                credit.SendKeys(credentials.Credit);
            }

            ActiveComponentRendering();
            if (credentials.Active == activeStatusActive)
            {
                active.ElementAt(0).Click();
            }
            else
            {
                active.ElementAt(1).Click();
            }

            SaveButtonRendering();
            saveButton.Click();
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
                Console.WriteLine("Share skill not located: " + ex.Message);
            }
        }

        public void TitleRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, titleLocator, 2);
                title = driver.FindElement(titleLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Title not located: " + ex.Message);
            }
        }

        public void DescriptionRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, descriptionLocator, 2);
                description = driver.FindElement(descriptionLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Description not located: " + ex.Message);
            }
        }

        public void CategoryComponentRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, categoryLocator, 2);
                category = driver.FindElement(categoryLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Category not located: " + ex.Message);
            }
        }

        public void SubCategoryComponentRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, subcategoryLocator, 2);
                subcategory = driver.FindElement(subcategoryLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Subcategory not located: " + ex.Message);
            }
        }

        public void TagComponentRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, tagLocator, 2);
                tag = driver.FindElement(tagLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tag not located: " + ex.Message);
            }
        }

        public void ServiceTypeRendering()
        {
            try
            {

                serviceType = driver.FindElements(By.Name("serviceType"));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Service type not located: " + ex.Message);
            }
        }

        public void LocationTypeRendering()
        {
            try
            {
                locationType = driver.FindElements(By.Name("locationType"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Location type not located: " + ex.Message);
            }
        }

        public void CalandarRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, calandarLocator, 2);
                calandar = driver.FindElement(calandarLocator);

                Wait.WaitToBeVisible(driver, startDateLocator, 2);
                startDate = driver.FindElement(startDateLocator);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Start date not located: " + ex.Message);
            }
        }
       
        public void SkillTradeRendering()
        {
            try
            {
                
                skillTrade = driver.FindElements(By.Name("skillTrades"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Skill trade not located: " + ex.Message);
            }
        }

        public void SkillExchangeComponentRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, skillExchangeLocator, 2);
                skillExchange = driver.FindElement(skillExchangeLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Skill exchange not located: " + ex.Message);
            }
        }

        public void SkillTradeCreditComponentRendering()
        {
            try
            {
                
                credit = driver.FindElement(By.Name("charge"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Credit not located: " + ex.Message);
            }
        }

        public void ActiveComponentRendering()
        {
            try
            {
               
                active = driver.FindElements(By.Name("isActive"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Active status not located: " + ex.Message);
            }
        }

        public void SaveButtonRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, saveButtonLocator, 2);
                saveButton = driver.FindElement(saveButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save button not located: " + ex.Message);
            }
        }
    }

}

