using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    public class MainDish:Recipe
    {
        public String MainProtein { get;private set; }
        public string  CookingTime { get; private set; }

        public MainDish (string name, List<Ingredient> ingredients, Difficulty difficulty, List<string> procedure, string cookingtime):
            base (name, ingredients, difficulty, procedure)
        {
            this.MainProtein = ingredients[0].Name;
            this.CookingTime = cookingtime;
        }
    }
}
