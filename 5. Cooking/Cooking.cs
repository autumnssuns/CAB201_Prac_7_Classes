using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking
{
    /// <summary>
    /// A class that represents a recipe.
    /// </summary>
    class Cooking
    {
        /// <summary>
        /// The name of the recipe.
        /// </summary>
        private string recipe;

        /// <summary>
        /// The ingredients. 
        /// </summary>
        private List<string> ingredients;

        /// <summary>
        /// The sizes of the ingredients.
        /// </summary>
        private List<string> sizes;

        /// <summary>
        /// The hour it takes to cook the recipe.
        /// </summary>
        private int hour;

        /// <summary>
        /// The minute it takes to cook the recipe.
        /// </summary>
        private int minute;

        /// <summary>
        /// The second it takes to cook the recipe.
        /// </summary>
        private int second;

        /// <summary>
        /// The cooking recipe. 
        /// </summary>
        /// <param name="recipe">The name of the recipe.</param>
        public Cooking(string recipe)
        {
            this.recipe = recipe;
            ingredients = new List<string>();
            sizes = new List<string>();
            hour = 0;
            minute = 0;
            second = 0;
        }

        /// <summary>
        /// Adds an ingredient.
        /// </summary>
        /// <param name="ingredient">The ingredient.</param>
        /// <param name="size">The size.</param>
        public void AddIngredients(string ingredient, string size)
        {
            ingredients.Add(ingredient);
            sizes.Add(size);
        }

        /// <summary>
        /// The time is takes to cook the recipe.
        /// </summary>
        /// <param name="hour">The hour it takes to cook the recipe.</param>
        /// <param name="minute">The hour it takes to cook the recipe.</param>
        /// <param name="second">The hour it takes to cook the recipe.</param>
        public void AddTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        /// <summary>
        /// Displays the recipe.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Displaying recipe for " + recipe);

            Console.WriteLine("The ingredients are:");
            for(int i =0; i< ingredients.Count(); i++)
            {
                Console.WriteLine(ingredients[i] + "\t" + sizes[i]);
            }

            Console.WriteLine("The time taken to prodce the task was : " + hour + ":" + minute + ":" + second);

        }

    }
}
