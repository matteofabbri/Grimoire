using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalSignOrSymptom : MedicalEntity
    {
        /*An underlying cause. More specifically, one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.*/
        public  MedicalCause[] cause;
        /*A possible treatment to address this condition, sign or symptom.*/
        public  MedicalTherapy[] possibleTreatment;
    }
}