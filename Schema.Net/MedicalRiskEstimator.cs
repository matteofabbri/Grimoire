using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalRiskEstimator : MedicalEntity
    {
        /*The condition, complication, or symptom whose risk is being estimated.*/
        public  MedicalEntity[] estimatesRiskOf;
        /*A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.*/
        public  MedicalRiskFactor[] includedRiskFactor;
    }
}