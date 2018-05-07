using System;

namespace Schema.Net
{
    [Serializable]
    public  class PhysicalActivity : LifestyleModification
    {
        /*The anatomy of the underlying organ system or structures associated with this entity.*/
        public  AnatomicalStructure[] associatedAnatomy;
        /*A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.*/
        public  PhysicalActivityCategory[] category;
        /*The characteristics of associated patients, such as age, gender, race etc.*/
        public  string[] epidemiology;
        /*Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.*/
        public  string[] pathophysiology;
    }
}