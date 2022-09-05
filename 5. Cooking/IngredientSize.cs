namespace Cooking
{
    /// <summary>
    /// A class to hold the ingredient and the size.
    /// </summary>
    class IngredientSize
    {

        /// <summary>
        /// The ingredient. 
        /// </summary>
        public string Ingredient { get; }

        /// <summary>
        /// The size of the ingredient.
        /// </summary>
        public string Size { get; }

        /// <summary>
        /// The ingredient.
        /// </summary>
        /// <param name="ingredient">The ingredient.</param>
        /// <param name="size">The size of the ingredient.</param>
        public IngredientSize(string ingredient, string size)
        {
            this.Ingredient = ingredient;
            this.Size = size;
        }
    }
}
