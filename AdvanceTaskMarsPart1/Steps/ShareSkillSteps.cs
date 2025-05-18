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
    public class ShareSkillSteps
    {
        ShareSkillOverviewComponent shareSkillOverviewComponentObj = new ShareSkillOverviewComponent();
        ShareSkillAssertions shareSkillAssertionsObj = new ShareSkillAssertions();

        public void AddShareSkillsSteps(ShareSkillCredentials credentials)
        {


            shareSkillOverviewComponentObj.AddShareSkills(credentials);
            try
            {
                shareSkillAssertionsObj.AddShareSkillAssertions(credentials.Title);
            }
            catch (Exception ex)
            {
                shareSkillAssertionsObj.IncompleteShareSkillAssertions();
            }

        }
    }
}
