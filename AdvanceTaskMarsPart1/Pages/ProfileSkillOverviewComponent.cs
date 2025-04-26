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
    public class ProfileSkillOverviewComponent : Driver
    {
       
        private static readonly By addNewSkillButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div");
        private static readonly By addSkillTextboxLocator = By.XPath("//input[@type='text'][@placeholder='Add Skill']");
        private static readonly By addSkillLevelDropdownLocator = By.Name("level");
        private static readonly By addSkillButtonLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]");

        private static readonly By editNewSkillIconLocator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");
        private static readonly By editSkillTextboxLocator = By.XPath("//input[@placeholder='Add Skill']");
        private static readonly By editSkillLevelDropdownLocator = By.Name("level");
        private static readonly By updateSkillButtonLocator = By.XPath("//input[@value='Update']");

        private static readonly By deleteSkillIconLocator = By.XPath("//i[@class='remove icon']");

        
        private static IWebElement addNewSkillButton;
        private static IWebElement addSkillTextbox;
        private static IWebElement addSkillLevelDropdown;
        private static IWebElement addSkillButton;

        private static IWebElement editNewSkillIcon;
        private static IWebElement editSkillTextbox;
        private static IWebElement editSkillLevelDropdown;
        private static IWebElement updateSkillButton;

        private static IWebElement deleteSkillIcon;

        
        public void SkillButtonRendering()
        {
            
            Wait.WaitToBeVisible(driver, addNewSkillButtonLocator, 5);
            addNewSkillButton = driver.FindElement(addNewSkillButtonLocator);
        }

        public void AddSkillComponentsRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, addSkillTextboxLocator, 2);
                addSkillTextbox = driver.FindElement(addSkillTextboxLocator);

                Wait.WaitToBeVisible(driver, addSkillLevelDropdownLocator, 2);
                addSkillLevelDropdown = driver.FindElement(addSkillLevelDropdownLocator);

                Wait.WaitToBeClickable(driver, addSkillButtonLocator, 2);
                addSkillButton = driver.FindElement(addSkillButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add skill components not located: " + ex.Message);
            }
        }

        public void EditIconComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, editNewSkillIconLocator, 2);
                editNewSkillIcon = driver.FindElement(editNewSkillIconLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Edit skill icon not located: " + ex.Message);
            }
        }

        public void EditSkillComponentsRendering()
        {
            try
            {
                Wait.WaitToBeVisible(driver, editSkillTextboxLocator, 2);
                editSkillTextbox = driver.FindElement(editSkillTextboxLocator);

                Wait.WaitToBeVisible(driver, editSkillLevelDropdownLocator, 2);
                editSkillLevelDropdown = driver.FindElement(editSkillLevelDropdownLocator);

                Wait.WaitToBeClickable(driver, updateSkillButtonLocator, 2);
                updateSkillButton = driver.FindElement(updateSkillButtonLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Edit skill components not located: " + ex.Message);
            }
        }

        public void DeleteIconComponentRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, deleteSkillIconLocator, 2);
                deleteSkillIcon = driver.FindElement(deleteSkillIconLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete skill icon not located: " + ex.Message);
            }
        }

        
        public void AddSkillsActions(string skills, string skillLevel)
        {
            SkillButtonRendering();
            addNewSkillButton.Click();

            AddSkillComponentsRendering();
            addSkillTextbox.SendKeys(skills);
            addSkillLevelDropdown.Click();
            addSkillLevelDropdown.SendKeys(skillLevel);
            addSkillButton.Click();
        }

        public void EditSkillsActions(string skills, string skillLevel)
        {
            EditIconComponentRendering();
            editNewSkillIcon.Click();

            EditSkillComponentsRendering();
            editSkillTextbox.Clear();
            editSkillTextbox.SendKeys(skills);
            editSkillLevelDropdown.Click();
            editSkillLevelDropdown.SendKeys(skillLevel);
            updateSkillButton.Click();
        }

        public void DeleteSkillsActions(string skills, string skillLevel)
        {
            DeleteIconComponentRendering();
            deleteSkillIcon.Click();
        }
    }
}
