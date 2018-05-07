using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalTest : MedicalEntity
    {
        /*Drugs that affect the test's results.*/
        public  Drug[] affectedBy;
        /*Range of acceptable values for a typical patient, when applicable.*/
        public  string[] normalRange;
        /*A sign detected by the test.*/
        public  MedicalSign[] signDetected;
        /*A condition the test is used to diagnose.*/
        public  MedicalCondition[] usedToDiagnose;
        /*Device used to perform the test.*/
        public  MedicalDevice[] usesDevice;
    }
}