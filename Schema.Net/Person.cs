using System;

namespace Schema.Net
{
    [Serializable]
    public  class Person : Organization
    {
        /*An additional name for a Person, can be used for a middle name.*/
        public  string[] additionalName;

        /*An organization that this person is affiliated with. For example, a school/university, a club, or a team.*/
        public  Organization[] affiliation;
        /*An educational organizations that the person is an alumni of.*/
        public  EducationalOrganization[] alumniOf;
        /*An award won by this person or for this creative work.*/
        public  string[] award;
        /*Awards won by this person or for this creative work. (legacy spelling; see singular form, award)*/
        public  string[] awards;
        /*string of birth.*/
        public  string[] birthDate;

        /*A child of the person.*/
        public  Person[] children;
        /*A colleague of the person.*/
        public  Person[] colleague;
        /*A colleague of the person (legacy spelling; see singular form, colleague).*/
        public  Person[] colleagues;

        /*string of death.*/
        public  string[] deathDate;

        /*Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the Name property.*/
        public  string[] familyName;

        /*The most generic uni-directional social relation.*/
        public  Person[] follows;
        /*Gender of the person.*/
        public  string[] gender;
        /*Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the Name property.*/
        public  string[] givenName;

        /*A contact location for a person's residence.*/
        public  ContactPoint[] homeLocation;
        /*An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.*/
        public  string[] honorificPrefix;
        /*An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.*/
        public  string[] honorificSuffix;

        /*The job title of the person (for example, Financial Manager).*/
        public  string[] jobTitle;
        /*The most generic bi-directional social/work relation.*/
        public  Person[] knows;

        /*An organization to which the person belongs.*/
        public  Organization[] memberOf;

        /*Nationality of the person.*/
        public  Country[] nationality;

        /*A parent of this person.*/
        public  Person[] parent;
        /*A parents of the person (legacy spelling; see singular form, parent).*/
        public  Person[] parents;
        /*Event that this person is a performer or participant in.*/
        public  Event[] performerIn;
        /*The most generic familial relation.*/
        public  Person[] relatedTo;

        /*A sibling of the person.*/
        public  Person[] sibling;
        /*A sibling of the person (legacy spelling; see singular form, sibling).*/
        public  Person[] siblings;
        /*The person's spouse.*/
        public  Person[] spouse;

        /*A contact location for a person's place of work.*/
        public  ContactPoint[] workLocation;
        /*Organizations that the person works for.*/
        public  Organization[] worksFor;
    }
}