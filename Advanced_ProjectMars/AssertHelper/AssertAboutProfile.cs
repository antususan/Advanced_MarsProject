using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.AssertHelper
{
    public  class AssertAboutProfile
        
    {
        AboutProfileComponent aboutProfileComponentObj= new AboutProfileComponent();
        public void assertUpdateAboutProfile(string availability, string hours, string earntarget)
        {

            string newavailability = aboutProfileComponentObj.AssertAvailability();
            string newhours = aboutProfileComponentObj.AssertHours();
            string newearnTarget = aboutProfileComponentObj.AssertEarnTarget();
            Assert.That(newavailability == availability,"Availability has not been updated sucessfully");
            Assert.That(newhours == hours, "Hours has not been updated sucessfully");
            Assert.That(newearnTarget == earntarget, "EarnTarget has not been updated Sucessfully");
        }

    }
}
