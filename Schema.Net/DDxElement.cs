using System;

namespace Schema.Net
{
    [Serializable]
    public  class DDxElement : MedicalIntangible
    {
        /*One or more alternative conditions considered in the differential diagnosis process.*/
        public  MedicalCondition[] diagnosis;
        /*One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.*/
        public  MedicalSignOrSymptom[] distinguishingSign;
    }
}