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
    public class NotificationOverviewComponent : Driver
    {
        
        private static readonly By showMoreOptionLocator = By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a");
        private static readonly By showLessOptionLocator = By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a");
        private static readonly By selectAllOptionLocator = By.XPath(" //i[@class='mouse pointer icon']");
        private static readonly By unSelectAllOptionLocator = By.XPath("//div[@data-tooltip='Unselect all']");
        private static readonly By markAsReadOptionLocator = By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]/i");
        private static readonly By removeIconLocator = By.XPath("//i[@class='trash icon']");
        private static readonly By selectCheckBoxLocator = By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input");

        
        private static IWebElement showMoreOption;
        private static IWebElement showLessOption;
        private static IWebElement selectAllOption;
        private static IWebElement unSelectAllOption;
        private static IWebElement markAsReadOption;
        private static IWebElement removeIcon;
        private static IWebElement selectCheckBox;

        public void ShowMoreNotificationRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, showMoreOptionLocator, 5);
                showMoreOption = driver.FindElement(showMoreOptionLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Show more option not located: " + ex.Message);
            }
        }

        public void ShowLessNotificationRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, showLessOptionLocator, 5);
                showLessOption = driver.FindElement(showLessOptionLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Show less option not located: " + ex.Message);
            }
        }

        public void SelectNotificationRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, selectAllOptionLocator, 3);
                selectAllOption = driver.FindElement(selectAllOptionLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Select all option not located: " + ex.Message);
            }
        }

        public void UnselectNotificationRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, unSelectAllOptionLocator, 3);
                unSelectAllOption = driver.FindElement(unSelectAllOptionLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unselect all option not located: " + ex.Message);
            }
        }

        public void SelectCheckBoxRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, selectCheckBoxLocator, 3);
                selectCheckBox = driver.FindElement(selectCheckBoxLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Select checkbox not located: " + ex.Message);
            }
        }


        public void MarkAsReadNotificationRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, markAsReadOptionLocator, 3);
                markAsReadOption = driver.FindElement(markAsReadOptionLocator);


            }
            catch (Exception ex)
            {
                Console.WriteLine("MarkAsRead notification element not located: " + ex.Message);
            }
        }
        public void DeleteNotificationRendering()
        {
            try
            {
                Wait.WaitToBeClickable(driver, markAsReadOptionLocator, 3);
                markAsReadOption = driver.FindElement(markAsReadOptionLocator);

                Wait.WaitToBeClickable(driver, removeIconLocator, 3);
                removeIcon = driver.FindElement(removeIconLocator);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete notification element not located: " + ex.Message);
            }
        }
        public bool SelectAllNotification()
        {
            SelectNotificationRendering();
            selectAllOption.Click();
            return true;
        }

        public bool UnSelectAllNotification()
        {
            SelectNotificationRendering();
            selectAllOption.Click();
            UnselectNotificationRendering();
            Wait.WaitToBeClickable(driver, unSelectAllOptionLocator, 5);
            unSelectAllOption.Click();
            return true;
        }

       
        public bool LoadMoreNotification()
        {
            ShowMoreNotificationRendering();
            showMoreOption.Click();
            return true;
        }

        public bool ShowLessNotification()
        {
            SelectNotificationRendering();
            selectAllOption.Click();
            ShowMoreNotificationRendering();
            showMoreOption.Click();
            ShowLessNotificationRendering();
            showLessOption.Click();
            return true;
        }

        public void MarkAsReadNotification()
        {
            SelectNotificationRendering();
            selectAllOption.Click();
            MarkAsReadNotificationRendering();
            Wait.WaitToBeClickable(driver, markAsReadOptionLocator, 3);
            markAsReadOption.Click();
        }

        public void NotificationDeletion()
        {
            SelectCheckBoxRendering();
            selectCheckBox.Click();
            DeleteNotificationRendering();
            Wait.WaitToBeClickable(driver, removeIconLocator, 3);
            removeIcon.Click();
        }


        

    }
}
