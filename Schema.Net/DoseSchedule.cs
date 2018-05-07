using System;

namespace Schema.Net
{
    [Serializable]
    public  class DoseSchedule : MedicalIntangible
    {
        /*The unit of the dose, e.g. 'mg'.*/
        public  string[] doseUnit;
        /*The value of the dose, e.g. 500.*/
        public  string[] doseValue;
        /*How often the dose is taken, e.g. 'daily'.*/
        public  string[] frequency;
        /*Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.*/
        public  string[] targetPopulation;
    }
}