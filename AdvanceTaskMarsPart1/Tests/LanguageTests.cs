﻿using AdvanceTaskMarsPart1.Assertions;
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
    public class LanguageTests : Hooks
    {
        LanguageSteps languageStepsObj;
        HomePageSteps homePageStepsObj;
        ProfileMenuTabsComponents profileMenuTabsComponentsObj;
        

        [SetUp]
        public void Init()
        {
            languageStepsObj = new LanguageSteps();
            homePageStepsObj = new HomePageSteps();
            profileMenuTabsComponentsObj = new ProfileMenuTabsComponents();
           


        }

        [Test, Order(1), Description("Testcase : Add new Language")]

        public void TestAddNewLanguage()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\AddLanguageTestData.json";
            List<LanguageCredentials> credentialsList = JsonReader.GetLanguageCredentialsList(testDataPath);



            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnProfileTab();
                profileMenuTabsComponentsObj.ClickLangaugesTab();
                languageStepsObj.AddLanguage(credentials, test);
                
            }
            test.Pass("Add New Language Test case passed successfully.");


        }
        [Test, Order(2), Description("Testcase : Edit new Language")]

        public void TestEditNewLanguage()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\EditLanguageTestData.json";
            List<LanguageCredentials> credentialsList = JsonReader.GetLanguageCredentialsList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnProfileTab();
                profileMenuTabsComponentsObj.ClickLangaugesTab();
                languageStepsObj.EditLanguage(credentials, test);

            }

            test.Pass("Edit New Language Test case passed successfully.");
        }


        [Test, Order(3), Description("Testcase : Delete new Language")]

        public void TestDeleteNewLanguage()
        {
            string testDataPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\DeleteLanguageTestData.json";
            List<LanguageCredentials> credentialsList = JsonReader.GetLanguageCredentialsList(testDataPath);

            foreach (var credentials in credentialsList)
            {
                homePageStepsObj.ClickOnProfileTab();
                profileMenuTabsComponentsObj.ClickLangaugesTab();
                languageStepsObj.DeleteLanguage(credentials, test);

            }

            test.Pass("Delete New Language Test case passed successfully.");
        }
    }
}

