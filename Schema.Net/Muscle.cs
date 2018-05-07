using System;

namespace Schema.Net
{
    [Serializable]
    public  class Muscle : AnatomicalStructure
    {
        /*The movement the muscle generates.*/
        public  string[] action;
        /*The muscle whose action counteracts the specified muscle.*/
        public  Muscle[] antagonist;
        /*The blood vessel that carries blood from the heart to the muscle.*/
        public  Vessel[] bloodSupply;
        /*The place of attachment of a muscle, or what the muscle moves.*/
        public  AnatomicalStructure[] insertion;
        /*The underlying innervation associated with the muscle.*/
        public  Nerve[] nerve;
        /*The place or point where a muscle arises.*/
        public  AnatomicalStructure[] origin;
    }
}