using AdvanceTaskMarsPart1.Assertions;
using AdvanceTaskMarsPart1.Model;
using AdvanceTaskMarsPart1.Pages;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart1.Steps
{
    public class LanguageSteps
    {
        ProfileLanguageOverviewComponent profileLanguageOverviewComponentObj = new ProfileLanguageOverviewComponent();
        LanguageAssertions languageAssertionsObj =  new LanguageAssertions();



        public void AddLanguage(LanguageCredentials credentials, ExtentTest test)
        {

            string language = credentials.AddLanguage;
            string languageLevel = credentials.ChooseLanguageLevel;
            profileLanguageOverviewComponentObj.AddLanguageActions(language, languageLevel);
            languageAssertionsObj.AddLanguageAssertions(language, test);


        }
    }
}
