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
    public class SkillTests : Hooks
    {
        SkillSteps skillStepsObj;
        HomePageSteps homePageStepsObj;
        ProfileMenuTabsComponents profileMenuTabsComponentsObj;

        [SetUp]
        public void Init()
        {
            skillStepsObj = new SkillSteps();
            homePageStepsObj = new HomePageSteps();
            profileMenuTabsComponentsObj = new ProfileMenuTabsComponents();


        }

        [Test, Order(1), Description("Testcase : Add new Skill")]

        public void TestAddNewSkill()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\AddSkillTestData.json";
            List<SkillCredentials> credentialsList = JsonReader.GetSkillCredentialsList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnProfileTab();
                profileMenuTabsComponentsObj.ClickSkillsTab();
                skillStepsObj.AddSkillSteps(credentials, test);

            }

            test.Pass("Add New Skill Test case passed successfully.");
        }
        
                [Test, Order(2), Description("Testcase : Edit new Skill")]

                public void TestEditNewSkill()
                {
                    string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\EditSkillTestData.json";
                    List<SkillCredentials> credentialsList = JsonReader.GetSkillCredentialsList(testDataPath);

                    foreach (var credentials in credentialsList)
                    {
                        homePageStepsObj.ClickOnProfileTab();
                        profileMenuTabsComponentsObj.ClickSkillsTab();
                        skillStepsObj.EditSkillSteps(credentials, test);

                    }

                    test.Pass("Edit New Skill Test case passed successfully.");
                }

                [Test, Order(3), Description("Testcase : Delete new Skill")]

                public void TestDeleteNewSkill()
                {
                    string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\DeleteSkillTestData.json";
                    List<SkillCredentials> credentialsList = JsonReader.GetSkillCredentialsList(testDataPath);

                    foreach (var credentials in credentialsList)
                    {
                        homePageStepsObj.ClickOnProfileTab();
                        profileMenuTabsComponentsObj.ClickSkillsTab();
                        skillStepsObj.DeleteSkillSteps(credentials, test);

                    }

                    test.Pass("Delete New Skill Test case passed successfully.");
                }

                

    }
}
