using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    public abstract class Recipe
    {
        //Name, Description, Ingredients, Preparation instructions, Serving size, Cuisine, Difficulty level.
        public string Name { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public int ServingSize { get; private set; }
        public Difficulty Difficulty { get; private set; }

        public List<string> Procedure;

        public Recipe(string name,List<Ingredient> ingredients,Difficulty difficulty,List<string> procedure) 
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Difficulty = difficulty;
            this.Procedure  = procedure;
        }
    }
}
