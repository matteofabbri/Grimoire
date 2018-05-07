using System;

namespace Schema.Net
{
    [Serializable]
    public  class Physician : MedicalOrganization
    {
        /*A medical service available from this provider.*/
        public  MedicalProcedure[] availableService;
        /*A hospital with which the physician or office is affiliated.*/
        public  Hospital[] hospitalAffiliation;
        /*A medical specialty of the provider.*/
        public  MedicalSpecialty[] medicalSpecialty;
    }
}