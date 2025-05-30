﻿using Newtonsoft.Json;
using CompetionTaskMars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AdvanceTaskMarsPart1.Model;

namespace CompetionTaskMars.Utilities
{
    public static class JsonReader
    {

        public static List<SignInCreadentials> GetSignInCredentialsList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<SignInCreadentials>>(jsonData);
        }

        public static List<LanguageCredentials> GetLanguageCredentialsList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<LanguageCredentials>>(jsonData);
        }
        public static List<SkillCredentials> GetSkillCredentialsList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<SkillCredentials>>(jsonData);
        }
        public static List<SearchSkillCategoryCredentials> GetSearchSkillCategoryList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<SearchSkillCategoryCredentials>>(jsonData);
        }

        public static List<SearchSkillSubCategoryCredentials> GetSearchSkillSubCategoryList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<SearchSkillSubCategoryCredentials>>(jsonData);
        }

        public static List<SearchSkillFilterCredentials> GetSearchSkillFilterList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<SearchSkillFilterCredentials>>(jsonData);
        }
        public static List<ShareSkillCredentials> GetShareSkillCredentialsList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<ShareSkillCredentials>>(jsonData);
        }

        public static List<UserDetailCredentials> GetUserDetailCredentialsList(string jsonFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<UserDetailCredentials>>(jsonData);
        }

    }
}
