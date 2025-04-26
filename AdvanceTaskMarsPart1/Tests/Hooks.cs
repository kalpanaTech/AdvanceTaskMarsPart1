using AdvanceTaskMarsPart1.Pages;
using AdvanceTaskMarsPart1.Steps;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CompetionTaskMars.Helpers;
using CompetionTaskMars.Pages;

using CompetionTaskMars.Utilities;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

namespace CompetionTaskMars.Tests
{
    [TestFixture]
    public class Hooks : Driver
    {
        public static ExtentReports extent;
        public static ExtentTest test;

        private SignIn signInObj;
        HomePageSteps homePageStepsObj = new HomePageSteps();
        ProfileMenuTabsComponents profileMenuTabsComponentsObj = new ProfileMenuTabsComponents();



        [OneTimeSetUp]
        public void SetupReport()
        {
            // Initialize Extent Report
            var reportPath = "C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\Reports\\ExtentReport.html";
            var htmlReporter = new ExtentSparkReporter(reportPath);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            htmlReporter.Config.DocumentTitle = "Mars Advance Task Test Report";
            htmlReporter.Config.ReportName = "Automation Test Report";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard;

            extent.AddSystemInfo("Tester", "Kalpana Dissanayake");

            // Initialize WebDriver
            driver = InitializeDriver("chrome"); 

            // Perform SignIn
            signInObj = new SignIn(driver);
            var credentialsList = Utilities.JsonReader.GetSignInCredentialsList("C:\\repo\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\AdvanceTaskMarsPart1\\TestData\\SignInData.json");
            var credentials = credentialsList.First();
            signInObj.LoginActions(credentials.Email, credentials.Password);

            var testName = TestContext.CurrentContext.Test.Name;
            test = extent.CreateTest(testName);



            // Perform Cleanup Before Starting
            PerformFeatureCleanup();
            

        }
        private void PerformFeatureCleanup()
        {
            // Cleanup for Language
            homePageStepsObj.ClickOnProfileTab();
            profileMenuTabsComponentsObj.ClickLangaugesTab();
            profileMenuTabsComponentsObj.RemoveAddedLanguageDetails();

            // Cleanup for Skill
            homePageStepsObj.ClickOnProfileTab();
            profileMenuTabsComponentsObj.ClickSkillsTab();
            profileMenuTabsComponentsObj.RemoveAddedSkillsDetails();

        }

        [SetUp]
        public void SetUp()
        {
            // Initialize ExtentTest for the current test
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        }

        [TearDown]
        public void TearDown()
        {

            // Capture screenshot on failure
            var outcome = TestContext.CurrentContext.Result.Outcome.Status;
            if (outcome == TestStatus.Failed)
            {
                try
                {
                    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                    var screenshotDirectory = "Screenshots";

                    if (!Directory.Exists(screenshotDirectory))
                    {
                        Directory.CreateDirectory(screenshotDirectory);
                    }

                    var screenshotPath = $"{screenshotDirectory}/{TestContext.CurrentContext.Test.Name}.png";
                    screenshot.SaveAsFile(screenshotPath);

                    test.Fail("Test failed.")
                        .AddScreenCaptureFromPath(screenshotPath);
                }
                catch (Exception ex)
                {
                    test.Fail("Failed to capture screenshot: " + ex.Message);
                }
            }
            else
            {
                test.Pass("Test passed successfully.");
            }

           
        }

        [OneTimeTearDown]
        public void TearDownReport()
        {
          

            // Quit WebDriver
           // QuitDriver();

            // Flush Extent Report
            extent.Flush();
        }
    }
}
