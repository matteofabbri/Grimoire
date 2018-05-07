using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalStudy : MedicalEntity
    {
        /*Expected or actual outcomes of the study.*/
        public  string[] outcome;
        /*Any characteristics of the population used in the study, e.g. 'males under 65'.*/
        public  string[] population;
        /*Sponsor of the study.*/
        public  Organization[] sponsor;
        /*The status of the study (enumerated).*/
        public  MedicalStudyStatus[] status;
        /*The location in which the study is taking/took place.*/
        public  AdministrativeArea[] studyLocation;
        /*A subject of the study, i.e. one of the medical conditions, therapies, devices, drugs, etc. investigated by the study.*/
        public  MedicalEntity[] studySubject;
    }
}