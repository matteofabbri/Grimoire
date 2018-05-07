using System;

namespace Schema.Net
{
    [Serializable]
    public  class AnatomicalStructure : MedicalEntity
    {
        /*If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.*/
        public  string[] associatedPathophysiology;
        /*Location in the body of the anatomical structure.*/
        public  string[] bodyLocation;
        /*Other anatomical structures to which this structure is connected.*/
        public  AnatomicalStructure[] connectedTo;
        /*An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.*/
        public  ImageObject[] diagram;
        /*Function of the anatomical structure.*/
        public  string[] function;
        /*The anatomical or organ system that this structure is part of.*/
        public  AnatomicalSystem[] partOfSystem;
        /*A medical condition associated with this anatomy.*/
        public  MedicalCondition[] relatedCondition;
        /*A medical therapy related to this anatomy.*/
        public  MedicalTherapy[] relatedTherapy;
        /*Component (sub-)structure(s) that comprise this anatomical structure.*/
        public  AnatomicalStructure[] subStructure;
    }
}