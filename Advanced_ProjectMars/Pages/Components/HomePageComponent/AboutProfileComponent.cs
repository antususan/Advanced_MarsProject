using Advanced_ProjectMars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.HomePageComponent
{
    public class AboutProfileComponent : CommonDriver
    {

        private IWebElement availabilityEditButton;
        private IWebElement selectavailability;
        private IWebElement hoursEditButton;
        private IWebElement selecthours;
        private IWebElement earnTargetEditButton;
        private IWebElement selectearnTarget;
        private IWebElement newAvailability;
        private IWebElement newHours;
        private IWebElement newEarnTarget;


        public void RenderAvailabilityEditButton()
        {
            
            availabilityEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        }
        public void RenderHoursEditButton()
        {
            hoursEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        }

        public void RenderEarnTargetEditButton()
        {
            earnTargetEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        }
        public void RenderUpdateAvailability()
        {
            selectavailability = driver.FindElement(By.Name("availabiltyType"));
        }
        public void RenderUpdateHours()
        {
            selecthours = driver.FindElement(By.Name("availabiltyHour"));
        }
        public void RenderUpdateEarnTarget()
        {
            selectearnTarget = driver.FindElement(By.Name("availabiltyTarget"));
        }
           
    

        public void RenderAssert()
        {
            Thread.Sleep(1000);
            newAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            newHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            newEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
        }


        public void UpdateAboutProfileUsingValidData(string availability, string hours, string earntarget)
        {
            Thread.Sleep(1000);
            RenderAvailabilityEditButton();
            availabilityEditButton.Click();
            RenderUpdateAvailability();
            Thread.Sleep(3000);
            SelectElement availabilityDropdown = new SelectElement(selectavailability);
            availabilityDropdown.SelectByText(availability);
            Thread.Sleep(1000);
            RenderHoursEditButton();
            hoursEditButton.Click();
            RenderUpdateHours();
            SelectElement hoursDropdown = new SelectElement(selecthours);
            hoursDropdown.SelectByText(hours);
            Thread.Sleep(3000);
            RenderEarnTargetEditButton();
            earnTargetEditButton.Click();
            RenderUpdateEarnTarget();
            SelectElement earnTargetDropdown = new SelectElement(selectearnTarget);
            earnTargetDropdown.SelectByText(earntarget);
            //selectearnTarget.Click();
            Thread.Sleep(3000);

        }
  
        public string AssertAvailability()
        {

            RenderAssert();
            return newAvailability.Text;
        }
        public string AssertHours()
        {
            RenderAssert();
            return newHours.Text;


        }
        public string AssertEarnTarget()
        {
            RenderAssert();
            return newEarnTarget.Text;

        }
    }
}
