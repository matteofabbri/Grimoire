using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalDevice : MedicalEntity
    {
        /*A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.*/
        public  MedicalEntity[] adverseOutcome;
        /*A contraindication for this therapy.*/
        public  MedicalContraindication[] contraindication;
        /*A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.*/
        public  MedicalIndication[] indication;
        /*A description of the postoperative procedures, care, and/or followups for this device.*/
        public  string[] postOp;
        /*A description of the workup, testing, and other preparations required before implanting this device.*/
        public  string[] preOp;
        /*A description of the procedure involved in setting up, using, and/or installing the device.*/
        public  string[] procedure;
        /*The purpose or purposes of this device, for example whether it is intended for diagnostic or therapeutic use.*/
        public  MedicalDevicePurpose[] purpose;
        /*A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.*/
        public  MedicalEntity[] seriousAdverseOutcome;
    }
}