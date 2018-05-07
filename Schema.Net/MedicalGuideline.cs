using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalGuideline : MedicalEntity
    {
        /*Strength of evidence of the data used to formulate the guideline (enumerated).*/
        public  MedicalEvidenceLevel[] evidenceLevel;
        /*Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.*/
        public  string[] evidenceOrigin;
        /*string on which this guideline's recommendation was made.*/
        public  string[] guidelineDate;
        /*The medical conditions, treatments, etc. that are the subject of the guideline.*/
        public  MedicalEntity[] guidelineSubject;
    }
}