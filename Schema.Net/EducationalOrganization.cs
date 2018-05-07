using System;

namespace Schema.Net
{
    [Serializable]
    public  class EducationalOrganization : Organization
    {
        /*Alumni of educational organization.*/
        public  Person[] alumni;
    }
}