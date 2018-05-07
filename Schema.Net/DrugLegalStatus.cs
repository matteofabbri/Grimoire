using System;

namespace Schema.Net
{
    [Serializable]
    public  class DrugLegalStatus : MedicalIntangible
    {
        /*The location in which the status applies.*/
        public  AdministrativeArea[] applicableLocation;
    }
}