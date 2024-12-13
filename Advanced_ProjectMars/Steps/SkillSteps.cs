using Advanced_ProjectMars.Pages.Components.PofileOverViewComponent;
using Advanced_ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Steps
{
    public class SkillSteps:CommonDriver
        
    {
        SkillComponent skillComponentObj= new SkillComponent();
        public void DefaultStepsForSkillTab()
        {
            skillComponentObj.GotoSkillTab();
            skillComponentObj.ResetSkillRow();
        }
        public void CreateSkillUsingValidDataSteps( string skill,string level)
        {
          
            skillComponentObj.CreateSkillUsingValidData(skill, level);
        }
        public void CreateSkillUsingExistingDataSteps(string skill, string level)
        {
            skillComponentObj.CreateSkillUsingExistingData(skill, level);
        }

        public void CreateSkillUsingInvalidDataSteps(string skill, string level)
        {
            skillComponentObj.CreateSkillUsingInvalidData(skill, level);
        }
        public void EditSkillUsingValidDataSteps(string skill, string level)
        {
            skillComponentObj.EditSkillUsingValidData(skill, level);
        }
        public void DeleteSkillSteps()
        {
            skillComponentObj.DeleteSkillData();
        }
        



    }
}
