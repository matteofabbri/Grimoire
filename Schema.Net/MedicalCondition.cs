using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalCondition : MedicalEntity
    {
        /*The anatomy of the underlying organ system or structures associated with this entity.*/
        public  AnatomicalStructure[] associatedAnatomy;
        /*An underlying cause. More specifically, one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.*/
        public  MedicalCause[] cause;
        /*One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.*/
        public  DDxElement[] differentialDiagnosis;
        /*The characteristics of associated patients, such as age, gender, race etc.*/
        public  string[] epidemiology;
        /*The likely outcome in either the short term or long term of the medical condition.*/
        public  string[] expectedPrognosis;
        /*The expected progression of the condition if it is not treated and allowed to progress naturally.*/
        public  string[] naturalProgression;
        /*Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.*/
        public  string[] pathophysiology;
        /*A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.*/
        public  string[] possibleComplication;
        /*A possible treatment to address this condition, sign or symptom.*/
        public  MedicalTherapy[] possibleTreatment;
        /*A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.*/
        public  MedicalTherapy[] primaryPrevention;
        /*A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.*/
        public  MedicalRiskFactor[] riskFactor;
        /*A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.*/
        public  MedicalTherapy[] secondaryPrevention;
        /*A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experienceof the medical condition.*/
        public  MedicalSignOrSymptom[] signOrSymptom;
        /*The stage of the condition, if applicable.*/
        public  MedicalConditionStage[] stage;
        /*A more specific type of the condition, where applicable, for example 'Type 1 Diabetes', 'Type 2 Diabetes', or 'Gestational Diabetes' for Diabetes.*/
        public  string[] subtype;
        /*A medical test typically performed given this condition.*/
        public  MedicalTest[] typicalTest;
    }
}