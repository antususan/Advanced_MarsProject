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
    public class SearchSkillTest :CommonDriver
    {
        JsonHelper jsonHelperObj;
        SearchSkillSteps searchSkillObj= new SearchSkillSteps();
        AssertSearchSkill assertSearchSkillObj = new AssertSearchSkill();

        [Test, Order(1)]
        public void SearchSkillByMainAndSubCategory()
        {
            test = extent.CreateTest("SearchSkillByMainAndSubCategory").Info("Test 1- SearchSkillByMainAndSubCategory Started");
            string SearchSkillByMainCategoryDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SearchSkill\\SearchSkillByMainAndSubCategory.json";
            jsonHelperObj = new JsonHelper(SearchSkillByMainCategoryDataPath);
            var SearchSkillByMainCategoryData = jsonHelperObj.ReadSearchSkillByMainAndSubCategory();
            foreach (var item in SearchSkillByMainCategoryData)
            {
                searchSkillObj.SearchSkillByMainAndCategorySteps(item.MainCategory, item.SubCategory, item.Skill);
                assertSearchSkillObj.AssertSearchSkillByMainCategory(item.MainCategory, item.SubCategory, item.Skill);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-1 Passed");

        }
        [Test, Order(2)]
        public void SearchSkillByFilter()
        {
            test = extent.CreateTest("SearchSkillByFilter").Info("Test 1- SearchSkillByFilter Started");
            string SearchSkillByFilterDataPath = "D:\\Test Analyst\\ProjectMars\\Advanced_MarsProject\\Advanced_MarsProject\\Advanced_ProjectMars\\JsonDatas\\SearchSkill\\SearchSkillByFilter.json";
            jsonHelperObj = new JsonHelper(SearchSkillByFilterDataPath);
            var SearchSkillByFilterData = jsonHelperObj.ReadSearchSkillByFilter();
            foreach (var item in SearchSkillByFilterData)
            {
                searchSkillObj.SearchSkillByFilter(item.Skill, item.Filter);
                assertSearchSkillObj.AssertSearchSkillByFiltery(item.Skill, item.Filter);
            }

            string screenshotPath = TakeScreenshot(driver);
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            test.Log(Status.Pass, "Test-1 Passed");

        }

    }
}
