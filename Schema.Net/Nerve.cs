using System;

namespace Schema.Net
{
    [Serializable]
    public  class Nerve : AnatomicalStructure
    {
        /*The branches that delineate from the nerve bundle.*/
        public  AnatomicalStructure[] branch;
        /*The neurological pathway extension that involves muscle control.*/
        public  Muscle[] nerveMotor;
        /*The neurological pathway extension that inputs and sends information to the brain or spinal cord.*/
        public  AnatomicalStructure[] sensoryUnit;
        /*The neurological pathway that originates the neurons.*/
        public  BrainStructure[] sourcedFrom;
    }
}