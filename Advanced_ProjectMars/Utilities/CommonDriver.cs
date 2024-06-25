using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Advanced_ProjectMars.Pages.Components.SignIn;
using Advanced_ProjectMars.Pages;

namespace Advanced_ProjectMars.Utilities
{
    public class CommonDriver:ExtentHelper
    {
        public static IWebDriver driver;
       

        [SetUp]

        
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            string loginDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\LoginDatas\\LoginData.json";
            JsonHelper jsonHelperObj = new JsonHelper(loginDataPath);
            LoginComponent loginpageComponentObj = new LoginComponent();
            var login = jsonHelperObj.ReadLoginData();
            SplashPage splashPageObj = new SplashPage();
            foreach (var item in login)
            {
                splashPageObj.ClickSignButton();
                loginpageComponentObj.LoginActions(item.EmailId, item.Password);
            }
        }
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentHelper.ExtentStart();
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [TearDown]
        public void CloseTestRun()
        {

            driver.Quit();

        }


    }
}
