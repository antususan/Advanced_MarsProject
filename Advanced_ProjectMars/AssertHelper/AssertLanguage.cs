using Advanced_ProjectMars.Pages.Components.ProfileOverviewComponent;
using Advanced_ProjectMars.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_ProjectMars.AssertHelper
{
    public class AssertLanguage : CommonDriver
    {
        LanguageComponent languageComponentObj = new LanguageComponent();

        public void AssertAddLanguage(string language, string level)
        {
            string newLanguage = languageComponentObj.AssertLanguage();
            string newLevel = languageComponentObj.AssertLevel();
            Assert.That(newLanguage == language, "Language has not been created sucessfully.");
            Assert.That(newLevel == level, "Level has not created sucessfully");
        }

        public void AssertExistingLanguage(string popupmessage)
        {
            string newpopupmessage = languageComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == popupmessage, "Language with Existing Data added Successfully");

        }
        public void AssertInvalidLanguage(string popupmessage)
        {
            string newpopupmessage = languageComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == popupmessage, "Language with Invalid Data added Successfully");

        }
        public void AssertEditLanguage(string language, string level)
        {

            string updatedLanguage = languageComponentObj.AssertLanguage();
            string updatedLevel = languageComponentObj.AssertLevel();
            Assert.That(updatedLanguage == language, "Language has not been updated sucessfully.");
            Assert.That(updatedLevel == level, "Level has not updated sucessfully");
        }
        public void AssertDeleteLanguage(string popupmessage)
        {

            string newpopupmessage = languageComponentObj.PopUpMessage();
            Assert.That(newpopupmessage == popupmessage, "Data has not been deleted sucessfully");


        }
    }

}
