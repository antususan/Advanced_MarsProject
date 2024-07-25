using Advanced_ProjectMars.Utilities;
using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.HomePageComponent
{
    public class SearchSkillComponent : CommonDriver
    {
        private IWebElement searchSkillIcon;
        private IWebElement mainCategory;
        private IWebElement subCategory;
        private IWebElement searchSkill;
        private IWebElement userMainCategory;
        private IWebElement userSubCategory;
        private IWebElement userSkill;
        private IWebElement lastpage;
        private IWebElement lastSkill;
        private IWebElement onlineFilter;
        private IWebElement onsiteFilter;
        private IWebElement showAllFilter;



        public void RendersearchskillIcon()
        {
            searchSkillIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/div[1]/div[1]/i[1]"));
        }
        public void RenderSearchSkill()
        {
            searchSkill = driver.FindElement(By.XPath("//input[@placeholder='Search skills']"));
        }
        public void RenderLastPage()
        {
            Thread.Sleep(2000);
            lastpage = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[last()-1]"));
        }

        public void RenderLastSkill()
        {
            
            lastSkill = driver.FindElement(By.XPath(" //*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/a"));


        }
        public void RenderMainCategory()
        {
            userMainCategory = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]"));
        }
        public void RenderSubCategory()

        {
            userSubCategory = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]"));
        }
        public void RenderSkill()
        {
            userSkill = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));
        }
        public void RenderFilters()
        {
            onlineFilter = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]"));
            onsiteFilter = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[2]"));
            showAllFilter = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[3]"));
        }



        public void GotoSearchSkill()
        {
            Thread.Sleep(2000);
            RendersearchskillIcon();
            searchSkillIcon.Click();

        }

        public void SearchSkillByMainAndSubCategory( string MainCategory, string SubCategory,string Skill)
        {

            mainCategory = driver.FindElement(By.LinkText(MainCategory));
            mainCategory.Click();
            Thread.Sleep(1000);
            subCategory = driver.FindElement(By.LinkText(SubCategory));
            subCategory.Click();
            Thread.Sleep(1000);
            RenderSearchSkill();
            searchSkill.SendKeys(Skill);
            searchSkill.SendKeys(Keys.Return); 
            Thread.Sleep(2000);
        }

        

        public void GoToLastPage()
        {
            
            RenderLastPage();
            
            lastpage.Click();
            Thread.Sleep(2000);
            RenderLastSkill();
            Thread.Sleep(1000);
            lastSkill.Click();

        }
        public string GetMainCategory()
        {
            Thread.Sleep(1000);
            RenderMainCategory();
            return userMainCategory.Text;
        }
        public string GetSubCategory()
        {
            Thread.Sleep(1000);
            RenderSubCategory();
            return userSubCategory.Text;
        }
        public string GetSkill()
        {
            Thread.Sleep(2000);
            RenderSkill();
            return userSkill.Text;
        }

        public void SearchSkillByFilter(string Skill,string Filter)
        {
            RenderSearchSkill();
            searchSkill.SendKeys(Skill);
            searchSkill.SendKeys(Keys.Return);
            Thread.Sleep(2000);
            if (Filter== "Online")
            {
                RenderFilters();
                onlineFilter.Click();
            }
            if(Filter=="Onsite")
            {
                RenderFilters();
                onsiteFilter.Click();
            }
             if (Filter == "ShowAll")
            {
                RenderFilters();
                showAllFilter.Click();
                Thread.Sleep(2000);
            }
        }


    }
}
        
       
    

