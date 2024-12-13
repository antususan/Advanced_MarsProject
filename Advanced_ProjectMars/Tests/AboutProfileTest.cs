using Advanced_ProjectMars.AssertHelper;
using Advanced_ProjectMars.Steps;
using Advanced_ProjectMars.Utilities;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Tests
{
    [TestFixture]
      public class AboutProfileTest:CommonDriver
      {
        JsonHelper jsonHelperObj;
        AboutProfileSteps aboutProfileStepsObj =new AboutProfileSteps();
        AssertAboutProfile assertHelperObj = new AssertAboutProfile();

        [Test, Order(1)]
        

        public void UpdateAboutProfileData()
        {
                test = extent.CreateTest("UpdateAboutProfile").Info("Test 1- UpdateAboutProfile Started");
                string UpdateAboutProfileDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\AboutProfileDatas\\UpdateAboutProfileData.json";
                jsonHelperObj = new JsonHelper(UpdateAboutProfileDataPath);
                var UpdateAboutProfileData = jsonHelperObj.ReadUpdateAboutProfileData();
                foreach (var item in UpdateAboutProfileData)
                {

                aboutProfileStepsObj.UpdateAboutProfileDataSteps(item.availability, item.hours, item.earntarget);
                assertHelperObj.assertUpdateAboutProfile(item.availability, item.hours, item.earntarget);

                }

                string screenshotPath = TakeScreenshot(driver);
                test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
                test.Log(Status.Pass, "Test-1 Passed");
            
        }
      }
}
