using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalRiskFactor : MedicalEntity
    {
        /*The condition, complication, etc. influenced by this factor.*/
        public  MedicalEntity[] increasesRiskOf;
    }
}