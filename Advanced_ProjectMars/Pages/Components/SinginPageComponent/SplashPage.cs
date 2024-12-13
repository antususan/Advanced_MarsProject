using Advanced_ProjectMars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Pages.Components.SinginPageComponent
{
    public class SplashPage : CommonDriver
    {
        private IWebElement signInButton;

        public void RenderSigninComponents()
        {
            try
            {
                signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSignButton()
        {
            RenderSigninComponents();
            signInButton.Click();
        }

    }
}
