using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace PTWinMobileApp
{
    class PTPatient
    {
        private const string patientkey = "Patient";
        private const string fnamekey = "Fname";
        private const string lnamekey = "Lname";
        private const string occupationkey = "Occupation";
        private const string numberkey = "PatientID";
        private const string datekey = "Birthday";
        private const string agekey = "Age";
        private const string heightkey = "Height";
        private const string weightkey = "Weight";
        private const string phonekey = "Phone";
        private const string employerkey = "Employer";

        private string fname;
        private string lname;
        private string occupation;
        private int patientnumber;
        private int age;
        private DateTime birthdate;
        private int heightFeet;
        private int heightInches;
        private int weightPounds;
        private int weightOunces;
        private string phone;
        private string employer;
        private List<Form> listOfForms;
        private static int patientNumber = 0;

        public PTPatient()
        {
            fname = "";
            lname = "";
            occupation = "";
            patientnumber = 0;
            birthdate = new DateTime();
            heightFeet = 0;
            heightInches = 0;
            weightPounds = 0;
            weightOunces = 0;
            phone = "0";
            employer = "";
            listOfForms = new List<Form>();

        }

        public PTPatient(string fname, string lname, string occupation,
            DateTime birthdate, int heightFeet, int heightInches, int weightPounds, int weightOunces, string phone,
            string employer)
        {
            this.fname= fname;
            this.lname = lname;
            this.occupation = occupation;
            this.patientnumber = patientNumber++;
            this.birthdate = birthdate;
            this.heightFeet = heightFeet;
            this.heightInches = heightInches;
            this.weightPounds = weightPounds;
            this.weightOunces = weightOunces;
            this.phone = phone;
            this.employer = employer;
            this.listOfForms = new List<Form>();
        }

        public PTPatient(JsonObject jsonObject)
        {
            JsonObject patientObject = jsonObject.GetNamedObject(patientkey, null);
            if (patientObject != null)
            {
                fname = patientObject.GetNamedString(fnamekey, "");
                lname = patientObject.GetNamedString(lnamekey, "");
                patientnumber = Convert.ToInt32(patientObject.GetNamedNumber(numberkey, 0));
                occupation = patientObject.GetNamedString(occupationkey, "");
                age = Convert.ToInt32(patientObject.GetNamedNumber(agekey, 0));
                //birthdate = patientObject.GetNamedString(datekey, "");
                heightFeet = Convert.ToInt32(patientObject.GetNamedNumber(heightkey, 0));
                //heightInches = Convert.ToInt32(patientObject.GetNamedNumber())
                weightPounds = Convert.ToInt32(patientObject.GetNamedNumber(weightkey, 0));
               // phone = patientObject.GetNamedNumber(phonekey, 0);
                employer = patientObject.GetNamedString(employerkey, "");
            }

        }

        public JsonObject toJsonObject()
        {
            JsonObject patientObject = new JsonObject();
            patientObject.SetNamedValue(fnamekey, JsonValue.CreateStringValue(fname));
            patientObject.SetNamedValue(lnamekey, JsonValue.CreateStringValue(lname));
            patientObject.SetNamedValue(numberkey, JsonValue.CreateNumberValue(patientnumber));
            patientObject.SetNamedValue(occupationkey, JsonValue.CreateStringValue(occupation));
            patientObject.SetNamedValue(agekey, JsonValue.CreateNumberValue(age));
           // patientObject.SetNamedValue(datekey, JsonValue.CreateStringValue(birthdate));
           // patientObject.SetNamedValue(heightkey, JsonValue.CreateStringValue(height));
           // patientObject.SetNamedValue(weightkey, JsonValue.CreateNumberValue(weight));
            patientObject.SetNamedValue(phonekey, JsonValue.CreateStringValue(phone));
            patientObject.SetNamedValue(employerkey, JsonValue.CreateStringValue(employer));
            return patientObject;
        }

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                lname = value;
            }
        }
        public int Patientnumber
        {
            get
            {
                return patientnumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                patientnumber = value;
            }
        }
        public string Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                occupation = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                birthdate = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int HeightFeet
        {
            get
            {
                return heightFeet;
            }
            set
            {
                heightFeet = value;
            }
        }

        public int HeightInches
        {
            get
            {
                return HeightInches;
            }

            set
            {
                heightInches = value;
            }
        }
        public int WeightPounds
        {
            get
            {
                return weightPounds;
            }
            set
            {
                weightPounds = value;
            }
        }
        public int WeightOunces
        {
            get
            {
                return weightOunces;
            }
            set
            {
                weightOunces = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                phone = value;
            }
        }

        public string Employer
        {
            get
            {
                return employer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                employer = value;
            }
        }
        public List<Form> ListOfForms
        {
            get
            {
                return ListOfForms;
            }
            set
            {
                listOfForms = value;
            }
        }
    }
}
