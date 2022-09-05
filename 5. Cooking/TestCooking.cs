using System;

namespace Cooking
{

    /// <summary>
    /// A class to test the cooking class.
    /// </summary>
    class TestCooking
    {
        /// <summary>
        /// The main program.
        /// </summary>     
        static void Main(string[] args)
        {
            Cooking cooking = new Cooking("Pancakes");
            cooking.AddIngredients("Flour", "1.5 Cups");
            cooking.AddIngredients("Baking powder", "3.5 Teaspoons");
            cooking.AddIngredients("Salt", "0.25 Teaspoons");
            cooking.AddIngredients("White sugar", "1 Tablespoon");
            cooking.AddIngredients("Milk", "1.25 Cups");
            cooking.AddIngredients("Egg", "1");
            cooking.AddIngredients("Butter", "3 Tablespoons");

            cooking.AddTime(0,20,0);

            cooking.Display();
        }
    }
}
