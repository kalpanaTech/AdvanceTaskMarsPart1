using AdvanceTaskMarsPart1.Model;
using AdvanceTaskMarsPart1.Pages;
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



        public void AddLanguage(LanguageCredentials credentials)
        {

            string language = credentials.AddLanguage;
            string languageLevel = credentials.ChooseLanguageLevel;
            profileLanguageOverviewComponentObj.AddLanguageActions(language, languageLevel);
           

        }
    }
}
