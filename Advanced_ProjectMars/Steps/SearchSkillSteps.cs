using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Steps
{
    public  class SearchSkillSteps
    {
        SearchSkillComponent searchSkillComponentObj =new SearchSkillComponent();
        public void SearchSkillByMainAndCategorySteps(string MainCategory, string SubCategory,string Skill)
        {
            searchSkillComponentObj.GotoSearchSkill();
            searchSkillComponentObj.SearchSkillByMainAndSubCategory(MainCategory,SubCategory, Skill);

            searchSkillComponentObj.GoToLastPage();
        }
        public void SearchSkillByFilter(string skill,string  filter) 
        
        {
            searchSkillComponentObj.GotoSearchSkill();
            searchSkillComponentObj.SearchSkillByFilter(skill,filter);
            searchSkillComponentObj.GoToLastPage();
        }
    }
}
