using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    internal class Appetizer:Recipe
    {
        public int BiteSize { get;private set; }
        
        public Appetizer(string name, List<Ingredient> ingredients, int servingSize, Difficulty difficulty, List<string> procedure,int bitesize):
            base (name, ingredients, servingSize, difficulty, procedure)
        {
            this.BiteSize = bitesize;
        }
    }
}
