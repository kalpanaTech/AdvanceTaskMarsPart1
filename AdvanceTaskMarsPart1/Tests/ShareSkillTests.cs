using AdvanceTaskMarsPart1.Model;
using AdvanceTaskMarsPart1.Pages;
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
    public class ShareSkillTests : Hooks
    {
        ShareSkillSteps shareSkillStepsObj;
        HomePageSteps homePageStepsObj;
        ProfileMenuTabsComponents profileMenuTabsComponentsObj;

        [SetUp]
        public void Init()
        {
            shareSkillStepsObj = new ShareSkillSteps();
            homePageStepsObj = new HomePageSteps();
            profileMenuTabsComponentsObj = new ProfileMenuTabsComponents();


        }

        [Test, Order(1), Description("Testcase : Add new details for share skill")]

        public void TestSahreSkill()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\ShareSkillTestData.json";
            List<ShareSkillCredentials> credentialsList = JsonReader.GetShareSkillCredentialsList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnShareSkill();

                shareSkillStepsObj.AddShareSkillsSteps(credentials);

            }

            test.Pass("Add new details for share skill Test case passed successfully.");
        }


    }
}
