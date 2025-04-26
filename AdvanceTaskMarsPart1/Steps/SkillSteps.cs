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
    public class SkillSteps
    {
        ProfileSkillOverviewComponent profileSkillOverviewComponentObj = new ProfileSkillOverviewComponent();
        SkillAssertions skillAssertionsObj = new SkillAssertions();


        public void AddSkillSteps(SkillCredentials credentials, ExtentTest test)
        {

            string skill = credentials.AddSkill;
            string skillLevel = credentials.SelectSkill;
            profileSkillOverviewComponentObj.AddSkillsActions(skill, skillLevel);
            skillAssertionsObj.AddSkillsAssertions(skill, test);

        }
        public void EditSkillSteps(SkillCredentials credentials, ExtentTest test)
        {
            AddSkillSteps(credentials, test);
            string skill = credentials.AddSkill;
            string skillLevel = credentials.SelectSkill;
            profileSkillOverviewComponentObj.EditSkillsActions(skill, skillLevel);
            skillAssertionsObj.EditSkillsAssertions(skill, test);
        }
        public void DeleteSkillSteps(SkillCredentials credentials, ExtentTest test)
        {
            AddSkillSteps(credentials, test);
            string skill = credentials.AddSkill;
            string skillLevel = credentials.SelectSkill;
            profileSkillOverviewComponentObj.DeleteSkillsActions(skill, skillLevel);
            skillAssertionsObj.DeleteSkillsAssertions(skill, test);
        }

    }
}
