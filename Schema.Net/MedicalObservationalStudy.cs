using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalObservationalStudy : MedicalStudy
    {
        /*Specifics about the observational study design (enumerated).*/
        public  MedicalObservationalStudyDesign[] studyDesign;
    }
}