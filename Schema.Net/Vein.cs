using System;

namespace Schema.Net
{
    [Serializable]
    public  class Vein : Vessel
    {
        /*The vasculature that the vein drains into.*/
        public  Vessel[] drainsTo;
        /*The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.*/
        public  AnatomicalStructure[] regionDrained;
        /*The anatomical or organ system that the vein flows into; a larger structure that the vein connects to.*/
        public  AnatomicalStructure[] tributary;
    }
}