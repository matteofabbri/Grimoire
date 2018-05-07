using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalGuidelineRecommendation : MedicalGuideline
    {
        /*Strength of the guideline's recommendation (e.g. 'class I').*/
        public  string[] recommendationStrength;
    }
}