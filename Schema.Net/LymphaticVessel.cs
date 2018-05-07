using System;

namespace Schema.Net
{
    [Serializable]
    public  class LymphaticVessel : Vessel
    {
        /*The vasculature the lymphatic structure originates, or afferents, from.*/
        public  Vessel[] originatesFrom;
        /*The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.*/
        public  AnatomicalStructure[] regionDrained;
        /*The vasculature the lymphatic structure runs, or efferents, to.*/
        public  Vessel[] runsTo;
    }
}