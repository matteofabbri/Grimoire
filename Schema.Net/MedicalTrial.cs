using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalTrial : MedicalStudy
    {
        /*The phase of the trial.*/
        public  string[] phase;
        /*Specifics about the trial design (enumerated).*/
        public  MedicalTrialDesign[] trialDesign;
    }
}