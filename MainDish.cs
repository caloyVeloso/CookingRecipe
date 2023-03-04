using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    public class MainDish:Recipe
    {
        public string MainProtein { get;private set; }
        public int CookingTime { get; private set; }

        public MainDish (string name, List<Ingredient> ingredients, Difficulty difficulty, List<string> procedure, string mainprotein, int cookingtime):
            base (name, ingredients, difficulty, procedure)
        {
            this.MainProtein = mainprotein;
            this.CookingTime = cookingtime;
        }

    }
}
