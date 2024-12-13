using Advanced_ProjectMars.Utilities;
using AventStack.ExtentReports.Model;
using MongoDB.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.HomePageComponent
{
    public class ShareSkillComponent:CommonDriver
    {
        private IWebElement shareSkillButton;
        private IWebElement title;
        private IWebElement description;
        private IWebElement category;
        private IWebElement subCategory;
        private IWebElement tags;
        private IWebElement serviceTypeHourly;
        private IWebElement serviceTypeOneOff;
        private IWebElement locationTypeOnsite;
        private IWebElement locationTypeOnline;
        private IWebElement startDate;
        private IWebElement endDate;
        private IWebElement availableDaysSun;
        private IWebElement startTime;
        private IWebElement endTime;
        private IWebElement skillTradeSkillexchange;
        private IWebElement skillTradeCredit;
        private IWebElement skillExchange;
        private IWebElement credit;
        private IWebElement active;
        private IWebElement activehidden;
        private IWebElement saveButton;
        private IWebElement popUpMessage;
        private IWebElement getShareSkillTitleData;
        private IWebElement manageListings;

        public void RenderShareSkillButton()
        {
            Thread.Sleep(1000); 
            shareSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
        }
        public void RenderSaveButton()
        {
            saveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        }
        public void RenderShareSkillFields()
        {
            title = driver.FindElement(By.Name("title"));
            description=driver.FindElement(By.Name("description"));
            category = driver.FindElement(By.Name("categoryId"));
           
            tags = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
            serviceTypeHourly = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            serviceTypeOneOff = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            locationTypeOnsite = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            locationTypeOnline = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            startDate = driver.FindElement(By.Name("startDate"));
            endDate = driver.FindElement(By.Name("endDate"));
            availableDaysSun = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));
            //availableDaysSun = driver.FindElement(By.XPath("//label[text()='Sun']"));

            startTime = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
            endTime = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
            skillTradeSkillexchange = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillTradeCredit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            skillExchange = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            
            active = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            activehidden = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
        }
        public void RenderSubCategory()
        {
            subCategory = driver.FindElement(By.Name("subcategoryId"));
        }
        public void RenderCredit()
        {
            credit = driver.FindElement(By.XPath(" //*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
           
        }
        public void RenderPopUpMessage()
        {
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }

        public void RenderManageListing()
        {
            Thread.Sleep(2000); 
            manageListings = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/a[3]"));
        }

        public void GoToShareSkill()
        {
            RenderShareSkillButton();
            shareSkillButton.Click();
        }
        public void CreateShareSkill( string Title,string Description, string Category, string SubCategory, string Tags, string ServiceType, string LocationType,   string StartDate, string EndDate,  string AvailableDays, string  SkillTrade , string Credit, string Active)
        {
            RenderShareSkillFields();
            title.SendKeys(Title);
            description.SendKeys(Description);
            SelectElement categorydropdown = new SelectElement(category);
            categorydropdown.SelectByText(Category);
            RenderSubCategory();
            SelectElement category1dropdown = new SelectElement(subCategory);
            category1dropdown.SelectByText(SubCategory);
            tags.SendKeys(Tags);
            tags.SendKeys(Keys.Return);

            if(ServiceType == "One-off service")
            {
                serviceTypeOneOff.Click();
            }
            else
            {
                serviceTypeHourly.Click();
            }
            if(LocationType == "Online")
            {
                locationTypeOnline.Click();
            }
            else
            {
                locationTypeOnsite.Click();
            }
           
            startDate.SendKeys(StartDate);

            endDate.SendKeys(EndDate);

            if (AvailableDays=="Sun")
            {
                availableDaysSun.Click();
            }
      

            if (SkillTrade == "Credit")
            {

                skillTradeCredit.Click();
                RenderCredit();
                skillTradeCredit.Click();
                credit.SendKeys(Credit);

                
            }
            else
            {
                skillTradeSkillexchange.Click();
               
            }
            
            
            if(Active=="Active")
            {
                active.Click();
            }
            else
            {
                activehidden.Click();
            }
            
            RenderSaveButton();
            saveButton.Click();

            Thread.Sleep(2000);
        }

        public string  AssertNewShareSkill()
        {
            RenderManageListing();
            
            getShareSkillTitleData = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
                                                                  
            return getShareSkillTitleData.Text;


        }

    
        public string PopUpMessage()
        {
            RenderPopUpMessage();
            return popUpMessage.Text;
        }

    }
}
