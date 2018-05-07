using System;

namespace Schema.Net
{
    [Serializable]
    public  class SuperficialAnatomy : MedicalEntity
    {
        /*If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.*/
        public  string[] associatedPathophysiology;
        /*Anatomical systems or structures that relate to the superficial anatomy.*/
        public  AnatomicalStructure[] relatedAnatomy;
        /*A medical condition associated with this anatomy.*/
        public  MedicalCondition[] relatedCondition;
        /*A medical therapy related to this anatomy.*/
        public  MedicalTherapy[] relatedTherapy;
        /*The significance associated with the superficial anatomy; as an example, how characteristics of the superficial anatomy can suggest underlying medical conditions or courses of treatment.*/
        public  string[] significance;
    }
}