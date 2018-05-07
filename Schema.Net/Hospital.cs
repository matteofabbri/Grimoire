using System;

namespace Schema.Net
{
    [Serializable]
    public  class Hospital : CivicStructure
    {
        /*A medical service available from this provider.*/
        public  MedicalProcedure[] availableService;
        /*A medical specialty of the provider.*/
        public  MedicalSpecialty[] medicalSpecialty;
    }
}