using System;

namespace Schema.Net
{
    [Serializable]
    public  class JobPosting : Intangible
    {
        /*The base salary of the job.*/
        public  string[] baseSalary;
        /*Description of benefits associated with the job.*/
        public  string[] benefits;
        /*Publication date for the job posting.*/
        public  string[] datePosted;
        /*Educational background needed for the position.*/
        public  string[] educationRequirements;
        /*Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).*/
        public  string[] employmentType;
        /*Description of skills and experience needed for the position.*/
        public  string[] experienceRequirements;
        /*Organization offering the job position.*/
        public  Organization[] hiringOrganization;
        /*Description of bonus and commission compensation aspects of the job.*/
        public  string[] incentives;
        /*The industry associated with the job position.*/
        public  string[] industry;
        /*A (typically single) geographic location associated with the job position.*/
        public  Place[] jobLocation;
        /*Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes stringual label and formal code, with the property repeated for each applicable value.*/
        public  string[] occupationalCategory;
        /*Specific qualifications required for this role.*/
        public  string[] qualifications;
        /*Responsibilities associated with this role.*/
        public  string[] responsibilities;
        /*The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 used for the main salary information in this job posting.*/
        public  string[] salaryCurrency;
        /*Skills required to fulfill this role.*/
        public  string[] skills;
        /*Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.*/
        public  string[] specialCommitments;
        /*The title of the job.*/
        public  string[] title;
        /*The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).*/
        public  string[] workHours;
    }
}