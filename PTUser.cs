using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace PTWinMobileApp
{
    class PTUser
    {
        private const string formkey = "EvaluationForm";
        private const string usernamekey = "PTID";
        private const string datekey = "Date";
        private const string versionkey = "VersionNumber";
        private const string questionkey = "QuestionArray";

        private string userID;
        private string date;
        private string version;
        //questions


        public PTUser()
        {
            userID = "";
            date = "";
            version = "";

        }

        public PTUser(JsonObject jsonObject)
        {
            JsonObject ptUserObject = jsonObject.GetNamedObject(formkey, null);
            if (ptUserObject != null)
            {
                userID = ptUserObject.GetNamedString(usernamekey, "");
                date = ptUserObject.GetNamedString(datekey, "");
                version = ptUserObject.GetNamedString(versionkey, "");

            }
        }
        
        public JsonObject ToJsonObject()
        {
            JsonObject ptUserObject = new JsonObject();
            ptUserObject.SetNamedValue(usernamekey, JsonValue.CreateStringValue(userID));
            ptUserObject.SetNamedValue(datekey, JsonValue.CreateStringValue(date));
            ptUserObject.SetNamedValue(versionkey, JsonValue.CreateStringValue(version));
            return ptUserObject;
        }

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                userID = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                date = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                version = value;
            }
        }
    }
}
