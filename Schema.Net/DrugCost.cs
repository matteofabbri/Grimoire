using System;

namespace Schema.Net
{
    [Serializable]
    public  class DrugCost : MedicalIntangible
    {
        /*The location in which the status applies.*/
        public  AdministrativeArea[] applicableLocation;
        /*The category of cost, such as wholesale, retail, reimbursement cap, etc.*/
        public  DrugCostCategory[] costCategory;
        /*The currency (in 3-letter ISO 4217 format) of the drug cost.*/
        public  string[] costCurrency;
        /*Additional details to capture the origin of the cost data. For example, 'Medicare Part B'.*/
        public  string[] costOrigin;
        /*The cost per unit of the drug.*/
        public  string[] costPerUnit;
        /*The unit in which the drug is measured, e.g. '5 mg tablet'.*/
        public  string[] drugUnit;
    }
}