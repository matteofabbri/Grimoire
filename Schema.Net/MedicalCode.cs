using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalCode : MedicalIntangible
    {
        /*The actual code.*/
        public  string[] codeValue;
        /*The coding system, e.g. 'ICD-10'.*/
        public  string[] codingSystem;
    }
}