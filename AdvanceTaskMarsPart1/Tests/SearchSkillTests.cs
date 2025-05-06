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
    public class SearchSkillTests : Hooks
    {
        SearchSkillSteps searchSkillStepsObj;
        HomePageSteps homePageStepsObj;
        ProfileMenuTabsComponents profileMenuTabsComponentsObj;

        [SetUp]
        public void Init()
        {
            searchSkillStepsObj = new SearchSkillSteps();
            homePageStepsObj = new HomePageSteps();
            profileMenuTabsComponentsObj = new ProfileMenuTabsComponents();


        }

        [Test, Order(1), Description("Testcase : Verify search by all categories")]

        public void TestSearchSkillWithAllCategories()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\SearchSkillCategoryTestData.json";
            List<SearchSkillCategoryCredentials> credentialsList = JsonReader.GetSearchSkillCategoryList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnSearchSkill();

                searchSkillStepsObj.SearchSkillByAllCategoriesSteps(credentials);
            }

            test.Pass("Search by all categories Test case passed successfully.");
        }

        [Test, Order(2), Description("Testcase : Verify search by subcategories")]

        public void TestSearchSkillWithAllSubcategories()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\SearchSkillSubCategoryTestData.json";
            List<SearchSkillSubCategoryCredentials> credentialsList = JsonReader.GetSearchSkillSubCategoryList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnSearchSkill();

                searchSkillStepsObj.SearchSkillBySubCategoriesSteps(credentials);
            }

            test.Pass("Search by all categories Test case passed successfully.");
        }

        [Test, Order(3), Description("Testcase : Verify search by filters")]

        public void TestSearchSkillWithFilters()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\SearchSkillFilterTestData.json";
            List<SearchSkillFilterCredentials> credentialsList = JsonReader.GetSearchSkillFilterList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnSearchSkill();

                searchSkillStepsObj.SearchSkillByFilterSteps(credentials);
            }

            test.Pass("Search by all filters Test case passed successfully.");
        }
    }
}
