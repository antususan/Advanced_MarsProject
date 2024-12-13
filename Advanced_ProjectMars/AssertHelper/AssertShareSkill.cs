using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.AssertHelper
{
    public class AssertShareSkill
    {
        ShareSkillComponent shareskillcomponentObj = new ShareSkillComponent();
        public void AssertGotoManageListings( string title)
        {
            Thread.Sleep(1000);
            string newTitle = shareskillcomponentObj.AssertNewShareSkill();
            Assert.That(newTitle == title, "New Record has not been created sucessfully");

        }
        public void AssertPopUpMessage(string popUpMessage)
        { 
            Thread.Sleep(1000);
            string newPopUpMessage =shareskillcomponentObj.PopUpMessage();
            Assert.That(newPopUpMessage == popUpMessage, "Share Skill Record has been added sucessfully");

        }
    }
}
