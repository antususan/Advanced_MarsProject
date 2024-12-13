using Advanced_ProjectMars.AssertHelper;
using Advanced_ProjectMars.Steps;
using Advanced_ProjectMars.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using MongoDB.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Tests
{
    [TestFixture]
    public class ShareSkillTest : CommonDriver
    {
        JsonHelper jsonHelperObj;
        ShareSkillSteps shareSkillStepObj = new ShareSkillSteps();
        AssertShareSkill assertShareSkillObj = new AssertShareSkill();

        [Test, Order(1)]
        public void CreateShareSkillUsingValidData()
        {
            test = extent.CreateTest("CreateShareSkillRecordUsingValidData").Info("Test 1- CreateShareSkillRecordUsingValidData Started");
            string CreateShareSkillRecordUsingValidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\ShareSkillDatas\\AddShareSkillRecordUsingValidData.json";
            jsonHelperObj = new JsonHelper(CreateShareSkillRecordUsingValidDataPath);
            var CreateShareSkillRecordUsingValidData = jsonHelperObj.ReadCreateShareSkillRecordUsingValidData();

            foreach (var item in CreateShareSkillRecordUsingValidData)
            {
                shareSkillStepObj.CreateShareSkillSteps(item.Title, item.Description, item.Category, item.SubCategory, item.Tags,
                item.ServiceType, item.LocationType, item.StartDate, item.EndDate, item.AvailableDays, item.SkillTrade,  item.Credit, item.Active);
                assertShareSkillObj.AssertGotoManageListings(item.Title);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-1 Passed");

        }

        [Test, Order(2)]

        public void CreateShareSkillUsingInValidData()
        {
            test = extent.CreateTest("CreateShareSkillUsingInValidData").Info("Test 2- CreateShareSkillUsingInValidData Started");
            string CreateShareSkillRecordUsingInValidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\ShareSkillDatas\\AddShareSkillUsingInvalidData.json";
            jsonHelperObj = new JsonHelper(CreateShareSkillRecordUsingInValidDataPath);
            var CreateShareSkillRecordUsingInValidData = jsonHelperObj.ReadCreateShareSkillRecordUsingInValidData();

            foreach (var item in CreateShareSkillRecordUsingInValidData)
            {
                shareSkillStepObj.CreateShareSkillSteps(item.Title, item.Description, item.Category, item.SubCategory, item.Tags,
                item.ServiceType, item.LocationType, item.StartDate, item.EndDate, item.AvailableDays, item.SkillTrade, item.Credit, item.Active);
                assertShareSkillObj.AssertPopUpMessage(item.PopUpMessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-2 Passed");

        }

        
    }
}
