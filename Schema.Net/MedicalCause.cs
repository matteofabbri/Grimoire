using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalCause : MedicalEntity
    {
        /*The condition, complication, symptom, sign, etc. caused.*/
        public  MedicalEntity[] causeOf;
    }
}