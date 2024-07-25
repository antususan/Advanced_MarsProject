
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_ProjectMars;
using Advanced_ProjectMars;
using Advanced_ProjectMars;
using Advanced_ProjectMars;
using Advanced_ProjectMars;
using Newtonsoft.Json;

namespace Advanced_ProjectMars.Utilities
{
    public class JsonHelper
    {
        private readonly string _JsonFilePath;
        public JsonHelper(string jsonFilePath)
        {
            _JsonFilePath = jsonFilePath;
        }

        public List<ObjLoginData> ReadLoginData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjLoginData> list = JsonConvert.DeserializeObject<List<ObjLoginData>>(json);
            return list;
        }

        public List<ObjAddLanguageUsingValidData> ReadAddLanguageUsingValidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddLanguageUsingValidData> list = JsonConvert.DeserializeObject<List<ObjAddLanguageUsingValidData>>(json);
            return list;
        }

        public List<ObjAddLanguageUsingExistingData> ReadAddLanguageUsingExistingData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddLanguageUsingExistingData> list = JsonConvert.DeserializeObject<List<ObjAddLanguageUsingExistingData>>(json);
            return list;
        }

        public List<ObjAddLanguageUsingInvalidData> ReadAddLanguageUsingInvalidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddLanguageUsingInvalidData> list = JsonConvert.DeserializeObject<List<ObjAddLanguageUsingInvalidData>>(json);
            return list;
        }

        public List<ObjEditLanguageUsingValidData> ReadEditLanguageUsingvalidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjEditLanguageUsingValidData> list = JsonConvert.DeserializeObject<List<ObjEditLanguageUsingValidData>>(json);
            return list;
        }

        
        public List<ObjDeleteLanguageData> ReadDeleteLanguageData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjDeleteLanguageData> list = JsonConvert.DeserializeObject<List<ObjDeleteLanguageData>>(json);
            return list;
        }

        public List<ObjAddSkillUsingValidData> ReadAddSkillUsingValidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddSkillUsingValidData> list = JsonConvert.DeserializeObject<List<ObjAddSkillUsingValidData>>(json);
            return list;
        }
        public List<ObjAddSkillUsingExistingData> ReadAddSkillUsingExistingData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddSkillUsingExistingData> list = JsonConvert.DeserializeObject<List<ObjAddSkillUsingExistingData>>(json);
            return list;
        }
        public List<ObjAddSkillUsingInvalidData> ReadAddSkillUsingInvalidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddSkillUsingInvalidData> list = JsonConvert.DeserializeObject<List<ObjAddSkillUsingInvalidData>>(json);
            return list;
        }

        public List<ObjEditSkillUsingValidData> ReadEditSkillUsingvalidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjEditSkillUsingValidData> list = JsonConvert.DeserializeObject<List<ObjEditSkillUsingValidData>>(json);
            return list;
        }
        public List<ObjDeleteSkillData> ReadDeleteSkillData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjDeleteSkillData> list = JsonConvert.DeserializeObject<List<ObjDeleteSkillData>>(json);
            return list;
        }
        public List<ObjUpdateAboutProfileData> ReadUpdateAboutProfileData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjUpdateAboutProfileData> list = JsonConvert.DeserializeObject<List<ObjUpdateAboutProfileData>>(json);
            return list;
        }
        public List<ObjAddShareSkillRecordUsingValidData> ReadCreateShareSkillRecordUsingValidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddShareSkillRecordUsingValidData> list = JsonConvert.DeserializeObject<List<ObjAddShareSkillRecordUsingValidData>>(json);
            return list;
        }

        public List<ObjAddShareSkillUsingInvalidData> ReadCreateShareSkillRecordUsingInValidData()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjAddShareSkillUsingInvalidData> list = JsonConvert.DeserializeObject<List<ObjAddShareSkillUsingInvalidData>>(json);
            return list;
        }

        public List<ObjSearchSkillByMainAndSubCategory> ReadSearchSkillByMainAndSubCategory()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjSearchSkillByMainAndSubCategory> list = JsonConvert.DeserializeObject<List<ObjSearchSkillByMainAndSubCategory>>(json);
            return list;
        }
        public List<ObjSearchSkillByFilter> ReadSearchSkillByFilter()
        {
            using StreamReader reader = new StreamReader(_JsonFilePath);
            var json = reader.ReadToEnd();
            List<ObjSearchSkillByFilter> list = JsonConvert.DeserializeObject<List<ObjSearchSkillByFilter>>(json);
            return list;
        }
        






    }
}

