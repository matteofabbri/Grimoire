using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalSign : MedicalSignOrSymptom
    {
        /*A physical examination that can identify this sign.*/
        public  PhysicalExam[] identifyingExam;
        /*A diagnostic test that can identify this sign.*/
        public  MedicalTest[] identifyingTest;
    }
}