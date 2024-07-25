using Advanced_ProjectMars.Pages.Components.PofileOverViewComponent;
using Advanced_ProjectMars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Internal.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.AssertHelper
{
    public class AssertSkill:CommonDriver
    {

        SkillComponent skillComponentObj =new SkillComponent();
        public void AssertAddSkill(string skill, string level)
        {
            string newSkill = skillComponentObj.AssertSkill();
            string newLevel = skillComponentObj.AssetLevel();
            Assert.That(newSkill == skill, "Skill has not been created sucessfully");
            Assert.That(newLevel == level, " Level has not been created sucessfully");
        }

        public void AssertExistingSkill(string popupmessage) 
        
        {
            string newpopupmessage = skillComponentObj.PopUpMessage();
            Assert.That(newpopupmessage== popupmessage, "skill with Existing Data added Successfully"); 
        }
        public void AssertInvalidSkill(string popupmessage)

        {
            string newpopupmessage = skillComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == popupmessage, "skill with Invalid Data added Successfully");
        }

        
        public void AssertEditSkill(string skill, string level)

        {
            string updatedSkill = skillComponentObj.AssertSkill();
            string updatedLevel = skillComponentObj.AssetLevel();
            Assert.That(updatedSkill == skill, "Skill has not been updated sucessfully");
            Assert.That(updatedLevel == level, " Level has not been updated sucessfully");
        }

        public void AssertDeleteSkill(string popupmessage)

        {
            string newpopupmessage = skillComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == popupmessage, "skill with Invalid Data added Successfully");
        }

        


    }
}
