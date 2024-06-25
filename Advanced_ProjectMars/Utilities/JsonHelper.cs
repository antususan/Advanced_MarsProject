
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    

    }
}

