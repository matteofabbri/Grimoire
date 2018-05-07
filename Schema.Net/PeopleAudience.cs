using System;

namespace Schema.Net
{
    [Serializable]
    public  class PeopleAudience : Audience
    {
        /*Expectations for health conditions of target audience*/
        public  MedicalCondition[] healthCondition;
        /*The gender of the person or audience.*/
        public  string[] suggestedGender;
        /*Maximal age recommended for viewing content*/
        public  string[] suggestedMaxAge;
        /*Minimal age recommended for viewing content*/
        public  string[] suggestedMinAge;
    }
}