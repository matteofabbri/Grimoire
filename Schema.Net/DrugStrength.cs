using System;

namespace Schema.Net
{
    [Serializable]
    public  class DrugStrength : MedicalIntangible
    {
        /*An active ingredient, typically chemical compounds and/or biologic substances.*/
        public  string[] activeIngredient;
        /*The location in which the strength is available.*/
        public  AdministrativeArea[] availableIn;
        /*The units of an active ingredient's strength, e.g. mg.*/
        public  string[] strengthUnit;
        /*The value of an active ingredient's strength, e.g. 325.*/
        public  string[] strengthValue;
    }
}