using AdvanceTaskMarsPart1.Model;
using AdvanceTaskMarsPart1.Steps;
using CompetionTaskMars.Helpers;
using CompetionTaskMars.Tests;
using CompetionTaskMars.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Tests
{
    [TestFixture]
    public class UserDetailTest : Hooks
    {
        UserDetailSteps userDetailStepsObj = new UserDetailSteps();

        [Test, Order(1), Description("Testcase :  Update user details")]
        public void TestUserData()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\AddUserTestData.json";
            List<UserDetailCredentials> credentialsList = JsonReader.GetUserDetailCredentialsList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                userDetailStepsObj.UpdateUserDetails(credentials);
            }
        }

    }
}
