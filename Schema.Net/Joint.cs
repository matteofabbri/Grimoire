using System;

namespace Schema.Net
{
    [Serializable]
    public  class Joint : AnatomicalStructure
    {
        /*The biomechanical properties of the bone.*/
        public  string[] biomechnicalClass;
        /*The degree of mobility the joint allows.*/
        public  string[] functionalClass;
        /*The name given to how bone physically connects to each other.*/
        public  string[] structuralClass;
    }
}