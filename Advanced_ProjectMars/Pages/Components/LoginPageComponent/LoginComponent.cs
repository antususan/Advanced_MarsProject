using Advanced_ProjectMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.LoginPageComponent
{
    public class LoginComponent:CommonDriver
    {

        private IWebElement emailTextBox;
        private IWebElement passwordTextBox;
        private IWebElement loginButton;

        public void RenderLoginComponents()
        {
            Thread.Sleep(2000);
            emailTextBox= driver.FindElement(By.Name("email"));
            passwordTextBox = driver.FindElement(By.Name("password"));
            loginButton= driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
        }

        public void LoginActions(string EmailId, string Password)
        {
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://localhost:5000/");
            RenderLoginComponents();
            
            emailTextBox.SendKeys(EmailId);
            Wait.Waittobevisible(driver, "Name", "password", 5);
            passwordTextBox.SendKeys(Password);
            loginButton.Click();
        }
    }
}
