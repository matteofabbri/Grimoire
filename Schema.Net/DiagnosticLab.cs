using System;

namespace Schema.Net
{
    [Serializable]
    public  class DiagnosticLab : MedicalOrganization
    {
        /*A diagnostic test or procedure offered by this lab.*/
        public  MedicalTest[] availableTest;
    }
}