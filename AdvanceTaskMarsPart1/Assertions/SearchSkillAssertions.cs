using AventStack.ExtentReports;
using CompetionTaskMars.Helpers;
using CompetionTaskMars.Tests;
using CompetionTaskMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Assertions
{
    public class SearchSkillAssertions : Hooks
    {
        private static readonly By verifySkillLocator = By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]/a[2]");
        private static readonly By categoryLocator = By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]");
        private static readonly By subCategoryLocator = By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]");
        private static readonly By filterLocator = By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]");

        private static IWebElement verifySkill;
        private static IWebElement category;
        private static IWebElement subCategory;
        private static IWebElement filter;

        static string verifyCategory;
        static string verifySubCategory;
        static string verifyFilter;

        private void InitializeSearchedSkill()
        {
            try
            {
                Wait.WaitToBeClickable(driver, verifySkillLocator, 3);
                verifySkill = driver.FindElement(verifySkillLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error initializing searched skill: " + ex.Message);
            }
        }
        private void InitializeSearchedSkillElements() 
        {
            try
            {
                Wait.WaitToBeVisible(driver, categoryLocator, 3);
                category = driver.FindElement(categoryLocator);

                Wait.WaitToBeVisible(driver, subCategoryLocator, 3);
                subCategory = driver.FindElement(subCategoryLocator);

                Wait.WaitToBeVisible(driver, filterLocator, 3);
                filter = driver.FindElement(filterLocator);
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error initializing elements: " + ex.Message);
            }
        }

        public void VerifySearchSkillWithAllCategories(string categoryName)
        {
            try
            {

                InitializeSearchedSkill();
                verifySkill.Click();
               
                
                InitializeSearchedSkillElements();
                verifyCategory = category.Text;
                
                if (verifyCategory == categoryName)
                {
                    test.Pass("SearchSkill By Category Successful");
                    Console.WriteLine("SearchSkill By Category Successful");
                }
                else
                {
                    test.Pass("Searched skill does not exist");
                    Console.WriteLine("Searched skill does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error verifying category search: " + ex.Message);
            }
        }

        public void VerifySearchSkillWithSubCategories(string subCategoryName)
        {
            try
            {
                InitializeSearchedSkill();
                verifySkill.Click();

                InitializeSearchedSkillElements();
                verifySubCategory = subCategory.Text;

                if (verifySubCategory == subCategoryName)
                {
                    test.Pass("SearchSkill By Subcategory Successful");
                    Console.WriteLine("SearchSkill By Subcategory Successful");
                }
                else
                {
                    test.Pass("Searched skill does not exist");
                    Console.WriteLine("Searched skill does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error verifying subcategory search: " + ex.Message);
            }
        }

        public void VerifySearchSkillWithFilter(string filterName)
        {
            try
            {
                InitializeSearchedSkill();
                verifySkill.Click();

                InitializeSearchedSkillElements();
                verifyFilter = filter.Text;

                if (verifyFilter == filterName)
                {
                    test.Pass("SearchSkill By Filter Successful");
                    Console.WriteLine("SearchSkill By Filter Successful");
                }
                else
                {
                    test.Pass("Searched filter does not exist");
                    Console.WriteLine("Searched filter does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error verifying filter search: " + ex.Message);
            }
        }
    }
}
