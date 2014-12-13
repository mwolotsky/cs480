using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWinMobileApp
{
    public class Form
    {
        public const int FORM = 3;
        public int ptNumber;
        public DateTime appointmentDate;
        public int version;
        public string chiefComplaint;
        public DateTime dateOfInjury;
        public DateTime dateOfSurgery;
        public string injurySustained;
        public bool treated;
        public DateTime dateTreated;
        public int numOfVisits;
        public string condition;
        public bool symptomsConstant;
        public int painLevelBest;
        public int painLevelWorst;
        public List<string> listOfBetteringCodition;
        public List<string> listOfWorseningCondition;
        public List<string> medicalIntervention;
        public List<string> medicalInformation;

        public Form()
        {
            ptNumber = 0;
            appointmentDate = new DateTime();
            version = 0;
            chiefComplaint = "";
            dateOfInjury = new DateTime();
            dateOfSurgery = new DateTime();
            injurySustained = "";
            treated = false;
            dateTreated = new DateTime();
            numOfVisits = 0;
            condition = "";
            symptomsConstant = false;
            painLevelBest = 0;
            painLevelWorst = 0;
            listOfBetteringCodition = new List<string>();
            listOfWorseningCondition = new List<string>();
            medicalIntervention = new List<string>();
            medicalInformation = new List<string>();
        }

    }
}
