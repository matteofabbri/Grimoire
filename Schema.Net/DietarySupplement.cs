using System;

namespace Schema.Net
{
    [Serializable]
    public  class DietarySupplement : MedicalTherapy
    {
        /*An active ingredient, typically chemical compounds and/or biologic substances.*/
        public  string[] activeIngredient;
        /*Descriptive information establishing a historical perspective on the supplement. May include the rationale for the name, the population where the supplement first came to prominence, etc.*/
        public  string[] background;
        /*A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.*/
        public  string[] dosageForm;
        /*True if this item's name is a proprietary/brand name (vs. generic name).*/
        public  string[] isProprietary;
        /*The drug or supplement's legal status, including any controlled substance schedules that apply.*/
        public  DrugLegalStatus[] legalStatus;
        /*The manufacturer of the product.*/
        public  Organization[] manufacturer;
        /*Recommended intake of this supplement for a given population as defined by a specific recommending authority.*/
        public  MaximumDoseSchedule[] maximumIntake;
        /*The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.*/
        public  string[] mechanismOfAction;
        /*The generic name of this drug or supplement.*/
        public  string[] nonProprietaryName;
        /*Recommended intake of this supplement for a given population as defined by a specific recommending authority.*/
        public  RecommendedDoseSchedule[] recommendedIntake;
        /*Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.*/
        public  string[] safetyConsideration;
        /*Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.*/
        public  string[] targetPopulation;
    }
}