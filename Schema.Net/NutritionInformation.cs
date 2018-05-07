using System;

namespace Schema.Net
{
    [Serializable]
    public  class NutritionInformation : StructuredValue
    {
        /*The string of calories*/
        public  string[] calories;
        /*The string of grams of carbohydrates.*/
        public  string[] carbohydrateContent;
        /*The string of milligrams of cholesterol.*/
        public  string[] cholesterolContent;
        /*The string of grams of fat.*/
        public  string[] fatContent;
        /*The string of grams of fiber.*/
        public  string[] fiberContent;
        /*The string of grams of protein.*/
        public  string[] proteinContent;
        /*The string of grams of saturated fat.*/
        public  string[] saturatedFatContent;
        /*The serving size, in terms of the string of volume or mass*/
        public  string[] servingSize;
        /*The string of milligrams of sodium.*/
        public  string[] sodiumContent;
        /*The string of grams of sugar.*/
        public  string[] sugarContent;
        /*The string of grams of trans fat.*/
        public  string[] transFatContent;
        /*The string of grams of unsaturated fat.*/
        public  string[] unsaturatedFatContent;
    }
}