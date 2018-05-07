using System;

namespace Schema.Net
{
    [Serializable]
    public  class Drug : MedicalTherapy
    {
        /*An active ingredient, typically chemical compounds and/or biologic substances.*/
        public  string[] activeIngredient;
        /*A route by which this drug may be administered, e.g. 'oral'.*/
        public  string[] administrationRoute;
        /*Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.*/
        public  string[] alcoholWarning;
        /*An available dosage strength for the drug.*/
        public  DrugStrength[] availableStrength;
        /*Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.*/
        public  string[] breastfeedingWarning;
        /*Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).*/
        public  string[] clincalPharmacology;
        /*Cost per unit of the drug, as reported by the source being tagged.*/
        public  DrugCost[] cost;
        /*A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.*/
        public  string[] dosageForm;
        /*A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.*/
        public  DoseSchedule[] doseSchedule;
        /*The class of drug this belongs to (e.g., statins).*/
        public  DrugClass[] drugClass;
        /*Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.*/
        public  string[] foodWarning;
        /*Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.*/
        public  Drug[] interactingDrug;
        /*True if the drug is available in a generic form (regardless of name).*/
        public  string[] isAvailableGenerically;
        /*True if this item's name is a proprietary/brand name (vs. generic name).*/
        public  string[] isProprietary;
        /*Link to the drug's label details.*/
        public  string[] labelDetails;
        /*The drug or supplement's legal status, including any controlled substance schedules that apply.*/
        public  DrugLegalStatus[] legalStatus;
        /*The manufacturer of the product.*/
        public  Organization[] manufacturer;
        /*The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.*/
        public  string[] mechanismOfAction;
        /*The generic name of this drug or supplement.*/
        public  string[] nonProprietaryName;
        /*Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.*/
        public  string[] overdosage;
        /*Pregnancy category of this drug.*/
        public  DrugPregnancyCategory[] pregnancyCategory;
        /*Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.*/
        public  string[] pregnancyWarning;
        /*Link to prescribing information for the drug.*/
        public  string[] prescribingInfo;
        /*Indicates whether this drug is available by prescription or over-the-counter.*/
        public  DrugPrescriptionStatus[] prescriptionStatus;
        /*Any other drug related to this one, for example commonly-prescribed alternatives.*/
        public  Drug[] relatedDrug;
        /*Any FDA or other warnings about the drug (string or string).*/
        public  string[] warning;
    }
}