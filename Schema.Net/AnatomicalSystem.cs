using System;

namespace Schema.Net
{
    [Serializable]
    public  class AnatomicalSystem : MedicalEntity
    {
        /*If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.*/
        public  string[] associatedPathophysiology;
        /*The underlying anatomical structures, such as organs, that comprise the anatomical system.*/
        public  AnatomicalStructure[] comprisedOf;
        /*A medical condition associated with this anatomy.*/
        public  MedicalCondition[] relatedCondition;
        /*Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.*/
        public  AnatomicalStructure[] relatedStructure;
        /*A medical therapy related to this anatomy.*/
        public  MedicalTherapy[] relatedTherapy;
    }
}