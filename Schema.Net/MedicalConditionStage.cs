using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalConditionStage : MedicalIntangible
    {
        /*The stage represented as a string, e.g. 3.*/
        public  string[] stageAsstring;
        /*The substage, e.g. 'a' for Stage IIIa.*/
        public  string[] subStageSuffix;
    }
}