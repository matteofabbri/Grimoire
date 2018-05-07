using System;

namespace Schema.Net
{
    [Serializable]
    public  class InfectiousDisease : MedicalCondition
    {
        /*The actual infectious agent, such as a specific bacterium.*/
        public  string[] infectiousAgent;
        /*The class of infectious agent (bacteria, prion, etc.) that causes the disease.*/
        public  InfectiousAgentClass[] infectiousAgentClass;
        /*How the disease spreads, either as a route or vector, for example 'direct contact', 'Aedes aegypti', etc.*/
        public  string[] transmissionMethod;
    }
}