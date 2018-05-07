using System;

namespace Schema.Net
{
    [Serializable]
    public  class PathologyTest : MedicalTest
    {
        /*The type of tissue sample required for the test.*/
        public  string[] tissueSample;
    }
}