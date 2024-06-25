using Advanced_ProjectMars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.ProfileOverviewComponent
{
    public class LanguageComponent : CommonDriver
    {
        private IWebElement languageTab;
        private IWebElement addNewButton;
        private IWebElement addLanguageTextBox;
        private IWebElement selectLevel;
        private IWebElement addButtonLanguage;
        private IWebElement deleteLanguageButton;
        private IWebElement newLanguage;
        private IWebElement newLevel;
        private IWebElement popUpMessage;
        private IWebElement cancelButton;
        private IWebElement editButton;
        private IWebElement editTextBox;
        private IWebElement editSelectLevel;
        private IWebElement updateButton;
        private IWebElement newEditLanguage;
        private IWebElement newEditLevel;

        public void RenderLanguageTab()
        {
            languageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        }
        public void RenderdeleteLanguageButton()
        {
            deleteLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
        }
        public void RenderAddButtonLanguage()
        {

            addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));

        }
        public void RenderAddLanguage()
        {


            addLanguageTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            selectLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            addButtonLanguage = driver.FindElement(By.XPath("//input[@class='ui teal button']"));


        }
        public void RenderAssertLanguageLevel()
        {

            newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        }
        public void RenderPopUpMessage()
        {
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }

        public void RenderCancelButton()
        {
            cancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
        }

        public void RenderEditButton()
        {
            editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        }

        public void RenderEditLanguage()
        {
            editTextBox =driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            editSelectLevel= driver.FindElement(By.XPath("//select[@name='level']"));
            updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        }

        public void RenderAssertUpdatedLanguageandLevel()
        {
            newEditLanguage= driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            newEditLevel =driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            
        }

        

        public void GotoLanguageTab()
        {
            Thread.Sleep(2000);
            RenderLanguageTab();
         
            //wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 5);         
            languageTab.Click();
        }
        public void ResetLanguageRow()
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr")).Count;

            for (int i = 0; i < rowCount; i++)
            {
                RenderdeleteLanguageButton();
                //Thread.Sleep(2000);
                Thread.Sleep(2000);
                
                deleteLanguageButton.Click();
            }
        }
        public void CreateLanguageUsingValidData(string language, string level)
        {
            RenderAddButtonLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            addNewButton.Click();
            RenderAddLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//input[@placeholder='Add Language']", 2);

            addLanguageTextBox.SendKeys(language);

            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButtonLanguage.Click();
            Thread.Sleep(2000);
        }
        public string AssertLanguage()
        {
            RenderAssertLanguageLevel();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            return newLanguage.Text;
        }

        public string AssertLevel()
        {
            RenderAssertLanguageLevel();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 2);
            return newLevel.Text;
        }
        public string PopUpMessage()
        {
            RenderPopUpMessage();
            return popUpMessage.Text;
        }
        public void CreateLanguageUsingExistingData(string language, string level)
        {
            RenderAddButtonLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            addNewButton.Click();
            RenderAddLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//input[@placeholder='Add Language']", 2);

            addLanguageTextBox.SendKeys(language);

            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButtonLanguage.Click();
            Thread.Sleep(2000);
        }
       
        public void CreateLanguageWithInvalidData(string language, string level)
        {
            RenderAddButtonLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            addNewButton.Click();
            RenderAddLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//input[@placeholder='Add Language']", 2);

            addLanguageTextBox.SendKeys(language);

            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButtonLanguage.Click();
            Thread.Sleep(2000);
            RenderCancelButton();
            cancelButton.Click();
        }

        public void EditLanguageWithValidData(string language, string level)
        {
            RenderEditButton();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 2);
            editButton.Click();
            RenderEditLanguage();
            editTextBox.Clear();
            editTextBox.SendKeys(language);
            SelectElement levelDropdown = new SelectElement(editSelectLevel);
            levelDropdown.SelectByValue(level);
            updateButton.Click();
            
        }
        public string AssertEditLanguage()
        {
            Thread.Sleep(2000);
            RenderAssertUpdatedLanguageandLevel();
          
            return newEditLanguage.Text;
        }
        public string AssertEditLevel()
        {
            RenderAssertUpdatedLanguageandLevel();
            Thread.Sleep(3000);
            return newEditLevel.Text;
        }

        public void DeleteLanguageData(string language, string level)
        {
            RenderAddButtonLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            addNewButton.Click();
            RenderAddLanguage();
            Wait.Waittobevisible(driver, "Xpath", "//input[@placeholder='Add Language']", 2);

            addLanguageTextBox.SendKeys(language);

            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButtonLanguage.Click();
            Thread.Sleep(4000);
            RenderdeleteLanguageButton();
            deleteLanguageButton.Click();
            //Thread.Sleep(5000);
        }



    }
}
