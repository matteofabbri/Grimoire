using System;

namespace Schema.Net
{
    [Serializable]
    public  class MedicalProcedure : MedicalEntity
    {
        /*Typical or recommended followup care after the procedure is performed.*/
        public  string[] followup;
        /*How the procedure is performed.*/
        public  string[] howPerformed;
        /*Typical preparation that a patient must undergo before having the procedure performed.*/
        public  string[] preparation;
        /*The type of procedure, for example Surgical, Noninvasive, or Percutaneous.*/
        public  MedicalProcedureType[] procedureType;
    }
}