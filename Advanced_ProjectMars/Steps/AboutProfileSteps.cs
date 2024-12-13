using Advanced_ProjectMars.Pages.Components.HomePageComponent;
using Advanced_ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ProjectMars.Steps
{
    public class AboutProfileSteps:CommonDriver
    {
        AboutProfileComponent aboutProfileComponentObj = new AboutProfileComponent();

        public void UpdateAboutProfileDataSteps(string availability, string hours, string earntarget)
        {
            aboutProfileComponentObj.UpdateAboutProfileUsingValidData( availability,  hours,  earntarget);

        }
    }
}
