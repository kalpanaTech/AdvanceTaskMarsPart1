using AdvanceTaskMarsPart1.Assertions;
using AdvanceTaskMarsPart1.Model;
using AdvanceTaskMarsPart1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Steps
{
    public class UserDetailSteps
    {
        ProfileUserDetailOverviewComponent profileUserDetailOverviewComponentObj = new ProfileUserDetailOverviewComponent();
        UserDetailAssertions userDetailAssertionsObj = new UserDetailAssertions();
        public void UpdateUserDetails(UserDetailCredentials credentials)
        {

            profileUserDetailOverviewComponentObj.UpdateAvailableTime(credentials.AvailableTime);
            userDetailAssertionsObj.UpdateUserDetailAssertion();

            profileUserDetailOverviewComponentObj.UpdateAvailableHours(credentials.AvailableHours);
            userDetailAssertionsObj.UpdateUserDetailAssertion();

            profileUserDetailOverviewComponentObj.UpdateEarnTarget(credentials.EarnTarget);
            userDetailAssertionsObj.UpdateUserDetailAssertion();
        }
    }
}