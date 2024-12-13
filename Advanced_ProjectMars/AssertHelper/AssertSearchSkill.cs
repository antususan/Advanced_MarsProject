using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.AssertHelper
{
    public  class AssertSearchSkill

    {
        SearchSkillComponent searchSkillObj = new SearchSkillComponent();
        public void AssertSearchSkillByMainCategory( string MainCategory,string SubCategory,string Skill)
        {
            string newMainCategory = searchSkillObj.GetMainCategory();
            string newSubCategory = searchSkillObj.GetSubCategory();
            string newSkill=searchSkillObj.GetSkill();
            Assert.That(newMainCategory == MainCategory, "Search Skill By Main and Sub Category has not been sucessfull");
            Assert.That(newSubCategory == SubCategory, "Search Skill By Main and Sub Category has not been sucessfull");
            Assert.That(newSkill == Skill, "Search Skill By Main and Sub Category has not been sucessfull");

        }

        public void AssertSearchSkillByFiltery(string Skill, string Filter)
        {

            string newSkill = searchSkillObj.GetSkill();
            Assert.That(newSkill == Skill, "Search Skill By filter has not been sucessfull");

        }


    }
}
