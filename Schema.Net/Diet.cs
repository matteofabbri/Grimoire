using System;

namespace Schema.Net
{
    [Serializable]
    public  class Diet : CreativeWork
    {
        /*Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.*/
        public  string[] dietFeatures;
        /*People or organizations that endorse the plan.*/
        public  Organization[] endorsers;
        /*Medical expert advice related to the plan.*/
        public  string[] expertConsiderations;
        /*Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.*/
        public  string[] overview;
        /*Specific physiologic benefits associated to the plan.*/
        public  string[] physiologicalBenefits;
        /*Proprietary name given to the diet plan, typically by its originator or creator.*/
        public  string[] proprietaryName;
        /*Specific physiologic risks associated to the plan.*/
        public  string[] risks;
    }
}