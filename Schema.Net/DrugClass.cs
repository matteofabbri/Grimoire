using System;

namespace Schema.Net
{
    [Serializable]
    public  class DrugClass : MedicalTherapy
    {
        /*A drug in this drug class.*/
        public  Drug[] drug;
    }
}