using Advanced_ProjectMars.Pages.Components.PofileOverViewComponent;
using Advanced_ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Steps
{
    public class LanguageSteps:CommonDriver
    {
        LanguageComponent languageComponentObj =new LanguageComponent();
        public void CreateLanguageUsingValidDataSteps(string language, string level)
        {
            languageComponentObj.GotoLanguageTab();
            languageComponentObj.ResetLanguageRow();
            languageComponentObj.CreateLanguageUsingValidData(language ,level);
            
        }
        public void CreateLanguageUsingExistingDataSteps(string language, string level)
        {
            languageComponentObj.GotoLanguageTab();
            languageComponentObj.ResetLanguageRow();
            languageComponentObj.CreateLanguageUsingValidData(language, level);
            languageComponentObj.CreateLanguageUsingExistingData(language, level);
        }
        
        public void CreateLanguageUsingInvalidDataSteps(string language, string level) 
        {
            languageComponentObj.GotoLanguageTab();
            languageComponentObj.ResetLanguageRow();
            languageComponentObj.CreateLanguageWithInvalidData(language ,level);
           
        }
        public void EditLanguageUsingValidDataSteps(string language, string level)
        {
            //languageComponentObj.GotoLanguageTab();
            //languageComponentObj.ResetLanguageRow();
            //languageComponentObj.CreateLanguageUsingValidData(language, level);
            languageComponentObj.EditLanguageWithValidData(language, level);

        }

        public void DeleteLanguageDataSteps(string language, string level)
        {
            languageComponentObj.GotoLanguageTab();
            languageComponentObj.ResetLanguageRow();
            languageComponentObj.DeleteLanguageData(language, level);

        }
    


    }
}
