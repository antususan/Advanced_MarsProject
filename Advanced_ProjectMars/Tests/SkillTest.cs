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
    public class SkillTest : CommonDriver
    {
        JsonHelper jsonHelperObj;
        SkillSteps skillStepsObj = new SkillSteps();
        AssertSkill assertSkillObj = new AssertSkill();

        [Test, Order(1)]

        public void CreateSkillUsingValidData()
        {
            test = extent.CreateTest("CreateSkillUsingValidData").Info("Test 1- CreateSkillUsingValidData Started");
            string AddSkillUsingValidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SkillsDatas\\AddSkillDataUsingValidData.json";
            jsonHelperObj = new JsonHelper(AddSkillUsingValidDataPath);
            var AddSkillUsingValidData = jsonHelperObj.ReadAddSkillUsingValidData();
            skillStepsObj.DefaultStepsForSkillTab();
            foreach (var item in AddSkillUsingValidData)
            {
                skillStepsObj.CreateSkillUsingValidDataSteps(item.skill, item.level);
                assertSkillObj.AssertAddSkill(item.skill, item.level);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-1 Passed");
        }
        [Test, Order(2)]

        public void CreateSkillUsingExistingData()
        {
            test = extent.CreateTest("CreateSkillWithExistingData").Info("Test 2- CreateSkillWithExistingData Started");
            string AddSkillUsingExistingDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SkillsDatas\\AddSkillUsingExistingData.json";
            jsonHelperObj = new JsonHelper(AddSkillUsingExistingDataPath);
            var AddSkillUsingExistingData = jsonHelperObj.ReadAddSkillUsingExistingData();
            skillStepsObj.DefaultStepsForSkillTab();
            foreach (var item in AddSkillUsingExistingData)
            {
                skillStepsObj.CreateSkillUsingValidDataSteps(item.skill, item.level);
                skillStepsObj.CreateSkillUsingExistingDataSteps(item.skill, item.level);
                assertSkillObj.AssertExistingSkill(item.popupmessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-2 Passed");
        }
        [Test, Order(3)]
        public void CreateSkillUsingInvalidData()
        {
            test = extent.CreateTest("CreateSkillUsingInvalidData").Info("Test 3- CreateSkillUsingInvalidData Started");
            string AddSkillUsingInvalidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SkillsDatas\\AddSkillUsingInvalidData.json";
            jsonHelperObj = new JsonHelper(AddSkillUsingInvalidDataPath);
            var AddSkillUsingInvalidData = jsonHelperObj.ReadAddSkillUsingInvalidData();
            skillStepsObj.DefaultStepsForSkillTab();
            foreach (var item in AddSkillUsingInvalidData)
            {

                skillStepsObj.CreateSkillUsingInvalidDataSteps(item.skill, item.level);
                assertSkillObj.AssertInvalidSkill(item.popupmessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-3 Passed");
        }

        [Test, Order(4)]
        public void EditSkillUsingValidData()
        {
            test = extent.CreateTest("EditSkillUsingValidData").Info("Test 4- EditSkillUsingValidData Started");
            string EditSkillUsingValidDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SkillsDatas\\EditSkillUsingValidData.json";
            jsonHelperObj = new JsonHelper(EditSkillUsingValidDataPath);
            var EditSkillUsingValidData = jsonHelperObj.ReadEditSkillUsingvalidData();
            skillStepsObj.DefaultStepsForSkillTab();
            foreach (var item in EditSkillUsingValidData)
            {

                skillStepsObj.CreateSkillUsingValidDataSteps(item.skill, item.level);
                skillStepsObj.EditSkillUsingValidDataSteps(item.newskill, item.newlevel);
                assertSkillObj.AssertEditSkill(item.newskill,item.newlevel);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-4 Passed");
        }

        [Test, Order(5)]
        public void DeleteSkillData()
        {
            test = extent.CreateTest("DeleteSkillData").Info("Test 4- DeleteSkillData Started");
            string DeleteSkillDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SkillsDatas\\DeleteSkillData.json";
            jsonHelperObj = new JsonHelper(DeleteSkillDataPath);
            var DeleteSkillData = jsonHelperObj.ReadDeleteSkillData();
            skillStepsObj.DefaultStepsForSkillTab();
            foreach (var item in DeleteSkillData)
            {

                skillStepsObj.CreateSkillUsingValidDataSteps(item.skill, item.level);
                skillStepsObj.DeleteSkillSteps();
                assertSkillObj.AssertDeleteSkill(item.popupmessage);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-5 Passed");
        }
    } 

}

        


