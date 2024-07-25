using Advanced_ProjectMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.HomePageComponent
{
    public class NotificationComponent:CommonDriver
    {
        private IWebElement notificationButton;
        private IWebElement seeAllButton;
        private IWebElement loadMoreButton;
        private IWebElement showLessButton;
        private IWebElement selectAll;
        private IWebElement unSelectAll;
        private IWebElement markSelectAsRead;
        private IWebElement delete;
        private IWebElement popUpMessage;

        public void RenderNotificationButton()
        {
           
            notificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/i[1]"));

        }
        public void RenderSeeAllButton() 
        {
           
            seeAllButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center"));
        }
        public void RenderLoadMore()
        {
            Thread.Sleep(1000);
            loadMoreButton = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));
        }
        public void RenderShowLessButton()
        {
            Thread.Sleep(1000);
            showLessButton = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a"));
        }
        public void RenderSelectAll()
        {
            Thread.Sleep(1000);
            selectAll = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[1]/i"));
        }

        public void RenderAll()
        {
            unSelectAll = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]"));
            markSelectAsRead = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]"));
            delete = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]"));
        }
        public void RenderPopUpMessage()
        {
            Thread.Sleep(1000);
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }
       
        public void GotoNotificationTab()
        {
            Thread.Sleep(2000);
            RenderNotificationButton();
            notificationButton.Click();
            Thread.Sleep(3000);
            RenderSeeAllButton();
            seeAllButton.Click();
        }
        public void LoadMore()
        {
            RenderLoadMore();
            loadMoreButton.Click();
        }
        public string AssertLoadMore()
        {
            RenderShowLessButton();
            return showLessButton.Text;
        }

        public void ShowLess()
        {
            RenderShowLessButton();
            showLessButton.Click();
        }

        public string AssertShowLess()
        {
            RenderLoadMore();
            return loadMoreButton.Text;
        }

        public void SelectAll()
        {
            RenderSelectAll();
            selectAll.Click();
            Thread.Sleep(2000);
        }
        public bool AssertSelectAll()
        {

            IList<IWebElement> checkboxes = driver.FindElements(By.CssSelector("input[type='checkbox']"));

            // Assert all checkboxes are checked
            foreach (IWebElement checkbox in checkboxes)
            {
                if (!checkbox.Selected)
                {
                    return false;
                }
            }
            return true;

        }
        public void UnSelectAll()
        {
            RenderAll();
            unSelectAll.Click();
            Thread.Sleep(2000);

        }

        public bool AssertUnSelectAll()
        {

            IList<IWebElement> checkboxes = driver.FindElements(By.CssSelector("input[type='checkbox']"));

            // Assert all checkboxes are not checked
            foreach (IWebElement checkbox in checkboxes)
            {
                if (checkbox.Selected)
                {
                    return false;
                }
            }
            return true;


        }

        public void MarkSelectAsRead()
        {
            RenderAll();
            markSelectAsRead.Click();
        }

        public string PopUpMessage()
        {
            RenderPopUpMessage();
            return popUpMessage.Text;
            

        }

        public void Delete()
        {
            RenderAll();
            delete.Click();
        }
      

    }
}
