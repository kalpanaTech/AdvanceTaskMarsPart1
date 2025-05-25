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

    public class SearchSkillSteps
    {
        SearchSkillOverviewComponent searchSkillOverviewComponentObj = new SearchSkillOverviewComponent();
        SearchSkillAssertions searchSkillAssertionsObj = new SearchSkillAssertions();

        public void SearchSkillByAllCategoriesSteps(SearchSkillCategoryCredentials credentials)
        {

            searchSkillOverviewComponentObj.SearchSkillWithAllCategories(credentials);
            searchSkillAssertionsObj.VerifySearchSkillWithAllCategories(credentials.Category);

        }
        public void SearchSkillBySubCategoriesSteps(SearchSkillSubCategoryCredentials credentials)
        {

            searchSkillOverviewComponentObj.SearchSkillWithSubCategories(credentials);
            searchSkillAssertionsObj.VerifySearchSkillWithSubCategories(credentials.SubCategory);

        }
        public void SearchSkillByFilterSteps(SearchSkillFilterCredentials credentials)
        {

            searchSkillOverviewComponentObj.SearchSkillWithFilters(credentials);
            searchSkillAssertionsObj.VerifySearchSkillWithFilter(credentials.SkillFilterOption);

        }
    }
}
