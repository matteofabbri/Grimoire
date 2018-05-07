using System;

namespace Schema.Net
{
    [Serializable]
    public  class Recipe : CreativeWork
    {
        /*The method of cooking, such as Frying, Steaming, ...*/
        /*The time it takes to actually cook the dish, in ISO 8601 duration format.*/
        public  string[] cookTime;
        public  string[] cookingMethod;
        /*An ingredient used in the recipe.*/
        public  string[] ingredients;
        /*Nutrition information about the recipe.*/
        public  NutritionInformation[] nutrition;
        /*The length of time it takes to prepare the recipe, in ISO 8601 duration format.*/
        public  string[] prepTime;
        /*The category of the recipe&#x2014;for example, appetizer, entree, etc.*/
        public  string[] recipeCategory;
        /*The cuisine of the recipe (for example, French or Ethopian).*/
        public  string[] recipeCuisine;
        /*The steps to make the dish.*/
        public  string[] recipeInstructions;
        /*The quantity produced by the recipe (for example, string of people served, string of servings, etc).*/
        public  string[] recipeYield;
        /*The total time it takes to prepare and cook the recipe, in ISO 8601 duration format.*/
        public  string[] totalTime;
    }
}