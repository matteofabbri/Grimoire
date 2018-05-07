using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalRiskScore : MedicalRiskEstimator
    {
        /*The algorithm or rules to follow to compute the score.*/
        public  string[] algorithm;
    }
}