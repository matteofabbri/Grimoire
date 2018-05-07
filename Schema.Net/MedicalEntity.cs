using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalEntity : Thing
    {
        /*Any alternate name for this medical entity.*/
        public  string[] alternateName;
        /*A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.*/
        public  MedicalCode[] code;
        /*A medical guideline related to this entity.*/
        public  MedicalGuideline[] guideline;
        /*The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.*/
        public  MedicineSystem[] medicineSystem;
        /*If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.*/
        public  Organization[] recognizingAuthority;
        /*If applicable, a medical specialty in which this entity is relevant.*/
        public  MedicalSpecialty[] relevantSpecialty;
        /*A medical study or trial related to this entity.*/
        public  MedicalStudy[] study;
    }
}