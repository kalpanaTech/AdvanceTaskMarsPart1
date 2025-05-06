using AdvanceTaskMarsPart1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Steps
{
    public class HomePageSteps
    {
        HomePage homePageObj;
        public HomePageSteps()
        {
            homePageObj = new HomePage();
        }
        public void ClickOnProfileTab()
        {
            homePageObj.ProfileTabClick();
        }
        public void ClickOnNotificationPanel()
        {

            homePageObj.NotificationClick();
        }
        public void ClickOnSearchSkill()
        {
            homePageObj.SearchSkillClick();
        }
    }
}
