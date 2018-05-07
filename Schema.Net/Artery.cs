using System;

namespace Schema.Net
{
    [Serializable]
    public  class Artery : Vessel
    {
        /*The branches that comprise the arterial structure.*/
        public  AnatomicalStructure[] arterialBranch;
        /*The anatomical or organ system that the artery originates from.*/
        public  AnatomicalStructure[] source;
        /*The area to which the artery supplies blood to.*/
        public  AnatomicalStructure[] supplyTo;
    }
}