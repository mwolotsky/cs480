using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWinMobileApp
{
    class Form
    {
        int ptNumber;
        DateTime appointmentDate;
        int version;
        string chiefComplaint;
        DateTime dateOfInjury;
        DateTime dateOfSurgery;
        string injurySustained;
        Boolean treated;
        DateTime dateTreated;
        int numOfVisits;
        string condition;
        Boolean symptomsConstant;
        int painLevelBest;
        int painLevelWorst;
        List<string> listOfBetteringCodition;
        List<string> listOfWorseningCondition;
        List<string> previousMedicalIntervention;
        List<string> medicalIntervention;

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
            previousMedicalIntervention = new List<string>();
            medicalIntervention = new List<string>();
        }

    }
}
