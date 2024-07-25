using Advanced_ProjectMars.AssertHelper;
using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using Advanced_ProjectMars.Steps;
using Advanced_ProjectMars.Utilities;
using AventStack.ExtentReports;
using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Tests
{
    [TestFixture]
    public class LanguageTest : CommonDriver
    {

        LanguageSteps languageStepsObj = new LanguageSteps();
        AssertLanguage assertlanguageobj = new AssertLanguage();
        JsonHelper jsonHelperObj;

        [Test, Order(1)]

        public void CreateLanguageWithValidData()
        {
            test = extent.CreateTest("CreateLanguageWithValidData").Info("Test 1- CreateLanguageWithValidData Started");
            string AddLanguageUsingValidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\LanguageDatas\\AddLanguageUsingValidData.json";
            jsonHelperObj = new JsonHelper(AddLanguageUsingValidDataPath);
            var AddLanguageWithValidData = jsonHelperObj.ReadAddLanguageUsingValidData();
            foreach (var item in AddLanguageWithValidData)
            {
                languageStepsObj.CreateLanguageUsingValidDataSteps(item.language, item.level);
                assertlanguageobj.AssertAddLanguage(item.language, item.level);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-1 Passed");

        }
        [Test, Order(2)]
        public void CreateLanguagewithExistingData()
        {
            test = extent.CreateTest("CreateLanguageWithExistingData").Info("Test 2- CreateLanguageWithExistingData Started");
            string AddLanguageUsingExistingDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\LanguageDatas\\AddLanguageUsingExistingData.Json";
            jsonHelperObj = new JsonHelper(AddLanguageUsingExistingDataPath);
            var AddLanguageWithExistingData = jsonHelperObj.ReadAddLanguageUsingExistingData();
            foreach (var item in AddLanguageWithExistingData)
            {
               
                languageStepsObj.CreateLanguageUsingExistingDataSteps(item.language, item.level);
                assertlanguageobj.AssertExistingLanguage(item.popupmessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-2 Passed");
        }
        [Test, Order(3)]
        public void CreateLanguageWithInvalidData()
        {
            test = extent.CreateTest("CreateLanguageWithInvalidData").Info("Test 3- CreateLanguageWithInvalidData Started");
            string AddLanguageUsingInvalidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\LanguageDatas\\AddLanguageUsingInvalidData.json";
            jsonHelperObj = new JsonHelper(AddLanguageUsingInvalidDataPath);
            var AddLanguageUsingInvalidData = jsonHelperObj.ReadAddLanguageUsingInvalidData();
            foreach (var item in AddLanguageUsingInvalidData)
            {
               
                languageStepsObj.CreateLanguageUsingInvalidDataSteps(item.language, item.level);
                assertlanguageobj.AssertInvalidLanguage(item.popupmessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-3 Passed");
        }
        [Test, Order(4)]
        public void EditLanguageWithValidData()
        {
            test = extent.CreateTest("EditLanguageWithValidData").Info("Test 4- EditLanguageWithValidData Started");
            string EditLanguageUsingvalidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\LanguageDatas\\EditLanguageUsingValidData.json";
            jsonHelperObj = new JsonHelper(EditLanguageUsingvalidDataPath);
            var EditLanguageUsingUsingValidData = jsonHelperObj.ReadEditLanguageUsingvalidData();
            foreach (var item in EditLanguageUsingUsingValidData)
            {

                languageStepsObj.CreateLanguageUsingValidDataSteps(item.language, item.level);
                languageStepsObj.EditLanguageUsingValidDataSteps(item.newlanguage, item.newlevel);
                assertlanguageobj.AssertEditLanguage(item.newlanguage, item.newlevel);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-4 Passed");
        }
        [Test, Order(5)]
        public void DeleteLanguageData()
        {
            test = extent.CreateTest("DeleteLanguageData").Info("Test 5- DeleteLanguageData Started");
            string DeleteLanguageDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\LanguageDatas\\DeleteLanguageData.json";
            jsonHelperObj = new JsonHelper(DeleteLanguageDataPath);
            var DeleteLanguageData = jsonHelperObj.ReadDeleteLanguageData();
            foreach (var item in DeleteLanguageData)
            {

                languageStepsObj.DeleteLanguageDataSteps(item.language, item.level);
                Thread.Sleep(1000);
                assertlanguageobj.AssertDeleteLanguage(item.popupmessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-5 Passed");
        }

    }

 
    


}
