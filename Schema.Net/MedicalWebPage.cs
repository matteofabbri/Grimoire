using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalWebPage : WebPage
    {
        /*An aspect of medical practice that is considered on the page, such as 'diagnosis', 'treatment', 'causes', 'prognosis', 'etiology', 'epidemiology', etc.*/
        public  string[] aspect;
    }
}