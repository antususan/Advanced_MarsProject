using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using AventStack.ExtentReports.Model;
using MongoDB.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Steps
{
   
    public  class ShareSkillSteps
    {
        ShareSkillComponent shareSkillComponentObj= new ShareSkillComponent();
        public void CreateShareSkillSteps(string Title, string Description, string Category, string SubCategory, string Tags,   string ServiceType, string LocationType, string StartDate, string EndDate, string AvailableDays, string SkillTrade,string Credit ,string Active)
        {
            shareSkillComponentObj.GoToShareSkill();
            shareSkillComponentObj.CreateShareSkill(Title, Description, Category, SubCategory, Tags, ServiceType, LocationType, StartDate, EndDate, AvailableDays, SkillTrade ,Credit, Active);
            
        
        }

      
    }
}
