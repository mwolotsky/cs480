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
        public static int PT = 100;
        public static int MANAGER = 300;

        private int userID;
        private string userName;
        private string password;
        private int type;
        private DateTime dateCreated;

        public List<PTPatient> listOfPatients = new List<PTPatient>();

        public PTUser()
        {
            userID = -1;
            userName = "";
            password = "";
            dateCreated = new DateTime();
            type = 0;
            password = "";

        }

        public PTUser(int userID, string userName, string password, DateTime dateCreated, int type )
        {
            this.userID = userID;
            this.userName = userName;
            this.password = password;
            this.dateCreated = dateCreated;
            this.type = type;
        }

        public PTUser(JsonObject jsonObject)
        {
            JsonObject ptUserObject = jsonObject.GetNamedObject(formkey, null);
            if (ptUserObject != null)
            {
                //userID = ptUserObject.GetNamedString(usernamekey, "");
                //date = ptUserObject.GetNamedString(datekey, "");
                //version = ptUserObject.GetNamedString(versionkey, "");

            }
        }
        
        public JsonObject ToJsonObject()
        {
            JsonObject ptUserObject = new JsonObject();
            //ptUserObject.SetNamedValue(usernamekey, JsonValue.CreateStringValue(userID));
            //ptUserObject.SetNamedValue(datekey, JsonValue.CreateStringValue(date));
            //ptUserObject.SetNamedValue(versionkey, JsonValue.CreateStringValue(version));
            return ptUserObject;
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }


        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                dateCreated = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }
        }
    }
}
