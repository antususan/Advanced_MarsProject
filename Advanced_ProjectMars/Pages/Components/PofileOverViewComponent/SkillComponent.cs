using Advanced_ProjectMars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.PofileOverViewComponent
{
    public class SkillComponent : CommonDriver
    {

        private IWebElement skillTab;
        private IWebElement addNewSkillButton;
        private IWebElement addNewSkillTextBox;
        private IWebElement selectLevel;
        private IWebElement addButton;
        private IWebElement deleteSkillButton;
        private IWebElement newSkill;
        private IWebElement newLevel;
        private IWebElement popUpMessage;
        private IWebElement cancelButton;
        private IWebElement editSkillsButton;
        private IWebElement editSkillsTextBox;
        private IWebElement editSelectLevel;
        private IWebElement updateSkillsButton;





        public void RenderSkillTab()
        {
            skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        }
        public void RenderAddNewSkillButton()
        {
            addNewSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        }
        public void RenderAddSkill()
        {
            addNewSkillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            selectLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        }
        public void RenderDeleteButton()
        {
            deleteSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
        }

        public void RenderAssertSkillAndLevel()
        {
            newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        }
        public void RenderPopUpMessage()
        {
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }

        public void RenderCancelButton()
        {
            cancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
        }

        public void RenderEditButton()
        {
            editSkillsButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        }
        public void RenderEditSkill()
        {
            editSkillsTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            editSelectLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            updateSkillsButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        }



        public void GotoSkillTab()
        {
            Thread.Sleep(2000);
            RenderSkillTab();
            //wait.Waittobeclickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 2);

            skillTab.Click();
        }
        public void ResetSkillRow()
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr")).Count;
            for (int i = 0; i < rowCount; i++)
            {
                RenderDeleteButton();
                Thread.Sleep(2000);
                deleteSkillButton.Click();
            }
        }


        public void CreateSkillUsingValidData(string skill, string level)
        {

            RenderAddNewSkillButton();
            addNewSkillButton.Click();
            RenderAddSkill();
            addNewSkillTextBox.SendKeys(skill);
            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButton.Click();
            Thread.Sleep(2000);
        }

        public string AssertSkill()
        {
            RenderAssertSkillAndLevel();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            return newSkill.Text;
        }
        public string AssetLevel()
        {
            RenderAssertSkillAndLevel();
            Wait.Waittobevisible(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 2);
            return newLevel.Text;
        }

        public void CreateSkillUsingExistingData(string skill, string level)
        {
            RenderAddNewSkillButton();
            addNewSkillButton.Click();
            RenderAddSkill();
            addNewSkillTextBox.SendKeys(skill);
            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButton.Click();
            Thread.Sleep(1000);
        }

        public string PopUpMessage()
        {
            RenderPopUpMessage();
            
            return popUpMessage.Text;
        }

        public void CreateSkillUsingInvalidData(string skill, string level)
        {
            RenderAddNewSkillButton();
            addNewSkillButton.Click();
            RenderAddSkill();
            addNewSkillTextBox.SendKeys(skill);
            SelectElement levelDropdown = new SelectElement(selectLevel);
            levelDropdown.SelectByValue(level);
            addButton.Click();
            Thread.Sleep(2000);
            RenderCancelButton();
            cancelButton.Click();


        }

        public void EditSkillUsingValidData(string skill, string level)
        {

            RenderEditButton();
            editSkillsButton.Click();
            RenderEditSkill();
            editSkillsTextBox.Clear();
            editSkillsTextBox.SendKeys(skill);
            SelectElement levelDropdown = new SelectElement(editSelectLevel);
            levelDropdown.SelectByValue(level);
            updateSkillsButton.Click();
            Thread.Sleep(2000);

        }

        public void DeleteSkillData()
        {

            RenderDeleteButton();
            deleteSkillButton.Click();
            Thread.Sleep(2000);

        }

    }
}
